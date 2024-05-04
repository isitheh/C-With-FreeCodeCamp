using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ReturnUsingOut();
            PassByRef();*/
            HomeAffairs();
            Console.ReadLine();
        }

        static void ReturnUsingOut()
        {
            int result;
            bool success = Assign(out result);
            Console.WriteLine($"Success: {success}, Result: {result}");
        }

        static bool Assign(out int result)
        {
            result = 5;
            return true;
        }

        static void PassByRef()
        {
            int num = 10;
            Console.WriteLine($"Before: {num}");
            Increment(ref num);
            Console.WriteLine($"After: {num}");
        }

        static void Increment(ref int num)
        {
            num++;
        }

        static void HomeAffairs()
        {
            string name = "John";
            Console.Write("Enter your new name:");
            string newName = Console.ReadLine();
            Console.WriteLine($"Your old name is {name}");
            if(ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}");
            } else
            {
                Console.WriteLine($"You new name is not valid.");
                HomeAffairs();
            }
        }

        static bool ChangeName(ref string name, string newName)
        {
            if(!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }
    }
}
