using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReadUserData();
            SimpleIOSums();
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
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if(userAnswer == answer)
            {
                Console.WriteLine("Correct! Well Done!");
            } else
            {
                Console.WriteLine("That didnt go well at all.");
            }
        }
    }
}
