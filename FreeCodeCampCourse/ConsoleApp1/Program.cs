namespace CodeBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Code Blocks World!");
            OutOfScope();
            WithinScope();
            movingExample();
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
            {
                Console.WriteLine($"Inside the code block: {value}");
            }
            //value is within scope here.
            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
        }

        static void movingExample()
        {
            int anyVar = 5;
            if(anyVar > 0)
            {
                int anotherVar = 6;
                anyVar += anotherVar;
            }
            Console.WriteLine($"First int var = {anyVar}");
        }
    }
}