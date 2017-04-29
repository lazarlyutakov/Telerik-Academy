using System;
using SchoolSystem.Contracts;

namespace SchoolSystem.Providers
{
    internal class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}