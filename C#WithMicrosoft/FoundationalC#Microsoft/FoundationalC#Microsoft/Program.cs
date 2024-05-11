using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationalC_Microsoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Below - Hello World is a literal string
            Console.WriteLine("Hello World!");
            PrintLiteralValues();
            usingVarKeyword();
            Exercises.ExercisesMethodOne();
            Exercises.ExercisesMethodTwo();
            CharEscapeSequences();
            VerbatimStringLiterals();
            UnicodeEscapeCharacters();
            Exercises.OrderOfOperations();
            StringConcatenation();
            StringInterpolation();
            WorkingWithTypes();
            IncrementDecrement();
            PrePostIncrementDecrement();
            Exercises.FahrenheitToCelcius();
            Exercises.CelciusToFahrenheit();
            Console.ReadLine();
        }

        static void PrintLiteralValues()
        {
            /*
             * Create a char literal by surrounding one alphanumeric character in single quotes. 
             * The term char is short for character. In C#, this data type is officially named "char", 
             * but frequently referred to as a "character". When you use single quotation marks, 
             * the C# compiler expects a single character.
             */
            Console.WriteLine('b');

            /*
             * If you want to display a numeric whole number (no fractions) value in the output console, 
             * you can use an int literal.
             */
            Console.WriteLine(123);

            /*
             * A floating-point number is a number that contains a decimal, for example 3.14159. 
             * C# supports three data types to represent decimal numbers: float, double, and decimal. 
             * Each type supports varying degrees of precision.
             * float         ~6-9 digits (For a float literal, append the letter F after the number.)
             * double        ~15-17 digits (Eenter a decimal number, compiler defaults to a double literal)
             * decimal        28-29 digits
             */
            Console.WriteLine(0.25F);
            Console.WriteLine(0.50f);
            Console.WriteLine(2.625);
            Console.WriteLine(12.39816m);
            Console.WriteLine(24.398160M);

            /*
             * If you wanted to print a value representing either true or false, you could use a bool literal.
             * The term bool is short for Boolean. In C#, they're officially referred to as "bool", but often 
             * developers use the term "Boolean".
             */
            Console.WriteLine(true);
            Console.WriteLine(false);

            /* A variable is a container for storing a type of value. Variables are important because their 
             * values can change, or vary, throughout the execution of a program. Variables can be assigned, 
             * read, and changed. You use variables to store values that you intend to use in your code.
             */
            string firstName; //From now on, this variable can only hold string values.
            firstName = "Bob";
            Console.WriteLine("1.0 ======= First Name is: " + firstName);
            //Re-assign a variable to a new value
            firstName = "Abishola";
            Console.WriteLine("2.0 ======= First Name is: " + firstName);
            firstName = "Kemi";
            Console.WriteLine("3.0 ======= First Name is: " + firstName);
            //Initialization - Declaring and setting the value in one line
            string lastName = "Jobe";
            Console.WriteLine("4.0 ======= Last Name is: " + lastName);
        }

        static void usingVarKeyword()
        {
            /*
             * Create a string variable using the var keyword instead of the string keyword.
             * The var keyword tells the C# compiler that the data type is implied by the assigned value. 
             * Below, the C# compiler understands the intent and treats every instance of message as 
             * an instance of type string. The variable created cannot be assigned to any other type.
             */
            var message = "Hello World!";
            Console.WriteLine(message);
        }

        static void CharEscapeSequences()
        {
            //Add a new line to a string literal using character escape sequence.
            Console.WriteLine("Hello\nWorld!");
            //Add a tab between the words "Hello" and "World!"
            Console.WriteLine("Hello\tWorld!");
            //Display a file path using backslashes as seperators.
            Console.WriteLine("c:\\source\\repos");
            //Insert a double-quotation mark inside a string literal.
            Console.WriteLine("Hello \"World\"!\n");
        }

        static void VerbatimStringLiterals()
        {
            /*
             * A verbatim string literal will keep all whitespace and characters without the need to
             * escape the backslash. To create a verbatim string, use the @ directive before the 
             * literal string.
             */
            Console.WriteLine(@"   c:\source\repos 
            (this is where your code goes)");
        }

        static void UnicodeEscapeCharacters()
        {
            /*
             * You can also add encoded characters in literal strings using the \u escape sequence, 
             * then a four-character code representing some character in Unicode (UTF-16).
             * Printing Kon'nichiwa World
             */
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            Console.WriteLine("\n");
        }

        static void StringConcatenation()
        {
            /*
             * Combine strings using string concatenation
             * String concatenation is "programmer speak" for simply combining 
             * two or more string values into a new string value.
             * To concatenate two strings together, you use the string concatenation 
             * operator, which is the plus symbol +.
             */
            string firstName = "Bob";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + firstName + "!");
        }

        static void StringInterpolation()
        {
            /*
             * String interpolation is used in situations where you need to combine 
             * many literal strings and variables into a single formatted message.
             */
            string firstName = "Bob";
            string greeting = "Hello";
            Console.WriteLine($"{greeting} {firstName}!");

            int version = 11;
            string updateText = "Update to Windows";
            Console.WriteLine($"{updateText} {version}");

            string projectName = "First Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
        }

        static void WorkingWithTypes()
        {
            int firstNumber = 12;
            int secondNumber = 7;
            string firstName = "Abishola";
            string secondName = "Bob";
            Console.WriteLine("Sum: " + (firstNumber + secondNumber));
            Console.WriteLine(firstName + " sold " + firstNumber + " socks today.");
            Console.WriteLine(secondName + " plans to sell " + secondNumber + " socks tomorrow.");
        }

        static void MathProblems()
        {
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            float quotient = 7.0f / 5;
            decimal decimalQuotient = 7.0m / 5;
            int remainder = 7 % 5;
            int firstNumber = 7;
            int secondNumber = 5;
            decimal decimalQuotientCast = (decimal)firstNumber / (decimal)secondNumber;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine($"Decimal Quotient: {decimalQuotient}");
            Console.WriteLine($"Decimal Quotient using cast: {decimalQuotientCast}");
        }

        static void IncrementDecrement()
        {
            int value = 1;
            Console.WriteLine($"Original value = {value}");
            value++;
            Console.WriteLine($"Incremented value = {value}");
            value = value + 1;
            Console.WriteLine($"Incremented value = {value}");
            value += 1;
            Console.WriteLine($"Incremented value = {value}");
            value--;
            Console.WriteLine($"Decremented value = {value}");
            value = value - 1;
            Console.WriteLine($"Decremented value = {value}");
            value -= 1;
            Console.WriteLine($"Decremented value = {value}");
            Console.WriteLine();
        }

        static void PrePostIncrementDecrement()
        {
            int value = 1;
            Console.WriteLine($"Original value = {value}");
            Console.WriteLine($"Post-incremented value = {value++}");
            Console.WriteLine($"After post-increment value = {value}");
            Console.WriteLine($"Pre-incremented value = {++value}");
            Console.WriteLine($"After pre-increment value = {value}");
            Console.WriteLine($"Post-decremented value = {value--}");
            Console.WriteLine($"After post-decrement value = {value}");
            Console.WriteLine($"Pre-decremented value = {--value}");
            Console.WriteLine($"After pre-decrement value = {value}");
            Console.WriteLine();
        }
    }
}
