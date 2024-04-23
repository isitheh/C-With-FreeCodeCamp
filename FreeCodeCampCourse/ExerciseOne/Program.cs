using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoringUserData();
            SomeOperations();
            Console.ReadLine();
        }

        static void StoringUserData()
        {
            /*
             * Define a variable to store the user's name
             * Define a variable to store the user's age
             * Define a variable to store the user's phone number
             * Print variables to the console line by line
             * Extra: Define a variable using the var keyword
             */
            string name = "John Doe";
            int age = 35;
            string phoneNumber = "0858569854";
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone Number: " + phoneNumber);
            var address = "1234 Elm St";
            Console.WriteLine("Address: " + address);
        }

        static void SomeOperations()
        {
            /*
             * Create and initialise two integer variables
             * Make a variable to work out the remainder
             * Output the remainder to the console
             * Change the first int variable to another number
             * Recalculate the remainder
             */
            int firstNumber = 10;
            int secondNumber = 2;
            int remainder = firstNumber % secondNumber;
            Console.WriteLine("The remainder of (10/5) is: " + remainder);
            EvenOrOddPrintout(remainder, firstNumber);
            firstNumber = 15;
            remainder = firstNumber % secondNumber;
            Console.WriteLine("The remainder of ({0}/{1}) is: {2}", firstNumber, secondNumber, remainder);
            EvenOrOddPrintout(remainder, firstNumber);
        }

        static void EvenOrOddPrintout(int remainder, int divider)
        {
            if (remainder == 0)
            {
                Console.WriteLine("The number {0} is even.", divider);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.", divider);
            }
        }
    }
}
