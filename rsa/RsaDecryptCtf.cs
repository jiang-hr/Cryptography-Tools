using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Cryptography_Tools.basicTools;

namespace Cryptography_Tools.rsa
{
    //
    // 这些方法为进阶方法，使用时请注意，未设置抛出异常，程序有可能崩溃。
    class RsaDecryptCtf
    {

        //
        // 摘要:
        //     已知 p,q,dp,dq,c，求 m 的值。
        //     这是电脑在计算明文时真正使用的方法，用d来pow太慢，不需要d！
        // 参数:
        //     c ≡ m^e (\mod n)
        //     m ≡ c^d (\mod n)
        //     ϕ(n) = (p−1)∗(q−1)
        //     d * e ≡ 1 (\mod ϕ(n))
        //     dp ≡ d (\mod(p−1))
        //     dq ≡ d (\mod(q−1))
        public static BigInteger KnowDpDqPQcCalM(BigInteger p, BigInteger q, BigInteger dp, BigInteger dq, BigInteger c)
        {
            // 记 m = c^d + k * n;
            // 记 m_p ≡ c^d (\mod p)
            BigInteger mp = BigInteger.ModPow(c, dp, p);
            // 记 m = k * p + mp
            // mq ≡ k * p + mp (\mod q)
            BigInteger mq = BigInteger.ModPow(c, dq, q);
            // k ≡ (mq - mp) * p^{-1} (\mod q)
            var invPofQ = BigIntegerTools.Invert(p, q);
            // 下面一定是对的，k 一定 < q
            BigInteger k = (mq - mp) * invPofQ % q;
            // c^d = ((mq - mp) * p^{-1} (\mod q)) + m_p 
            BigInteger m = k * p + mp;
            return m;
        }

        // 
        // 摘要:
        //     dp泄露：
        //     由于电脑是用dp，dq来加密的，若其中一个泄露出去
        //     便可以通过公钥 n , e 推算出d的值.
        // 注意:
        //     参数设置时 e 不能过大！否则会卡死。(一般 e 不会很大)
        //     未设置抛出异常！
        // 返回值:
        //      new BigInteger[]{ p ,q ,phi_n ,d }
        public static BigInteger[] KnowNeDpCalD(BigInteger n,BigInteger e,BigInteger dp)
        {
            for (int i = 1; i <= e; i++)
            {
                //由于 dp ≡ d (\mod(p−1))
                //必然有 i 使得 (p - 1) * i + dp = d
                //此时(p - 1) * i * e + dp * e = d * e = (p - 1) * (q - 1) * k
                //此时dp * e ≡ 1 (\mod(p−1))
                //所以(dp * e - 1) 是p - 1的倍数，只需要在dp * e - 1的因数里寻找。
                if ((dp * e - 1) % i == 0)
                {
                    // 此时你会发现 dp * e ≡ 1 (\mod i)
                    if (n % (((dp * e - 1) / i) + 1) == 0)
                    {
                        BigInteger p = ((dp * e - 1) / i) + 1;
                        BigInteger q = n / p;
                        BigInteger phi_n = (p - 1) * (q - 1);
                        BigInteger d = BigIntegerTools.Invert(e, phi_n);
                        return new BigInteger[] { p, q, phi_n, d };
                    }
                }
            }
            return null;
        }

    }
}
