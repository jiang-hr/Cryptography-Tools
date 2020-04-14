using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Tools.basicTools
{
    //
    // 摘要:
    //     本程序的基类异常，所有异常应当继承于此。
    public class CrypException : Exception
    {
        public string Error { get; set; }
        public Exception innerException;
        public CrypException() { }
        public CrypException(string message) : base(message) => Error = message;
        public CrypException(string message, Exception innerException) : base(message)
        {
            this.innerException = innerException;
            Error = message;
        }
    }

    //
    // 如果一个本应当是素数的数被检测出不是素数，则抛出此异常。
    public class NotPrimeException : CrypException
    {
        public NotPrimeException() { }
        public NotPrimeException(string message) : base(message) => Error = message;
    }

    //
    // 如果检测出φ(n) != phiN，则抛出此异常。
    public class NandPhiNException : CrypException
    {
        public NandPhiNException() { }
        public NandPhiNException(string message) : base(message) => Error = message;
    }

    //
    // 当求逆时并没有逆元时抛出。
    public class InvertException : CrypException
    {
        public InvertException() { }
        public InvertException(string message) : base(message) => Error = message;
    }
}
