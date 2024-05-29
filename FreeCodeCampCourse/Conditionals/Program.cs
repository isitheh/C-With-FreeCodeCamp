using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Conditionals World!");
            CoinFlip();
            UserPermLevel();
            Console.ReadLine();
        }

        static void CoinFlip()
        {
            Random coin = new Random();
            int flip = coin.Next(0,2);
            Console.WriteLine((flip == 0) ? "Heads" : "Tails");
        }

        static void UserPermLevel()
        {
            string permission = "Admin|Manager";
            int level = 55;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else if(level <= 55)
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            } 
            else if (permission.Contains("Manager"))
            {
                if(level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                } 
                else if(level < 20)
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else 
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}