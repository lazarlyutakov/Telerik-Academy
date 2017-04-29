using SchoolSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Providers
{
    internal class CommandParser : IParser
    {
        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split(' ')[0];
            var commandTypeInfo = this.FindCommand(commandName);
            var command = Activator.CreateInstance(commandTypeInfo) as ICommand;

            return command;
        }

        public IList<string> ParseParameters(string fullCommand)
        {
            var splittedCommand = fullCommand.Split(' ').ToList();
            splittedCommand.RemoveAt(0);

            return splittedCommand;
        }

        private TypeInfo FindCommand(string commandName)
        {
            var currentAssembly = this.GetType().GetTypeInfo().Assembly;
            var commandTypeInfo = currentAssembly.DefinedTypes
                   .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                   .Where(type => type.Name.ToLower().Contains(commandName.ToLower()))
                   .SingleOrDefault();

            if (commandTypeInfo == null)
            {
                throw new ArgumentException("Command not found");
            }

            return commandTypeInfo;
        }
    }
}
