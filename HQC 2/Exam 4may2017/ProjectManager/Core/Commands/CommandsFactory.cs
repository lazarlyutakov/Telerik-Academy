using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Commands.Contracts;
using ProjectManager.Data;
using ProjectManager.Models;
using System;

namespace ProjectManager.Core.Commands
{
    public class CommandsFactory
    {
        private Database dataBase;
        private ModelsFactory factory;

        public CommandsFactory(Database dataBase, ModelsFactory factory)
        {
            this.dataBase = dataBase;
            this.factory = factory;
        }

        public ICommand CreateCommandFromString(string commandName)
        {
            var command = BuildCommand(commandName);

            switch (command)
            {
                case "createproject": return new CreateProjectCommand(dataBase, factory);
                case "createtask": return new CreateTaskCommand();
                case "listprojects": return new ListProjectsCommand(dataBase);
                default: throw new UserValidationException("The passed command is not valid!");
            }
        }      

        private string BuildCommand(string parameters)
        {
            var command = string.Empty;

            //var end = DateTime.Now + TimeSpan.FromSeconds(1);
            //while (DateTime.Now < end);

            for (int i = 0; i < parameters.Length; i++)
            {
                command += parameters[i].ToString().ToLower();
            }
            
            return command;
        }      
    }
}