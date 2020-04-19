using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Tools.rsa
{
    class RsaWinnerAttack
    {
        public static List<BigInteger> Transform(BigInteger x, BigInteger y)
        {
            List<BigInteger> bigIntegers = new List<BigInteger>();
            while (y != BigInteger.Zero)
            {
                bigIntegers.Add(x / y);
                var temp = x;
                x = y;
                y = temp % y;
            }
            return bigIntegers;
        }

        public static BigInteger[] ContinuedFraction()
        {
            return null;
        }

    }
}
