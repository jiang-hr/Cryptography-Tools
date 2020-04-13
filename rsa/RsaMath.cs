using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Tools.rsa
{
    class RsaMath
    {
        public RsaMath()
        {
            Enable = new Flag();
            Num = new Value();
        }

        public Flag Enable { get; set; }

        public Value Num { get; set; }



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

    }
}
