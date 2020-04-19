using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cryptography_Tools.basicTools;

namespace Cryptography_Tools.rsa
{
    class RsaMath
    {
        //
        // 这个类只有默认构造函数
        public RsaMath()
        {
            Enable = new Flag();
            Num = new Value();
        }

        public Flag Enable { get; set; }
        public Value Num { get; set; }

        // 
        // 摘要:
        //     由于用户很可能输入错误的数字，为了防止程序发生异常，
        //     需要检测用户输入是否合法。为了防止检测是否合法重复计算多次
        //     浪费资源，故设立此flag表示若为true则检测过了。
        private class ExceptionFlag
        {
            public bool pIsPrime = false;//p是否是质数检测完成标志。
            public bool qIsPrime = false;//q是否是质数检测完成标志。
            public bool nAndPhiNisRight = false;//φ(n) == phi_n 检测完成标志。
            public bool dMuleModPhiNisOne = false;//d * e == 1 (mod phi_n)检测完成标志。
            public bool breakDownN = false;//尝试强硬分解 n 的值，当
        }

        //
        // 摘要:
        //     Flag代表各个内容是否被赋值
        //     值为false时，也即
        //     当class Value类型当中对应为BigInteger时，值为BigInteger.Zero
        //     当中对应类型为BigInteger[]时，值为null。
        public class Flag
        {
            //为true时，开启进阶分析。
            public bool FurtherAnalysis = false;
            //防止日志输出多次。
            public bool mAndCisNotSameLength = false;
            //是否已运行低指数加密破解
            public bool lowExp = false;
            //是否尝试暴力分解 n
            public bool factorN = false;
            public bool n = false;
            public bool p = false;
            public bool q = false;
            public bool phi_n = false;
            public bool e = false;
            public bool d = false;
            public bool dp = false;
            public bool dq = false;
            public bool m = false;
            public bool c = false;
        }

        //
        // 摘要:
        //     储存用户在界面输入的值。
        public class Value
        {
            public BigInteger n;
            public BigInteger p;
            public BigInteger q;
            public BigInteger phi_n;
            public BigInteger e;
            public BigInteger d;
            public BigInteger dp;
            public BigInteger dq;
            public BigInteger[] m;
            public BigInteger[] c;
        }

        #region 主程序，循环判断是否执行子程序，循环7次。

