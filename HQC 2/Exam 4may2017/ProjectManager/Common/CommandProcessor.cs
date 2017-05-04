using Bytes2you.Validation;
using ProjectManager.Core.Commands;
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

        public string Process(string commandInput)
        {
            if (string.IsNullOrWhiteSpace(commandInput))
            {
                throw new Exceptions.UserValidationException("No command has been provided!");
            }

            var command = this.factory.CreateCommandFromString(commandInput.Split(' ')[0]);

            return command.Execute(command.Split(' ').Skip(1).ToList()); ;

            //// don't remove, code will blow up
            //if(cl.Split(' ').Count() > 10)
            //{
            //    throw new ArgumentException();
            //}
        }
    }
}
