using SchoolSystem.Core;
using SchoolSystem.Models;
using SchoolSystem.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace SchoolSystem
{
    public class Startup
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var parser = new CommandParser();

            var engine = new Engine(reader, writer, parser);
            engine.Start();
        }
    }
}