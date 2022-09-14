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
        public static string First_Name = "^[A-Z]{1}[a-z]{2,10}$";

        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, First_Name);

        }
    }
}
