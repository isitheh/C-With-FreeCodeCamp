using Microsoft.SqlServer.Server;
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
            ArraySort();
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

        static void ArraySort()
        {
            int[] numbers = new int[]
            {
                15, 8, 10, 11, 3, 1, 5, 9, 2, 4, 25, 19, 6
            };

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num}");
            }
        }
    }
}
