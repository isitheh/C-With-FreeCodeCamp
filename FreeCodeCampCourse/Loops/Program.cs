using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WorkingWithForLoops();
            WorkingWithWhileLoops();
            Console.ReadLine();
        }

        static void WorkingWithForLoops()
        {
            Console.Write("What do you want to say?");
            string message = Console.ReadLine();
            Console.Write("How many times to say {0}?", message);
            int loopCount = Convert.ToInt32(Console.ReadLine());
            if(loopCount <= 0)
            {
                Console.WriteLine("Enter a value above 0.");
                return;
            }

            else if(loopCount == 0)
            {
                Console.WriteLine("You are a minor. No alcohol for you.");
                return;
            }

            for(int i = 0; i < loopCount; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(message);
            }
            Console.WriteLine("Say {0} Evenly...", message);
            for(int i = 0; i <= loopCount; i+=2)
            {
                Console.Write(i + ": ");
                Console.WriteLine(message);
            }
            Console.WriteLine("Say {0} Oddly...", message);
            for(int i = 1; i <= loopCount; i+=2)
            {
                Console.Write(i + ": ");
                Console.WriteLine(message);
            }
            Console.WriteLine("Goodbye!");
        }

        static void WorkingWithWhileLoops()
        {
            Console.Write("What do you want to say?");
            string message = Console.ReadLine();
            Console.Write("How many times to say {0}?", message);
            int loopCount = Convert.ToInt32(Console.ReadLine());
            if (loopCount <= 0)
            {
                Console.WriteLine("Enter a value above 0.");
                return;
            }

            int i = 0;
            do
            {
                Console.Write(i + ": ");
                Console.WriteLine(message);
                i++;
            } while (i < loopCount);

            Console.WriteLine("Say {0} Evenly...", message);
            i = 0;
            while(i < loopCount)
            {
                Console.Write(i + ": ");
                Console.WriteLine(message);
                i += 2;
            }
            Console.WriteLine("Say {0} Oddly...", message);
            i = 1;
            while(i < loopCount)
            {
                Console.Write(i + ": ");
                Console.WriteLine(message);
                i += 2;
            }
        }
    }
}
