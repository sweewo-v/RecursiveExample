using System;

namespace RecursiveExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            RecursiveHelper helper = new RecursiveHelper(200, -100, 100, writer);

            helper.Print(i => i < 0);

            Console.ReadLine();
        }
    }
}
