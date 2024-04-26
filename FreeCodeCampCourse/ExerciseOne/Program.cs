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
            ExerciseOne();
            ExerciseTwo();
            ExerciseThree();
            ExerciseFour();
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

        static void ExerciseFour()
        {
            /*
             * Ask user to enter a password, and store.
             * Ask user to enter the password again, and store.
             * Check if they both contain certain items:
             *  * Capital letter, 
             *  * Number, 
             *  * Special character.
             * If they do, check if they are the same.
             *  * If they are, print "Password is correct"
             *  * If they are not, print "A valid password has been set."
             * If they are empty, print "Please enter a password"
             */
            bool isPasswordMatch = false;
            while(!isPasswordMatch)
            {
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();
                password = password.Trim();

                if(!ConfirmPasswordStrength(password))
                {
                    continue;   //Start afresh and include the required characters
                }

                Console.Write("Enter the password again: ");
                string passwordAgain = Console.ReadLine();
                passwordAgain = passwordAgain.Trim();

                if (!ConfirmPasswordStrength(passwordAgain))
                {
                    continue;   //Start afresh and include the required characters
                }

                if (password.Equals(passwordAgain))
                {
                    Console.WriteLine("A valid password has been set.");
                    isPasswordMatch = true;
                }
                else
                {
                    Console.WriteLine("Passwords do not match.");
                }
            }
        }

        static bool ConfirmPasswordStrength(string pwd)
        {
            bool hasCapital = false;
            bool hasNumber = false;
            bool hasSpecial = false;

            if(pwd.Length < 6)
            {
                Console.WriteLine("Password is too short.");
                return false;
            }

            if(string.IsNullOrEmpty(pwd))
            {
                Console.WriteLine("Please enter a password.");
                return false;
            }

            for (int i = 0; i < pwd.Length; i++)
            {
                if (char.IsUpper(pwd[i]))
                {
                    hasCapital = true;
                }
                else if (char.IsDigit(pwd[i]))
                {
                    hasNumber = true;
                }
                else if (!char.IsLetterOrDigit(pwd[i]))
                {
                    hasSpecial = true;
                }
            }

            if (!hasCapital)
            {
                Console.WriteLine("Password must contain at least one capital letter.");
                return false;
            }
            else if (!hasNumber)
            {
                Console.WriteLine("Password must contain at least one number.");
                return false;
            }
            else if (!hasSpecial)
            {
                Console.WriteLine("Password must contain at least one special character.");
                return false;
            }
            else
            {
                return true;    
            }
        }
    }
}
