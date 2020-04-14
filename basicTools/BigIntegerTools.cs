using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Tools.basicTools
{
    //
    // 摘要:
    //     适用用于大整数工具的函数，原来的BigInteger类里面没用这些方法，
    //     于是造出来这些函数供自己使用。
    //     注意此类里面的所有方法均为static属性。
    class BigIntegerTools
    {
        private static BigInteger SubsidiarySqrt(BigInteger N, BigInteger L, BigInteger R)
        {
            if (L != R)
            {
                BigInteger mid = (L + R + 1) / 2;
                return (N < mid * mid) ? SubsidiarySqrt(N, L, mid - 1) : SubsidiarySqrt(N, mid, R);
            }
            return L;
        }

        //
        // 大整数开平方，注意必须满足x为完全平方数，
        // 否则返回0。
        public static BigInteger Sqrt(BigInteger x)
        {
            BigInteger y = SubsidiarySqrt(x, 1, x);
            if (BigInteger.Pow(y, 2) == x)
            {
                return SubsidiarySqrt(x, 1, x);
            }
            return BigInteger.Zero;
        }

        //
        // 输入字符串，并用换行符分割，如果合法十进制数组则返回true。
        public static bool IsArrayDigit(string args)
        {
            var arrayDigit = args.Split("\r\n".ToCharArray());
            foreach (var x in arrayDigit)
            {
                // 分割之后，index为奇数的string会把"\r\n"变成空字符串！
                // 此方法会占一个arrayDigit的位置！
                if (IsDigit(x) || x == "")
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        // 
        // 如果输入为合法的十进制字符串则返回true。
        // 即当输入的字符串中出现除了0,1,...,9之外的字符则返回false。
        public static bool IsDigit(string arg)
        {
            if (arg == "")
            {
                return false;
            }
            foreach (char x in arg)
            {
                if (x < '0' || x > '9')
                {
                    return false;
                }
                continue;
            }
            return true;
        }

        // 
        // 在使用此函数前请先用IsDigit检测
        // 就算输入错误字符串仍然不会抛异常！
        public static BigInteger ToInteger(string arg)
        {
            BigInteger bigInteger = BigInteger.Zero;
            foreach (var x in arg)
            {
                bigInteger *= 10;
                bigInteger += x - '0';
            }
            return bigInteger;
        }

        public static string ToString(BigInteger[] args)
        {
            var ans = "";
            for (int i = 0; i <= args.Length - 2; i++)
            {
                ans += args[i].ToString();
                ans += "\r\n";
            }
            ans += args[args.Length - 1].ToString();
            return ans;
        }

        //
        // 求逆，求出k，使得 k * x = 1 (mod n) ( 0 <= k < n )
        public static BigInteger Invert(BigInteger x, BigInteger n)
        {
            if (Gcd(x, n) != BigInteger.One)
            {
                throw new InvertException(x.ToString()+" 与 " + n.ToString()
                    +" 的最小公倍数不是 1 ，没有逆元！");
            }
            var xy = Bezout(x, n);
            return xy[0] < 0 ? xy[0] + n : xy[0];
        }

        //
        // 返回x,y使得 a * x + b * y == gcd(a,b)
        public static BigInteger[] Bezout(BigInteger a, BigInteger b)
        {
            if (b != BigInteger.Zero)
            {
                var k = a / b;
                var remainder = a % b;
                BigInteger[] Newxy = Bezout(b, remainder);
                BigInteger[] xy = new BigInteger[] { Newxy[1], Newxy[0] - k * Newxy[1] };
                return xy;
            }
            else
            {
                return new BigInteger[] { 1, 0 };
            }
        }

        public static BigInteger Gcd(BigInteger x, BigInteger y)
        {
            if (x == 0 || y == 0)
            {
                return (x > y) ? x : y;
            }
            return x > y ? Gcd(y, x % y) : Gcd(x, y % x);
        }

        public static BigInteger Lcm(BigInteger x, BigInteger y)
        {
            return x * y / Gcd(x, y);
        }
    }
}
