using System;
using ProjectManager;
using ProjectManager.Common;
using ProjectManager.Core.Commands;
using ProjectManager.Data;
using ProjectManager.Models;
using 


namespace ProjectManager
{
    public class Startup
    {
        public static void Main()
        {
            var engine = new Engine(new FileLogger(), new CommandProcessor (new CommandsFactory(new Database(),new ModelsFactory())));

            var provider = new ProjectManager.Core.Providers.EngineProvider(engine);
            provider.Initialize();
        }
    }
}
