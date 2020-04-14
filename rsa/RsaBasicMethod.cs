using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Cryptography_Tools.basicTools;

namespace Cryptography_Tools.rsa
{
    class RsaBasicMethod
    {
        //
        //大致判断一下是不是质数，不是质数甩出异常
        public static bool IsNotPrime(BigInteger p)
        {
            foreach (var prime in ResourcePool.primeTable)
            {
                if (p <= prime)
                {
                    break;
                }
                else if (p % prime == 0)
                {
                    throw new NotPrimeException(p.ToString() + "不是质数，它能被" + prime.ToString() + "整除！\r\n");
                }
            }
            return false;
        }

        public static BigInteger KnowpqCaln(BigInteger p, BigInteger q)
        {
            return p * q;
        }

        public static BigInteger KnowpqCalphin(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        public static BigInteger[] KnownphinCalpq(BigInteger n, BigInteger phin)
        {
            // phi(n) = p * q - (p + q) +1;
            // n = p * q;
            var pAddq = n - phin + 1;
            BigInteger psubqpow2 = BigInteger.Pow(pAddq, 2) - n * 4;
            var psubq = BigIntegerTools.Sqrt(psubqpow2);
            if(psubq == BigInteger.Zero)
            {
                throw new NandPhiNException("n和phi(n)不满足要求，输入有误！\r\n");
            }
            return new BigInteger[] { (psubq + pAddq) / 2, (pAddq - psubq) / 2 };
        }

        public static BigInteger KnownpCalq(BigInteger n, BigInteger p)
        {
            return n / p;
        }

        public static BigInteger KnowpdCaldp(BigInteger d,BigInteger p)
        {
            return d % (p - 1);
        }
    }
}
