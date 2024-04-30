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
            //JustLists();
            //JustDictionaries();
            SubjectTeacherDictionary();
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

        static void JustDictionaries()
        {
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                //Key, Value
                { 1, "John" },
                { 2, "Jane" },
                { 3, "Jack" },
                { 4, "Jill" }
            };

            for(int i = 0; i < names.Count;i++)
            {
                KeyValuePair<int, string> name = names.ElementAt(i);
                Console.WriteLine($"{name.Key } - {name.Value}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string> name in names)
            {
                Console.WriteLine($"{name.Key } - {name.Value}");
            }
        }

        static void SubjectTeacherDictionary()
        {
            Dictionary<string, string> subjectTeacher = new Dictionary<string, string>()
            {
                { "Math", "Mr. Gama" },
                { "Science", "Mrs. Sithole" },
                { "History", "Miss. Myende" },
                { "English", "Ms. Davis" }
            };  

            if(subjectTeacher.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine($"The teacher for Math is {teacher}");
            }
            else
            {
                Console.WriteLine("Teacher not found");
            }

            foreach (KeyValuePair<string, string> subject in subjectTeacher)
            {
                Console.WriteLine($"{subject.Key} - {subject.Value}");
            }

            Console.WriteLine();

            if (subjectTeacher.TryGetValue("English", out string enTeacher))
            {
                Console.WriteLine($"The teacher for English is {enTeacher}");
                subjectTeacher["English"] = "Miss Ntuli";
            }
            else
            {
                Console.WriteLine("Teacher not found");
            }

            foreach (KeyValuePair<string, string> subject in subjectTeacher)
            {
                Console.WriteLine($"{subject.Key} - {subject.Value}");
            }

            Console.WriteLine();

            if(subjectTeacher.ContainsKey("Math"))
            {
                subjectTeacher.Remove("Math");
            }

            foreach (KeyValuePair<string, string> subject in subjectTeacher)
            {
                Console.WriteLine($"{subject.Key} - {subject.Value}");
            }
        }
    }
}
