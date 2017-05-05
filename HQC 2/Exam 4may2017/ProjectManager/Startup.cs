using System;
using ProjectManager.Common;
using ProjectManager.Core.Commands;
using ProjectManager.Core.Providers;
using ProjectManager.Data;

namespace ProjectManager
{
    public class Startup
    {
        public static void Main()
        {
            var fileLogger = new FileLogger();
            var dataBase = new Database();
            var commandFactory = new CommandsFactory(dataBase);
            var commandProcessor = new CommandProcessor(commandFactory);

            var engine = new Engine(fileLogger, commandProcessor);

            var provider = new EngineProvider(engine);
            provider.Initialize();
        }
    }
}