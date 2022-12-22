using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Exceptions
{
    public class AccountOperationException : Exception
    {
        public AccountOperationException() : base()
        {
        }
        public AccountOperationException(string message) : base(message)
        {
        }
        public AccountOperationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
