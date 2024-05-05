using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LearnAboutExceptions();
            Console.ReadLine();
        }

        static void LearnAboutExceptions()
        {
            bool success = false;
            while(!success)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Number = {num}");
                    success = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please only enter numbers below 2 billion.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
            
            Console.WriteLine("Goodbye...");
        }
    }
}
