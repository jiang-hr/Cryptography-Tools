using System.Collections.Generic;
using System.Numerics;

namespace Cryptography_Tools.basicTools
{
    class BigIntegerPrime
    {
        private BigInteger begin = 2;
        private BigInteger next = 2;

        // 这个方法过烂，请不要使用，请用埃筛或者线性筛改进它！
        public IEnumerable<BigInteger> GeneratePrime()
        {
            yield return 2;
            while (true)
            {
                bool flag = false;
                next++;
                for (BigInteger i = begin; i <= BigIntegerTools.SubsidiarySqrt(next,1,next); i++)
                {
                    if (next % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    yield return next;
                }
            }
        }


    }
}
