using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Commands.Contracts;
using ProjectManager.Data;
using ProjectManager.Models;
using System;

namespace ProjectManager.Core.Commands
{
    public class CommandsFactory : ICommandFactory
    {
        private Database dataBase;

        public CommandsFactory(Database dataBase)
        {
            this.dataBase = dataBase;
        }

        public ICommand CreateCommandFromString(string commandName)
        {
            var command = commandName.ToLower();

            switch (command)
            {
                case "createproject": return new CreateProjectCommand(this.dataBase);
                case "createtask": return new CreateTaskCommand(this.dataBase);
                case "listprojects": return new ListProjectsCommand(this.dataBase);
                default: throw new UserValidationException("The passed command is not valid!");
            }
        }      
    }
}