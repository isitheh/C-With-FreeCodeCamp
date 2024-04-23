using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeralBasedDataTypes.NumeralsDataInfo();
            TextBasedDataTypes.TextDataInfo();
            Console.ReadLine();
        }
    }

    class NumeralBasedDataTypes
    {
        public static void NumeralsDataInfo()
        {
            //Dealing with integers
            int age = 35;
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Min Integer: " + int.MinValue);
            Console.WriteLine("Max Integer: " + int.MaxValue);

            //Dealing with short integers
            short val = 10;
            Console.WriteLine("Short number: " + val);
            Console.WriteLine("Min Short Integer: " + short.MinValue);
            Console.WriteLine("Max Short Integer: " + short.MaxValue);

            //Dealing with long integers
            long bigNumber = 900000000L;
            Console.WriteLine("Big Number: " + bigNumber);
            Console.WriteLine("Min Long Integer: " + long.MinValue);
            Console.WriteLine("Max Long Integer: " + long.MaxValue);

            //Dealing with doubles
            double negative = -55.2D;
            Console.WriteLine("Double Number: " + negative);
            Console.WriteLine("Min Double Number: " + double.MinValue);
            Console.WriteLine("Max Double Number: " + double.MaxValue);

            //Dealing with floats
            float prescision = -5.000002f;
            Console.WriteLine("Float Number: " + prescision);
            Console.WriteLine("Min Float Number: " + float.MinValue);
            Console.WriteLine("Max Float Number: " + float.MaxValue);

            //Dealing with decimals
            decimal money = 14.79m;
            Console.WriteLine("Decimal Number: " + money);
            Console.WriteLine("Min Decimal Number: " + decimal.MinValue);
            Console.WriteLine("Max Decimal Number: " + decimal.MaxValue);
        }
    }

    class TextBasedDataTypes
    {
        public static void TextDataInfo()
        {
            string firstName = "Sithembiso";
            char firstLetterOfSurname = 'G';
            Console.WriteLine("My first name is: " + firstName);
            Console.WriteLine("First letter of my last name is: " + firstLetterOfSurname);
        }

        public static void ConvertStringToNum()
        {
            string number = "100";
            int convertedNumber = int.Parse(number);
            Console.WriteLine("Converted Number: " + convertedNumber);

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine("Integer age = ", age);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine("Big Number = ", bigNumber);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine("Double Negative: ", negative);

            string textPrescision = "-5.000002";
            float prescision = Convert.ToSingle(textPrescision);
            Console.WriteLine("Float Prescision: ", prescision);

            string textMoney = "14.79";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine("Decimal Money: ", money);
        }
    }

    class BooleanDataTypes
    {
        public static void BooleanDataInfo()
        {
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine("Is True: " + isTrue);
            Console.WriteLine("Is False: " + isFalse);
        }
    }
}
