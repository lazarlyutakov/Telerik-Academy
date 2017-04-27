using GameFifteen.Contracts;
using System;

namespace GameFifteen.Models
{
    public class Logger : ILogger
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void Write(string message, int message2)
        {
            Console.Write(message, message2);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