        //
        // 摘要:
        //     Rsa加密与解密的主进程。
        public string Run()
        {
            string message = "";
            ExceptionFlag exceptionFlag = new ExceptionFlag();
            for (int iter = 0; iter < 7; iter++)
            {
                // n,phi_n 还有 p,q 各存在一个时。
                if (Enable.n || Enable.phi_n)
                {
                    try
                    {
                        if (Enable.n && Enable.p && !Enable.q)
                        {
                            Num.q = RsaBasicMethod.KnownpCalq(Num.n, Num.p);
                            Enable.q = true;
                        }
                        if (Enable.n && Enable.q && !Enable.p)
                        {
                            Num.p = RsaBasicMethod.KnownpCalq(Num.n, Num.q);
                            Enable.p = true;
                        }
                        if (Enable.phi_n && Enable.p && !Enable.q)
                        {
                            Num.q = RsaBasicMethod.KnowPhiNpCalQ(Num.phi_n, Num.p);
                            Enable.q = true;
                        }
                        if (Enable.phi_n && Enable.q && !Enable.p)
                        {
                            Num.p = RsaBasicMethod.KnowPhiNpCalQ(Num.phi_n, Num.q);
                            Enable.p = true;
                        }
                    }
                    catch (NotDivisibleException e)
                    {
                        return message + e.Error;
                    }
                }
                //当n和phi_n都存在时生成数据p,q。
                if (Enable.n && Enable.phi_n && !exceptionFlag.nAndPhiNisRight)
                {
                    if (!Enable.p || !Enable.q)
                    {
                        BigInteger[] BI;
                        try
                        {
                            BI = RsaBasicMethod.KnownphinCalpq(Num.n, Num.phi_n);
                            exceptionFlag.nAndPhiNisRight = true;
                        }
                        catch (NandPhiNException e)
                        {
                            return message + e.Error;
                        }
                        Enable.p = true;
                        Enable.q = true;
                        Num.p = BI[0];
                        Num.q = BI[1];
                    }
                }
                // 当p和q存在时计算其它数据。
                if (Enable.p && Enable.q)
                {
                    if (!exceptionFlag.pIsPrime || !exceptionFlag.qIsPrime)
                    {
                        try
                        {
                            exceptionFlag.pIsPrime = !RsaBasicMethod.IsNotPrime(Num.p);
                            exceptionFlag.pIsPrime = true;
                            exceptionFlag.qIsPrime = !RsaBasicMethod.IsNotPrime(Num.q);
                            exceptionFlag.qIsPrime = true;
                        }
                        catch (NotPrimeException e)
                        {
                            return message + e.Error;
                        }
                    }
                    Havepq();
                }
                // 当 phi_n 存在时，若有 d 无 e，则计算 e 的值；若有 e 无 d，则计算 d 的值
                if (Enable.phi_n && (Enable.d || Enable.e))
                {
                    //若 phi_n , d , e 均存在时，计算是否合理。
                    if (Enable.d && Enable.e && !exceptionFlag.dMuleModPhiNisOne)
                    {
                        if ((Num.d * Num.e) % Num.phi_n == BigInteger.One)
                        {
                            exceptionFlag.dMuleModPhiNisOne = true;
                        }
                        else
                        {
                            return message + "e * d != 1 (mod φ(n))，数据有误！";
                        }
                    }
                    else if (!Enable.d && Enable.e)
                    {
                        try
                        {
                            Num.d = BigIntegerTools.Invert(Num.e, Num.phi_n);
                        }
                        catch (InvertException e)
                        {
                            return message + e.Error;
                        }
                        Enable.d = true;
                    }
                    else if (Enable.d && !Enable.e)
                    {
                        try
                        {
                            Num.e = BigIntegerTools.Invert(Num.d, Num.phi_n);
                        }
                        catch (InvertException e)
                        {
                            return message + e.Error;
                        }
                        Enable.e = true;
                    }
                }
                //rsa最原始的普通加密
                if (Enable.n && Enable.e && Enable.m && !Enable.c)
                {
                    Enable.c = true;
                    Num.c = new BigInteger[Num.m.Length];
                    for (int i = 0; i < Num.m.Length; i++)
                    {
                        Num.c[i] = BigInteger.ModPow(Num.m[i], Num.e, Num.n);
                    }
                }
                //rsa最原始的普通解密
                if (Enable.n && Enable.d && Enable.c && !Enable.m)
                {
                    Enable.m = true;
                    Num.m = new BigInteger[Num.c.Length];
                    for (int i = 0; i < Num.c.Length; i++)
                    {
                        Num.m[i] = BigInteger.ModPow(Num.c[i], Num.d, Num.n);
                    }
                }

                //当进阶分析开启时，在第 3 轮到第 5 轮之间加入进阶分析
                if (iter >= 2 && iter <= 4 && Enable.FurtherAnalysis)
                {
                    try
                    {
                        message += RsaCtfRun();
                    }
                    catch (Exception e)
                    {
                        return message + e.Message;
                    }
                }
            }
            return message + "No exception! Good.\r\n";
        }

        #endregion

        //
        // 当p，q两个质数都出现时，完成整个程序的部分内容生成。
        private void Havepq()
        {
            if (!Enable.n)
            {
                Enable.n = true;
                Num.n = RsaBasicMethod.KnowpqCaln(Num.p, Num.q);
            }
            if (!Enable.phi_n)
            {
                Enable.phi_n = true;
                Num.phi_n = RsaBasicMethod.KnowpqCalphin(Num.p, Num.q);
            }
            if (Enable.d)
            {
                if (!Enable.dp)
                {
                    Enable.dp = true;
                    Num.dp = RsaBasicMethod.KnowpdCaldp(Num.d, Num.p);
                }
                if (!Enable.dq)
                {
                    Enable.dq = true;
                    Num.dq = RsaBasicMethod.KnowpdCaldp(Num.d, Num.q);
                }
            }
        }

