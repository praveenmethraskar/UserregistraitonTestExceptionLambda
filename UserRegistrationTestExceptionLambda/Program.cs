using System;

namespace UserRegistrationTestExceptionLambda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to REGEX User Registration Program");

            //UC12

            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();

            REGEX_Registration regex = new REGEX_Registration();
            //if regex is valid 
            //it executes as valid firstname
            //otherwise invalid firstname
            if (regex.ValidateFirstName(firstName))
            {
                Console.WriteLine("First Name is VALID !!");
            }
            else
            {
                Console.WriteLine("First Name is INVALID !!");
            }

            Console.WriteLine("::::::::::::::::::::::::::::::");
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();

            if (regex.ValidateLastName(lastName))
            {


                Console.WriteLine("Last Name is VALID !!");
            }
            else
            {
                Console.WriteLine("Last Name is INVALID !!");
            }

            Console.WriteLine("::::::::::::::::::::::::::::::");
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();

            if (regex.ValidateLastName(email))
            {
                Console.WriteLine("Email is VALID !!");
            }
            else
            {
                Console.WriteLine("Email is INVALID !!");
            }

            Console.WriteLine("::::::::::::::::::::::::::::::");
            Console.WriteLine("Enter PhoneNumber :");
            string phNumber = Console.ReadLine();

            if (regex.ValidateLastName(phNumber))
            {
                Console.WriteLine("Phone Number is VALID !!");
            }
            else
            {
                Console.WriteLine("Phone Number is INVALID !!");
            }


            Console.WriteLine("::::::::::::::::::::::::::::::");
            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();

            if (regex.ValidateLastName(password))
            {
                Console.WriteLine("Password is VALID !!");
            }
            else
            {
                Console.WriteLine("Password is INVALID !!");
            }


        }
    }
    }
}