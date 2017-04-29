using System;
using SchoolSystem.Contracts;

namespace SchoolSystem.Providers
{
    public class ConsoleReaderProvider : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
