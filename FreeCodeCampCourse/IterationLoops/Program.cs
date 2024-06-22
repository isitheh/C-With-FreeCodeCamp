using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Iteration Loops World");
            SetOfForLoops();
            FizzBuzzAgain();
            Console.ReadKey();
        }

        static void SetOfForLoops()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                if(i == 5)
                {
                    break;
                }
            }

            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }

            string[] names = { "Alex", "Eddie", "David", "Michael" };
            Console.WriteLine("Print names forwards:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Print names backwards:");
            for (int i = (names.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(names[i]);
                if (names[i] == "David") names[i] = "Sammy";
            }
            Console.WriteLine("Print names with David replaced by Sammy:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void FizzBuzzAgain()
        {
            Console.WriteLine("Do a FizzBuzz! WhoHoo!");
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
