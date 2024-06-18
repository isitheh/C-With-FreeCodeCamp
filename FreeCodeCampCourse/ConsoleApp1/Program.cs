namespace CodeBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Code Blocks World!");
            OutOfScope();
            WithinScope();
            MovingExample();
            CorrectionsCodeBlock();
            LearnSwitch();
            UsingSwitch();
            Console.ReadLine();
        }

        static void OutOfScope()
        {
            bool flag = true;
            if (flag)
            {
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}");
            }
            //value is OutOfMemoryException of scope here.
            //Console.WriteLine($"Outside the code block: {value}");
        }

        static void WithinScope()
        {
            bool flag = true;
            int value = 0;

            if (flag)
                Console.WriteLine($"Inside the code block: {value}");

            //value is within scope here.
            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
        }

        static void MovingExample()
        {
            int anyVar = 5;
            if(anyVar > 0)
            {
                int anotherVar = 6;
                anyVar += anotherVar;
            }
            Console.WriteLine($"First int var = {anyVar}");
        }

        static void CorrectionsCodeBlock()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;
            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                    found = true;
            }
            if (found) 
                Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");
        }

        static void LearnSwitch()
        {
            string fruit;
            Console.Write("Enter a fruit: ");
            fruit = Console.ReadLine().ToLower();
            switch (fruit)
            {
                case "apple":
                    Console.WriteLine($"{fruit} is a very green and delicious!");
                    break;
                case "orange":
                    Console.WriteLine($"{fruit} is orange and delicious!");
                    break;
                case "pineapple":
                    Console.WriteLine($"{fruit} is kinda yellow and delicious!");
                    break;
                case "tomato":
                    Console.WriteLine($"{fruit} is red and delicious!");
                    break;
                case "banana":
                    Console.WriteLine($"{fruit} is also yellow and so delicious!");
                    break;
                case "cherry":
                    Console.WriteLine($"{fruit} is red and kinda nice!");
                    break;
                default:
                    Console.WriteLine("This fruit is not a recognised fruit. Maybe it is a vegie?");
                    break;
            }
        }

        static void UsingSwitch()
        {
            int employeeLevel = 400;
            string employeeName = "Jane Doe";
            string title = "";
            switch(employeeLevel)
            {
                case 100:   //Fall Through
                case 150:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior  Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior  Manager";
                    break;
                default:
                    Console.WriteLine("There is no employee at this level.");
                    break;
            }

            Console.WriteLine($"{employeeName} : {title}");
        }
    }
}