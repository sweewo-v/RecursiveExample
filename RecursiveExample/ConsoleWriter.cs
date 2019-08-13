using System;

namespace RecursiveExample
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string s)
        {
            Console.Write(s);
        }
    }
}
