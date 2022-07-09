using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("\n");

            // Validation for First Name
            //ValidateFirstName();

            // Validation for Last Name
            //ValidateLastName();

            // Validate for Email
            //ValidateEmail();

            // Validate for mobile
            //ValidateMobileNumber();

            // Validate for Password
            //ValidatePassword();

            // Validate for Password with Upper case
            //ValidatePasswordWithOneUpperCase();

            // Validate for Password with one Upper case, one numeric and special character
            ValidatePasswordWithOneUpperCaseAndOneNumericAndSpecialCharacter();

        }
        /*
        public static void ValidateFirstName() {

            Console.WriteLine("First name should starts with capital letter and it should have atleast 3 Characters.");
            Console.WriteLine("Enter first name");
            string input = Console.ReadLine();

            var result = Regex.IsMatch(input, @"^[A-Z]{1,}[a-zA-Z]{2,}$");

            if (result)
            {
                Console.WriteLine("The first name is validated successfully");
            }
            else
            {
                Console.WriteLine("The first name is not validated");
            }
            Console.ReadLine();
        }
        
        // Creating method for  last name validation
        public static void ValidateLastName()
        {

            Console.WriteLine("Last name should starts with capital letter and it should have atleast 3 Characters.");
            Console.WriteLine("Enter last name");
            string input = Console.ReadLine();

            var result = Regex.IsMatch(input, @"^[A-Z]{1,}[a-zA-Z]{2,}$");

            if (result)
            {
                Console.WriteLine("The last name is validated successfully");
            }
            else
            {
                Console.WriteLine("The Last name is not validated");
            }
            Console.ReadLine();
        }
       
        // Creating method for  Email validation
        public static void ValidateEmail()
        {

            Console.WriteLine("Enter the valid email");
            string email = Console.ReadLine();

            var result = Regex.IsMatch(email, @"^([A-Za-z]{3,}([.a-z]*)[@][a-z]{2,}[.][a-z]{2,3}([.a-z]*))$");

            if (result)
            {
                Console.WriteLine("The entered email is validated successfully");
            }
            else
            {
                Console.WriteLine("The email is not validated");
            }
            Console.ReadLine();
        }
       
        // Creating method for  Mobile number validation
        public static void ValidateMobileNumber()
        {

            Console.WriteLine("Enter the valid mobile number");
            string mobileNo = Console.ReadLine();

            var result = Regex.IsMatch(mobileNo, @"^[1-9]{2,}[\s][6-9]{1}[0-9]{9}$");

            if (result)
            {
                Console.WriteLine("The entered mobile number is validated successfully");
            }
            else
            {
                Console.WriteLine("The mobile number is not valid");
            }
            Console.ReadLine();
        }
        // Creating method for valid Password (Min 8 Character)
        public static void ValidatePassword()
        {
            Console.WriteLine("Password Should have min 8 Characters");
            Console.WriteLine("Enter the password ");
            string password = Console.ReadLine();

            var result = Regex.IsMatch(password, @"^[a-zA-Z]{8,}$");

            if (result)
            {
                Console.WriteLine("The entered password is validated successfully");
            }
            else
            {
                Console.WriteLine("The password is not valid");
            }
            Console.ReadLine();
        }
       
        // Creating method for valid Password (Min 8 Character and atleast one upper case)
        public static void ValidatePasswordWithOneUpperCase()
        {
            Console.WriteLine("Password Should have min 8 Characters and atleast one upper case)");
            Console.WriteLine("Enter the password ");
            string password = Console.ReadLine();

            var result = Regex.IsMatch(password, @"^(?=.*[A-Z])[a-zA-Z]{8,}$");

            if (result)
            {
                Console.WriteLine("The entered password is validated successfully");
            }
            else
            {
                Console.WriteLine("The password is not valid");
            }
            Console.ReadLine();
        }
       
        // Creating method for valid Password (Min 8 Character and atleast one upper case one Numeric)
        public static void ValidatePasswordWithOneUpperCaseAndOneNumeric()
        {
            Console.WriteLine("Password Should have min 8 Characters and atleast one upper case and one numeric)");
            Console.WriteLine("Enter the password ");
            string password = Console.ReadLine();

            var result = Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$");

            if (result)
            {
                Console.WriteLine("The entered password is validated successfully");
            }
            else
            {
                Console.WriteLine("The password is not valid");
            }
            Console.ReadLine();
        }
         */

        // Creating method for valid Password (Min 8 Character and atleast one upper case,one Numeric and one special)
        public static void ValidatePasswordWithOneUpperCaseAndOneNumericAndSpecialCharacter()
        {
            Console.WriteLine("Password Should have min 8 Characters and atleast one upper case,one numeric and special character)");
            Console.WriteLine("Enter the password ");
            string password = Console.ReadLine();

            var result = Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[@#$!%^&-+=()])(?=.*[0-9])(?=.*[a-z]).{8,}$");

            if (result)
            {
                Console.WriteLine("The entered password is validated successfully");
            }
            else
            {
                Console.WriteLine("The password is not valid");
            }
            Console.ReadLine();
        }

    }
}
