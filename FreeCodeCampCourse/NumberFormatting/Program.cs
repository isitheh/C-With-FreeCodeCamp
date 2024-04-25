using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FormatNumbers();
            FormatPrintValues();*/
            TryParse();
            Console.ReadLine();
        }

        static void FormatNumbers()
        {
            int number = 123456789;
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Currency: " + number.ToString("C"));
            Console.WriteLine("Decimal: " + number.ToString("D"));
            Console.WriteLine("Exponential: " + number.ToString("E"));
            Console.WriteLine("Fixed Point: " + number.ToString("F"));
            Console.WriteLine("General: " + number.ToString("G"));
            Console.WriteLine("Number: " + number.ToString("N"));
            Console.WriteLine("Percent: " + number.ToString("P"));
            Console.WriteLine("Hexadecimal: " + number.ToString("X"));
            Console.WriteLine();
        }
        
        static void FormatPrintValues()
        {
            double val = 1000D / 12.34D;
            Console.WriteLine("Value: " + val);
            //Round value up to 2 decimal places.
            Console.WriteLine(string.Format("{0:0.}", val));
            Console.WriteLine(string.Format("{0:0.#}", val));
            Console.WriteLine(string.Format("{0:0.00}", val));

            double money = -10D/3D;  //3.3333333333333335
            Console.WriteLine("Money: " + money);
            Console.WriteLine(money.ToString("C"), CultureInfo.CreateSpecificCulture("en-ZA"));
        }

        static void TryParse()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            bool success = int.TryParse(input, out number);
            //If successful, number will be assigned the value of the input.
            //If unsuccessful, number will be 0;
            if (success)
            {
                Console.WriteLine("Value: " + number);
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}
