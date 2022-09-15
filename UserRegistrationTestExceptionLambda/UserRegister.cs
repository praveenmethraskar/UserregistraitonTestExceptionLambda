using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationTestExceptionLambda
{
    public class UserRegister
    {
        //Creating object of REGEX_Registration Class to use in UC11
        REGEX_Registration multi = new REGEX_Registration();


        //UC10
        //variable
        private string message;
        public UserRegister()
        {

        }

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

        //UC11 Validate Multiple Emails
        public string MultiEmails(string s1, string s2, string s3)
        {
            //Using object of REGEX_Registration class to Call method here
            bool E1 = multi.ValidateEmail(s1);

            bool E2 = multi.ValidateEmail(s2);

            bool E3 = multi.ValidateEmail(s3);

            if (E1 && E2 && E3)
            {
                return "Successful Entry";
            }
            else
            {
                return "Un-Successful Entry";
            }

        }

        //UC12 Custom Exception

        public void CheckFirstName(string firstName)
        {
            if (multi.ValidateFirstName(firstName))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {

                throw new UserRegCustomException(UserRegCustomException.ExceptionType.INVALID_FIRSTNAME, "First Name is Invalid");

            }
        }

        public void CheckLastName(string lastName)
        {
            if (multi.ValidateLastName(lastName))
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {

                throw new UserRegCustomException(UserRegCustomException.ExceptionType.INVALID_LASTNAME, "Last Name is Invalid");

            }
        }

        public void CheckEmail(string eMail)
        {
            if (multi.ValidateEmail(eMail))
            {
                Console.WriteLine("Valid Email");
            }
            else
            {

                throw new UserRegCustomException(UserRegCustomException.ExceptionType.INVALID_EMAIL, "Email is Invalid");

            }
        }

        public void CheckPhoneNumber(string phNumber)
        {
            if (multi.ValidatePhNumber(phNumber))
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {

                throw new UserRegCustomException(UserRegCustomException.ExceptionType.INVALID_PHONENUMBER, "Phone Number is Invalid");

            }
        }

        public void CheckPassword(string password)
        {
            //comparting two Password methods
            if (multi.ValidatePassword1(password) && multi.ValidatePassword4(password))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {

                throw new UserRegCustomException(UserRegCustomException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");

            }
        }

    }
}
