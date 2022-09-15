using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationTestExceptionLambda
{
    public class UserRegister
    {
        //variable
        private string message;

        public UserRegister(string message)
        {
            this.message = message;
        }

        public string firstName()
        {
            if (this.message.Contains("Happy"))
            {
                return "Successful Entry";
            }
            else
            {
                return "Un-Successful Entry";
            }
        }

        public string lastName()
        {
            if (this.message.Contains("Happy"))
            {
                return "Successful Entry";
            }
            else
            {
                return "Un-Successful Entry";
            }
        }
        public string Email()
        {
            if (this.message.Contains("Happy"))
            {
                return "Successful Entry";
            }
            else
            {
                return "Un-Successful Entry";
            }
        }

        public string PhoneNumber()
        {
            if (this.message.Contains("Happy"))
            {
                return "Successful Entry";
            }
            else
            {
                return "Un-Successful Entry";
            }
        }
        public string Password()
        {
            if (this.message.Contains("Happy"))
            {
                return "Successful Entry";
            }
            else
            {
                return "Un-Successful Entry";
            }
        }

    }
}
