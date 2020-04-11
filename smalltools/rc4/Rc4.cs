using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Tools.smalltools.rc4
{
    class Rc4
    {
        private readonly int len = 256;

        //Key是arg混淆过后的密钥
        public char[] Key;

        //arg是密钥，inil用来混淆arg
        public void inil(string arg)
        {
            //初始化密码
            Key = new char[len];
            //中间变量
            int[] k = new int[len];
            for (int i = 0; i < len; ++i)
            {
                Key[i] = arg[i % arg.Length];
                k[i] = i;
            }
            int j = 0;
            for (int i = 0; i < len; ++i)
            {
                j = (j + Key[i] + i) % len;
                var temp = Key[i];
                Key[i] = Key[j];
                Key[j] = temp;
            }
        }

        //data是明文或者密文，都一样。
        public string Crypt(string data)
        {
            string Data = "";
            int i = 0, j = 0;
            for (int k = 0; k < data.Length; k++)
            {
                i = (i + 1) % len;
                j = (j + Key[i]) % len;
                var tmp = Key[i];
                Key[i] = Key[j];
                Key[j] = tmp;
                int t = (Key[i] + Key[j]) % len;
                Data += (char)(data[k] ^ Key[t]);
                //Data += " ";
            }
            return Data;
        }
    }
}
