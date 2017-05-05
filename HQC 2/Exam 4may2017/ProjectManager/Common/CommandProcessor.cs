using Bytes2you.Validation;
using ProjectManager.Core.Commands;
using ProjectManager.Core.Commands.Contracts;
using System;
using System.Linq;

namespace ProjectManager.Common
{
    public class CommandProcessor
    {
        private CommandsFactory factory;

        public CommandProcessor(CommandsFactory factory)
        {
            this.factory = factory;
        }

        public ICommand Process(string commandInput)
        {
            if (string.IsNullOrWhiteSpace(commandInput))
            {
                throw new Exceptions.UserValidationException("No command has been provided!");
            }

            var command = this.factory.CreateCommandFromString(commandInput.Split(' ')[0]);

            return command;
        }
    }
}