        //
        // 进阶版分析数据
        private string RsaCtfRun()
        {
            string message = "";
            if (Enable.p && Enable.q && Enable.dp && Enable.dq && Enable.c && !Enable.m)
            {
                Num.m = new BigInteger[Num.c.Length];
                for (int i = 0; i < Num.c.Length; i++)
                {
                    Num.m[i] = RsaDecryptCtf.KnowDpDqPQcCalM(Num.p, Num.q, Num.dp, Num.dq, Num.c[i]);
                }
                Enable.m = true;
                message += "通过dp,dq,p,q,c解密m成功!\r\n";
            }
            if (Enable.e && Num.e < 100000000)
            {
                if (Enable.dp && Enable.n && !Enable.p && !Enable.q && !Enable.phi_n && !Enable.dq)
                {
                    var temp = RsaDecryptCtf.KnowNeDpCalD(Num.n, Num.e, Num.dp);
                    Enable.p = true;
                    Enable.q = true;
                    Enable.phi_n = true;
                    Enable.d = true;
                    Num.p = temp[0];
                    Num.q = temp[1];
                    Num.phi_n = temp[2];
                    Num.d = temp[3];
                    message += "dp泄露攻击成功!\r\n";
                }
                if (Enable.dq && Enable.n && !Enable.p && !Enable.q && !Enable.phi_n && !Enable.dp)
                {
                    var temp = RsaDecryptCtf.KnowNeDpCalD(Num.n, Num.e, Num.dq);
                    Enable.q = true;
                    Enable.p = true;
                    Enable.phi_n = true;
                    Enable.d = true;
                    Num.q = temp[0];
                    Num.p = temp[1];
                    Num.phi_n = temp[2];
                    Num.d = temp[3];
                    message += "dp泄露攻击成功!\r\n";
                }
            }

            //当已知明文 m 和密文 c 时，做如下这些事
            if (Enable.c && Enable.m)
            {
                if (Num.c.Length != Num.m.Length)
                {
                    if (!Enable.mAndCisNotSameLength)
                    {
                        Enable.mAndCisNotSameLength = true;
                        message += "暂不支持当明文和密文同时存在时但数量不相同的情况！\r\n";
                    }
                }
                else
                {
                    //Do something in there!!!
                }
            }

            //低指数攻击！
            if (!Enable.lowExp && Enable.e && Num.e <= 17 && !Enable.p && !Enable.q && Enable.n && !Enable.phi_n)
            {
                Num.m = new BigInteger[Num.c.Length];
                message += "低指数攻击进行中！\r\n";
                for (int i = 0; i < Num.c.Length; i++)
                {
                    Num.m[i] = RsaDecryptCtf.KnowEcCalM((int)Num.e, Num.c[i], Num.n, 84000 / Num.c.Length);
                    if (Num.m[i] == 0)
                    {
                        message += "第" + (i + 1) + "行密文解密失败！";
                    }
                }
                Enable.m = true;
                Enable.lowExp = true;
            }

            //暴力分解 n
            if(!Enable.factorN && Enable.n && !Enable.p && !Enable.q && !Enable.phi_n)
            {
                Enable.factorN = true;
                message += "暴力分解n中! \r\n";
                BigInteger[] bigIntegers = RsaDecryptCtf.Factor(Num.n);
                if(bigIntegers == null)
                {
                    message += "尝试分解失败\r\n";
                    bigIntegers = RsaDecryptCtf.MyFactor(Num.n);
                    if (bigIntegers == null)
                    {
                        message += "再次尝试分解失败\r\n";
                    }
                    else
                    {
                        Enable.p = true;
                        Num.p = bigIntegers[0];
                        Enable.q = true;
                        Num.q = bigIntegers[1];
                        message += "再次暴力分解成功！\r\n";
                    }
                }
                else
                {
                    Enable.p = true;
                    Num.p = bigIntegers[0];
                    Enable.q = true;
                    Num.q = bigIntegers[1];
                    message += "暴力分解成功！\r\n";
                }
            }

            return message;
        }
    }
}

