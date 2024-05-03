using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string name = GetUserName();
            int age = GetUserAge();
            string address = GetAddress();
            WelcomeMessage(name, age);
            StaticVsInstanceDemo();
            CreateAndPrintArray();
            Console.WriteLine();
            SomeConsoleInputWork();
            Console.WriteLine();
            int num1 = 5, num2 = 10;
            Add(num1, num2);
            Console.WriteLine(OptionalAdd(num1));
            Console.WriteLine(OptionalAdd(num1, num2));
            Console.WriteLine(OptionalAdd(num2));
            Console.WriteLine();
            PrintDetails(name, age, address);
            int result = 0;
            bool success = CallWithOutValue(out result);
            Console.WriteLine($"Success: {success}, Result: {result}");
            ShoppingList("Milk", "Sugar", "Tea");*/
            List<string> vehicleList = new List<string>()
            {
                "Car", "Bike", "Bicycle"
            };
            int indexMilk;
            FuncIndexOf("Milk", vehicleList, out indexMilk);
            int indexCar;
            FuncIndexOf("Car", vehicleList, out indexCar);
            int indexBicycle;
            FuncIndexOf("Bicycle", vehicleList, out indexBicycle);
            Console.WriteLine($"Index of Milk = {indexMilk}");
            Console.WriteLine($"Index of Car = {indexCar}");
            Console.WriteLine($"Index of Bicycle = {indexBicycle}");
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

        static string GetAddress()
        {
            return "123 FourFiveSix Street";
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

        static void Add(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine();
            int firstNum = ReadInt("Enter first number: ");
            int secondNum = ReadInt("Enter second number: ");
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
        }

        static int ReadInt(string message)
        {
            Console.Write(message);
            return (Convert.ToInt32(Console.ReadLine()));
        }

        static int OptionalAdd(int a, int b = 15)
        {
            return a + b;
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"My name is {name}. I am {age} years old. My address is {address}.");
        }

        static bool CallWithOutValue(out int result)
        {
            result = 5;
            return true;
        }

        static void ShoppingList(string item1, string item2, string item3)
        {
            List<string> shoppingList = new List<string>()
            { 
                item1, item2, item3
            };

            Console.WriteLine(shoppingList.IndexOf("Milk"));
            Console.WriteLine(shoppingList.IndexOf("Sugar"));
            Console.WriteLine(shoppingList.IndexOf("Tea"));
        }

        static bool FuncIndexOf(string item, List<string> defaultList, out int result)
        {
            result = -1;
            for (int i = 0; i < defaultList.Count; i++)
            {
                if (defaultList[i].ToLower().Equals(item.ToLower()))
                {
                    result = i;
                }
            }

            if(result == -1)
            {
                Console.WriteLine($"Item {item} not found in the list");
                return false;
            } else
            {
                return true;
            }
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
