using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ExerciseOne();
            ExerciseTwo();*/
            ExerciseThree();
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

        static void ExerciseOne()
        {
            StoringUserData();
            SomeOperations();
        }

        static void ExerciseTwo()
        {
            TheTimesTable();
            Console.WriteLine();
            TheDoubleTimesTable();
            FizzBuzz();
        }

        static void TheTimesTable()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Times Table: ");
            for (int i = 1; i <= number; i++)
            {
                int result = i * i;
                Console.WriteLine("{0} x {1} = {2}", i, i, result);
            }
        }

        static void TheDoubleTimesTable()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Tables for {0}", i);
                for (int j = 1; j <= number; j++)
                {
                    int result = i * j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, result);
                }
            }
        }

        static void FizzBuzz()
        {
            bool fizz;
            bool buzz;
            for (int i = 1; i <= 15; i++)
            {
                fizz = (i % 3 == 0);
                buzz = (i % 5 == 0);
                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ExerciseThree()
        {
            Console.Write("Input a message: ");
            string message = Console.ReadLine();
            
            //Print the message in order
            for(int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            //Print the message in reverse
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
                Thread.Sleep(100);
            } 
            Console.WriteLine();
        }
    }
}
