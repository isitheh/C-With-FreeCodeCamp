using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationalC_Microsoft
{
    internal class Exercises
    {
        public static void ExercisesMethodOne()
        {
            /*
             * In this challenge, you'll write code that will combine literal and variable 
             * values into a single message. combine the variables with literal strings 
             * passed into a series of Console.Write() commands to form a complete message.
             */
            string personName = "Bob";
            int numMessages = 3;
            float temperatures = 34.4f;

            Console.Write("Hello, ");
            Console.Write(personName);
            Console.Write("! You have ");
            Console.Write(numMessages);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperatures);
            Console.Write(" celcius.");
            Console.WriteLine("\n");
        }

        public static void ExercisesMethodTwo()
        {
            //Generating Hard Coded Invoices For a Company
            Console.WriteLine("Invoice for Customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 12345\tPaid");
            Console.WriteLine("Invoice: 12346\tOustanding");
            Console.WriteLine("Invoice Total: 246810.56");
            Console.WriteLine("\n");
            Console.WriteLine("Message: Thank you for your business!");
            Console.WriteLine("Output Directory:");
            Console.Write(@"c:\invoices");
            Console.WriteLine("\n");
        }

        public static void OrderOfOperations()
        {
            int value1 = 3 + 4 * 5;     //23 - Start with multiplication
            int value2 = (3 + 4) * 5;   //35 - Start with addition in parentheses
            Console.WriteLine($"Value 1 = {value1}");
            Console.WriteLine($"Value 2 = {value2}");
        }

        public static void FahrenheitToCelcius()
        {
            decimal fahrenheit = 94m;
            int FarToCelc_Constant = 32;
            decimal celcius = (fahrenheit - FarToCelc_Constant) * (5 / 9m);
            Console.WriteLine($"The temperature is {String.Format("{0:0.00}", celcius)} Celcius.");
        }

        public static void CelciusToFahrenheit()
        {
            decimal celcius = 34.44m;
            int FarToCelc_Constant = 32;
            decimal fahrenheit = (celcius * (9m / 5)) + FarToCelc_Constant;
            Console.WriteLine($"The temperature is {String.Format("{0:0.00}", fahrenheit)} fahrenheit.");
        }
    }
}
