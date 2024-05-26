using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetRandomNumber();
            GetAnotherRandomNumber();
            Console.ReadLine();
        }
        static void GetRandomNumber()
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
        }

        static void GetAnotherRandomNumber()
        {
            Random random = new Random();
            int roll = random.Next();
            Console.WriteLine(roll);
        }
    }
}