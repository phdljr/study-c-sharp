using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVP.CustomException
{
    internal class AlreadyExistsUsernameException : Exception
    {
        public AlreadyExistsUsernameException() : base() 
        {
        }

        public AlreadyExistsUsernameException(string? message) : base(message) 
        {
        }

        public AlreadyExistsUsernameException(string? message, Exception? innerException) : base(message, innerException) 
        {
        }
    }
}
