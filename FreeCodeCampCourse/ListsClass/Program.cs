using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JustLists();
            Console.ReadLine();
        }

        static void JustLists()
        {
            List<int> mArray = new List<int>()
            {
                5, 8, 10, 11, 3, 1, 5, 9, 2, 4, 25, 19, 6
            };

            Console.Write("Original: ");
            for (int i = 0; i < mArray.Count; i++)
            {
                Console.Write($"{mArray[i]} ");
            }

            Console.WriteLine();
            mArray.Sort();
            Console.Write("Sorted: ");

            foreach (int num in mArray)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
