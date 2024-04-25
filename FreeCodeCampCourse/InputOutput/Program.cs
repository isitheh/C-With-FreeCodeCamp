using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadUserData();
            SimpleIOSums();
            UsingSwitchStatement();
            LearningEscapeChars();
            EmptyString();
            StringCompare();
            StringLoopIteration();
            StringValidator();  
            Console.ReadLine();
        }

        static void ReadUserData()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Hi, Your name is {0}, you are {1} years old and live at {2}: ", name + " " + surname, age, address);
            WorkingWithAge(age);
        } 
        
        static void WorkingWithAge(int age)
        {
            if (age < 0 || age > 150)
            {
                Console.WriteLine("You are not born yet. or an alien.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a minor. No alcohol for you.");
            }
            else if(age >= 18 && age < 21)
            {
                Console.WriteLine("You are a young adult. You can drink but not in the US.");
            }
            else
            {
                Console.WriteLine("You are an adult. Drink till you drop.");
            }
            Console.WriteLine("Goodbye!");
        }

        static void SimpleIOSums()
        {
            Console.Write("Please first number: ");
            int firstNumberInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please second number: ");
            int secondNumberInput = Convert.ToInt32(Console.ReadLine());

            int answer = firstNumberInput * secondNumberInput;

            Console.Write("Value of {0} x {1}: ", firstNumberInput, secondNumberInput);
            Console.WriteLine();
            int userAnswer = 0;

            while(userAnswer != answer)
            {
                userAnswer = Convert.ToInt32(Console.ReadLine());

                if(userAnswer != answer)
                {
                    Console.WriteLine("No! Try Again!");
                }
            }
            Console.WriteLine("Correct! Well Done!");
        }
        static void UsingSwitchStatement()
        {
            Console.Write("Enter the number of day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch(day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6:
                case 7: Console.WriteLine("Weekend!"); break;
                default:  Console.WriteLine("Perharps different calendar?"); break;
            }
        }

        static void LearningEscapeChars()
        {
            string text = "The program said \"Hello World!\"";
            Console.WriteLine(text);
            //Using the verbatim string
            string text2 = @"The program should always display ""Hello World!""";
            Console.WriteLine(text2);

            string firstName = "John";
            string lastName = "Doe";
            int age = 25;
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name: {0}", fullName);
            Console.WriteLine("Your name is {0} {1} and your age is {2}", firstName, lastName, age);
            Console.WriteLine($"Your name is {firstName} {lastName} and your age is {age}");
        }

        static void EmptyString()
        {
            string emptyString = string.Empty;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //if(name != string.Empty)
            if(!name.Equals(emptyString))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine($"Invalid name input.");
            }
        }

        static void StringCompare()
        {
            string greeting = "Hello";
            char[] charArray = new char[] { 'H', 'e', 'l', 'l', 'o' }; 
            object objectString = new string(charArray);
            if (objectString == greeting)
            {
                Console.WriteLine("These are memory address location and literal value equals");
            } else
            {
                Console.WriteLine("These are memory and value different");
            }

            if(objectString.Equals(greeting))
            {
                Console.WriteLine("These are ref equal. Just value literal comparison. String and Object.");
            }
        }

        static void StringLoopIteration()
        {
            string message = "C# Programming";
            Console.WriteLine("Char at Pos 0: " + message[0]);  //C
            Console.WriteLine("Char at Pos 1: " + message[1]);  //#
            Console.WriteLine("Char at Pos 2: " + message[2]);  //Space
            Console.WriteLine("Char at Pos 3: " + message[3]);  //P

            //To stop guessing the length of the string
            for(int i = 0; i < message.Length; i++)
            {
                Console.Write($"{message[i]}");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            //Check if our string contains a specified character
            for (int i = 0; i < message.Length; i++)
            {
                if(message[i].Equals('i'))
                {
                    Console.WriteLine($"Found character {message[i]} at position {i}.");
                    break;
                }
            }
        }

        static void StringValidator()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
            {
                //If the string is null or it's value is empty.
                Console.WriteLine("Invalid name input.");
            }
            else
            {
                Console.WriteLine($"Your name is {name}");
            }
        }
    }
}
