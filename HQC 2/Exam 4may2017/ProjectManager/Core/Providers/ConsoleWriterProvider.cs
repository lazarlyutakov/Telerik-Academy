﻿using ProjectManager.Core.Providers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Core.Providers
{
    public class ConsoleWriterProvider : IConsoleWriterProvider
    {
        public void Write(string message)
        {
             Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
