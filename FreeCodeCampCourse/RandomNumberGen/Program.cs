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
            Console.ReadLine();
        }
        static void GetRandomNumber()
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}