using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationTestExceptionLambda
{
    public class UserRegCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_PHONENUMBER,
            INVALID_PASSWORD,

        }

        public readonly ExceptionType Type;

        public UserRegCustomException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}
