using System;
using SchoolSystem.Contracts;

namespace SchoolSystem.Providers
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
