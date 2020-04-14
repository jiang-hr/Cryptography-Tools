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
        }

        //
        // 摘要:
        //     Flag代表各个内容是否被赋值
        //     值为false时，也即
        //     当class Value类型当中对应为BigInteger时，值为BigInteger.Zero
        //     当中对应类型为BigInteger[]时，值为null。
        public class Flag
        {
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

        #region 主程序，循环判断是否执行子程序，循环5次。

        //
        // 摘要:
        //     Rsa加密与解密的主进程。
        public string Run()
        {
            ExceptionFlag exceptionFlag = new ExceptionFlag();
            for (int iter = 0; iter < 5; iter++)
            {
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
                            return e.Error;
                        }
                        Enable.p = true;
                        Enable.q = true;
                        Num.p = BI[0];
                        Num.q = BI[1];
                    }
                }
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
                            return e.Error;
                        }
                    }
                    Havepq();
                }
                if (Enable.phi_n && (Enable.d || Enable.e))
                {
                    if (Enable.d && Enable.e && !exceptionFlag.dMuleModPhiNisOne)
                    {
                        if ((Num.d * Num.e) % Num.phi_n == BigInteger.One)
                        {
                            exceptionFlag.dMuleModPhiNisOne = true;
                        }
                        else
                        {
                            return "e * d != 1 (mod φ(n))，数据有误！";
                        }
                    }
                    else if (!Enable.d && Enable.e)
                    {
                        try
                        {
                            Num.d = BigIntegerTools.Invert(Num.e, Num.phi_n);
                        }
                        catch(InvertException e)
                        {
                            return e.Error;
                        }
                        Enable.d = true;
                    }
                    else if(Enable.d && !Enable.e)
                    {
                        try
                        {
                            Num.e = BigIntegerTools.Invert(Num.d, Num.phi_n);
                        }
                        catch (InvertException e)
                        {
                            return e.Error;
                        }
                        Enable.e = true;
                    }
                }
            }
            return "No exception! Good.\r\n";
        }

        #endregion

        //
        // 当p，q两个质数都出现时，完成整个程序的部分计算。
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
    }
}

