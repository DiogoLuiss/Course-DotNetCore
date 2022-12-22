using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Exceptions
{
    public class InsufficientBalanceException : AccountOperationException 
    {

        public  InsufficientBalanceException(string message) : base(message) { }

   


    }

}
