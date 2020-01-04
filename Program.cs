using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World!");
            }

            else
            {
                for (int count = 0; count < args.Length; count++)
                {
                    Console.WriteLine("Hello " + args[count] + "!");
                }
            }
        }
    }
}
