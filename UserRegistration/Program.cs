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
            ValidateLastName();

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
        */

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

    }
}
