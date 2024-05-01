using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = GetUserName();
            int age = GetUserAge();
            WelcomeMessage(name, age);
            StaticVsInstanceDemo();
            CreateAndPrintArray();
            Console.WriteLine();
            SomeConsoleInputWork();
            Console.ReadLine();
        }

        static void WelcomeMessage(string name, int age)
        {
            Console.WriteLine($"Welcome Home {name}! I have heard you are {age} years old?");
        }

        static void StaticVsInstanceDemo()
        {
            DemoStaticVsInstance.StaticMethod();
            DemoStaticVsInstance demo = new DemoStaticVsInstance();
            demo.InstanceMethod();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[5]
            {
                0, 1, 2, 3, 4
            };


            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }   
        }

        static string GetUserName()
        {
            return "John Doe";
        }

        static int GetUserAge()
        {
            return 25;
        }

        static void SomeConsoleInputWork()
        {
            int[] numbers = new int[5];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = SomeConsoleOutputWork();
            }
            Console.WriteLine();
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }

        static int SomeConsoleOutputWork()
        {
            Console.Write("Enter number: ");
            return(Convert.ToInt32(Console.ReadLine()));
        }
    }

    class DemoStaticVsInstance
    {
        public static void StaticMethod()
        {
            Console.WriteLine("Called The Static Method");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("Called The Instance Method");
        }
    }
}
