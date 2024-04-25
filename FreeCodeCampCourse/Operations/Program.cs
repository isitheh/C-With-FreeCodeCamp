using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatingOn();
            VarKeyWord();
            Constants();
            ConditionalOperators();
            TernaryOperator();
            Console.ReadLine();
        }

        static void OperatingOn()
        {
            int age = 35;
            Console.WriteLine("Original age: " + age);
            age++;
            Console.WriteLine("Incremented age: " + age);
            age--;
            Console.WriteLine("Decremented age: " + age);
            age += 5;
            Console.WriteLine("Added 5 to age: " + age);
            age -= 5;
            Console.WriteLine("Subtracted 5 from age: " + age);
            age *= 5;
            Console.WriteLine("Multiplied age by 5: " + age);
            age /= 5;
            Console.WriteLine("Divided age by 5: " + age);
            //To get the remainder, you can use the modulus operator
            age = 10;
            int remainder = age % 3;
            Console.WriteLine("Remainder of 10 divided by 3: " + remainder);
            age -= remainder;
            Console.WriteLine("Subtracting remainder from age: " + age);
            //For division, the result is always an integer, unless you make the value type a double or float
            double result = 10 / 3;
            Console.WriteLine("Result of 10 divided by 3: " + result);
            //To get the actual result, you can cast the value to a double
            result = (double)10 / 3;
            Console.WriteLine("Casted result of 10 divided by 3: " + result);
        }

        static void VarKeyWord()
        {
            //The var keyword is used to declare a variable without specifying the type
            var age = 35;
            Console.WriteLine("Age: " + age);
            var bigNumber = 900000000L;
            Console.WriteLine("Big Number: " + bigNumber);
            var negative = -55.2D;
            Console.WriteLine("Double Number: " + negative);
            var prescision = -5.000002f;
            Console.WriteLine("Float Number: " + prescision);
            var money = 14.79m;
            Console.WriteLine("Decimal Number: " + money);
            var name = "John Doe";
            Console.WriteLine("Name: " + name);
            var isTrue = true;      
            Console.WriteLine("Is True: " + isTrue);
            var mChar = 'A';
            Console.WriteLine("Character: " + mChar);
        }

        static void Constants()
        {
            //Constants are variables that cannot be changed
            const int vat = 15;
            Console.WriteLine("VAT: " + vat);
            //vat = 36; //This will throw an error
            int balance = 1000;
            Console.WriteLine("The VAT amounts to: " + (balance * (vat / 100D)));
            Console.WriteLine("Price before VAT: " + (balance - (balance * (vat/100D))));
        } 
        
        static void ConditionalOperators()
        {
            int age;
            do
            {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age < 0)
                {
                    Console.WriteLine("Age Invalid!");
                }
            } while (age < 0);
            Console.WriteLine("Age Valid!");
        }
        
        static void TernaryOperator()
        {
            int age;
            do
            {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                string message = age < 0 ? "Age Invalid!" : "Age Valid!";
                Console.WriteLine(message);
            } while (age < 0);
        }
    }
}
