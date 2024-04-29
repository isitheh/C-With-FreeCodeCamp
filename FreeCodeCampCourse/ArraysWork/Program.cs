﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JustArrays();
            TriangleArrays();
            ArraySortReverse();
            ArrayIndexOf();
            Console.ReadLine();
        }

        static void JustArrays()
        {
            int[] mArray = new int[5]; // 5 elements array
            for (int i = 0; i < mArray.Length; i++)
            {
                Console.Write("Enter a value: ");
                mArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < mArray.Length; i++)
            {
                Console.Write($"{mArray[i]} ");
            }

            Console.WriteLine();

            foreach (int num in mArray)
            {
                Console.Write($"{num} ");
            }
        }

        static void TriangleArrays()
        {
            int angleCount = 3;
            int sum = 0;
            for (int i = 0; i < angleCount; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum == 180 ? "Valid Triangle" : "Invalid Tiangle");
        }

        static void ArraySortReverse()
        {
            int[] numbers = new int[]
            {
                15, 8, 10, 11, 3, 1, 5, 9, 2, 4, 25, 19, 6
            };

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            Array.Reverse(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
            //Clears the array to default values for the data type (0 for integers)
            Array.Clear(numbers, 0, numbers.Length);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            string[] strings = new string[]
            {
                "Hello", "World", "of", "C#", "Programming", "Language"
            };

            foreach (string str in strings)
            {
                Console.Write($"{str} ");
            }

            Console.WriteLine();
            //Sorts the array in alphabetical order
            Array.Sort(strings);

            foreach (string str in strings)
            {
                Console.Write($"{str} ");
            }

            Console.WriteLine();

            //Reverses the array
            Array.Reverse(strings);

            foreach (string str in strings)
            {
                Console.Write($"{str} ");
            }

            Console.WriteLine();

            //Clears the array to default values for the data type (null for strings)
            Array.Clear(strings, 0, strings.Length);
            foreach (string str in strings)
            {
                Console.Write($"{str} ");
            }

            Console.WriteLine();
        }

        static void ArrayIndexOf()
        {
            int[] numbers = new int[]
            {
                 8, 7, 3, 1, 5, 9, 2, 0, 4, 6
            };

            Console.WriteLine("Position: ");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1} ");
            }

            Console.WriteLine();

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(numbers, search);

            if (index != -1)
            {
                Console.WriteLine($"Number {search} found at Position {index + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} not found");
            }

            Console.WriteLine("Search the first half of the array");
            Console.WriteLine("Enter a number to search: ");
            search = Convert.ToInt32(Console.ReadLine());
            index = Array.IndexOf(numbers, search, 0, numbers.Length / 2);

            if (index != -1)
            {
                Console.WriteLine($"Number {search} found at Position {index + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} not found");
            }

            Console.WriteLine("Search the second half of the array");
            Console.WriteLine("Enter a number to search: ");
            search = Convert.ToInt32(Console.ReadLine());
            index = Array.IndexOf(numbers, search, numbers.Length / 2, numbers.Length / 2);
            if (index != -1)
            {
                Console.WriteLine($"Number {search} found at Position {index + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} not found");
            }
        }
    }
}
