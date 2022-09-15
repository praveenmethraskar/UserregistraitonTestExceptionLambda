using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationTestExceptionLambda
{
    public class REGEX_Registration
    {
        //UC1

        public static string First_Name = "^[A-Z]{1}[a-z]{2,10}$";

        public bool ValidateFirstName(string sample)
        {
            return Regex.IsMatch(sample, First_Name);

        }

        //UC2

        public static string Last_Name = "^[A-Z]{1}[a-z]{2,10}$";

        public bool ValidateLastName(string sample)
        {
            return Regex.IsMatch(sample, Last_Name);

        }

        //UC3

        public static string E_Mail = "^[A-Za-z]{3,}([.]{1}[A-Za-z]{3,})*[@][a-z]{2,}[.][a-z]{2,}([.][a-zA-Z]{2})?$";

        public bool ValidateEmail(string sample)
        {
            return Regex.IsMatch(sample, E_Mail);

        }

        //UC4

        public static string PhNumber = "^91([ ])?[6-9]{1}[0-9]{9}$";

        public bool ValidatePhNumber(string sample)
        {
            return Regex.IsMatch(sample, PhNumber);

        }

        //UC5

        public static string PasswordRule1 = "^[a-zA-Z]{8}$";

        public bool ValidatePassword1(string sample)
        {
            return Regex.IsMatch(sample, PasswordRule1);

        }

        //UC6

        public static string PasswordRule2 = "(?=.*[A-Z])[a-zA-Z]{8,}$";

        public bool ValidatePassword2(string sample)
        {
            return Regex.IsMatch(sample, PasswordRule2);

        }

        //UC7

        public static string PasswordRule3 = "(?=.*?[A-Z])(?=.*?[0-9])[a-zA-Z0-9]{8,}$";

        public bool ValidatePassword3(string sample)
        {
            return Regex.IsMatch(sample, PasswordRule3);

        }

        //UC8

        public static string PasswordRule4 = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";

        public bool ValidatePassword4(string sample)
        {
            return Regex.IsMatch(sample, PasswordRule4);

        }


        //UC9

        public static string SampleEmail = "^[a-zA-Z0-9]+([#$%+_-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public bool ValidateSampleEmail(string sample)
        {
            return Regex.IsMatch(sample, SampleEmail);

        }

        //UC13

        //Lambda Expression for First Name
        public Func<string, bool> isValidFirstName = (firstName => Regex.IsMatch(firstName, First_Name));

        //Lambda Expression for Last Name
        public Func<string, bool> isValidLastName = (lastName => Regex.IsMatch(lastName, Last_Name));

        //Lambda Expression for Email
        public Func<string, bool> isValidEmail = (eMail => Regex.IsMatch(eMail, E_Mail));

        //Lambda Expression for Phone Number
        public Func<string, bool> isValidPhNumber = (phoneNumber => Regex.IsMatch(phoneNumber, PhNumber));

        //Lambda Expression for Password
        public Func<string, bool> isValidPassword = password => Regex.IsMatch(password, PasswordRule1) || Regex.IsMatch(password, PasswordRule4);


    }
}
