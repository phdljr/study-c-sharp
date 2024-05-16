using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVP.CustomException
{
    internal class NotMatchPasswordException : Exception
    {
        public NotMatchPasswordException() : base() 
        { 
        }

        public NotMatchPasswordException(string? message) : base(message)
        {
        }

        public NotMatchPasswordException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
