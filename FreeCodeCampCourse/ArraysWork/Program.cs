using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArraysWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*JustArrays();
            TriangleArrays();
            ArraySortReverse();
            ArrayIndexOf();
            DealInArraysOne();
            DealInArraysTwo();
            AraysIterator();*/
            PupilAssignmentGrading();
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

        static void DealInArraysOne()
        {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            //fraudulentOrderIDs[3] = "D000"; Index out of bounds as array is zero based.

            //Print out the fraudulent IDs
            Console.WriteLine($"First Element: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second Element: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third Element: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First Element: {fraudulentOrderIDs[0]}");
        }

        static void DealInArraysTwo()
        {
            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            Console.WriteLine($"First Element: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second Element: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third Element: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First Element: {fraudulentOrderIDs[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        }

        static void AraysIterator()
        {
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach(int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have = {sum} items, in the inventory.");
        }

        /*
         * Use arrays to store student names and the scores of graded assignments.
         * Use foreach statements to iterate through array values. 
         * Each student's final grade will be calculated inside a foreach code block. 
         * Use an if statement to assign a final letter grade. The completed application 
         * will output student grades using the teacher's score report specification.
         */
        static void PupilAssignmentGrading()
        {
            string[] pupilNames = { "Sophia", "Andrew", "Emma", "Logan" };
            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
            decimal[] pupilMarks = new decimal[5];

            int sophiaSum = 0;
            foreach (int item in sophiaScores) 
            {
                sophiaSum += item;
            }
            pupilMarks[0] = sophiaSum/sophiaScores.Length;

            int AndrewSum = 0;
            foreach (int item in andrewScores)
            {
                AndrewSum += item;
            }
            pupilMarks[1] = AndrewSum/andrewScores.Length;

            int EmmaSum = 0;
            foreach (int item in andrewScores)
            {
                EmmaSum += item;
            }
            pupilMarks[2] = EmmaSum/emmaScores.Length;

            int LoganSum = 0;
            foreach (int item in loganScores)
            {
                LoganSum += item;
            }
            pupilMarks[3] = LoganSum / loganScores.Length;

            Console.WriteLine("Student\tGrade\tSymbol");
            for(int i = 0; i < pupilNames.Length; i++)
            {
                Console.WriteLine($"{pupilNames[i]}\t{pupilMarks[i]}\t{CalculateSumbol(pupilMarks[i])}");
            }
        }

        static string CalculateSumbol(decimal pupilMark)
        {
            if(pupilMark > 0 && pupilMark < 60)
            {
                return "F";
            }
            else if(pupilMark > 59 &&  pupilMark < 63)
            {
                return "D-";
            }
            else if(pupilMark > 62 && pupilMark < 67)
            {
                return "D";
            }
            else if (pupilMark > 66 && pupilMark < 70)
            {
                return "D+";
            }
            else if (pupilMark > 69 && pupilMark < 73)
            {
                return "C-";
            }
            else if (pupilMark > 72 && pupilMark < 77)
            {
                return "C";
            }
            else if (pupilMark > 76 && pupilMark < 80)
            {
                return "C+";
            }
            else if (pupilMark > 79 && pupilMark < 83)
            {
                return "B-";
            }
            else if (pupilMark > 82 && pupilMark < 87)
            {
                return "B";
            }
            else if (pupilMark > 86 && pupilMark < 90)
            {
                return "B+";
            }
            else if (pupilMark > 89 && pupilMark < 93)
            {
                return "A-";
            }
            else if (pupilMark > 92 && pupilMark < 97)
            {
                return "A";
            }
            else if (pupilMark > 96 && pupilMark < 100)
            {
                return "A+";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
