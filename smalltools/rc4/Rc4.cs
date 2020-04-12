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
        public void Inil(string arg)
        {
            //初始化密码
            Key = new char[len];
            if (arg.Length == 0)
            {
                return;
            }
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
        public char[] Crypt(char[] data)
        {
            char[] Data = new char[data.Length];
            int i = 0, j = 0;
            for (int k = 0; k < data.Length; k++)
            {
                i = (i + 1) % len;
                j = (j + Key[i]) % len;
                var tmp = Key[i];
                Key[i] = Key[j];
                Key[j] = tmp;
                int t = (Key[i] + Key[j]) % len;
                Data[k] = (char)(data[k] ^ Key[t]);
            }
            return Data;
        }

        public char[] HexCrypt(string data)
        {
            char[] Data = new char[data.Length * 2];
            int i = 0, j = 0;
            for (int k = 0; k < data.Length; k++)
            {
                i = (i + 1) % len;
                j = (j + Key[i]) % len;
                var tmp = Key[i];
                Key[i] = Key[j];
                Key[j] = tmp;
                int t = (Key[i] + Key[j]) % len;
                var temp = data[k] ^ Key[t];
                Data[2*k] = this.Hex(temp)[0];
                Data[2 * k+1] = this.Hex(temp)[1];
            }
            return Data;
        }

        //16进制化
        private string Hex(int x)
        {
            string[] alphabet = { "0", "1", "2","3","4","5","6","7","8","9","A","B","C","D","E","F" };
            string first = alphabet[x % 16];
            string last = alphabet[x / 16];
            return last + first;
        }

        //args接收类似5A这样的Hex数，并转为ASCii🐎。
        public char AntiHex(string arg)
        {
            int[] num = new int[2];
            for(int i = 0; i < 2; i++)
            {
                if(arg[i]<= '9')
                {
                    num[i] = arg[i] - '0';
                }
                else
                {
                    num[i] = arg[i] - 'A' + 10;
                }
            }
            return (char)(16 * num[0] + num[1]);
        }

    }
}
