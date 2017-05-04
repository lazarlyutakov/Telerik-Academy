using SchoolSystem.Core.Contracts;
using System;

namespace SchoolSystem.Core.Providers
{
    public class Reader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
