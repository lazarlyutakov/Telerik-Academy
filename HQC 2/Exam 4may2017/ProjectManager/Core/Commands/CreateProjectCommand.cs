using Bytes2you.Validation;
using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Commands.Contracts;
using ProjectManager.Data;
using ProjectManager.Enumerations;
using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Core.Commands
{
    public class CreateProjectCommand : ICommand
    {
        public Database dataBase;
        public ModelsFactory factory;

        public CreateProjectCommand(Database database, ModelsFactory factory)
        {
            Guard.WhenArgument(database, "CreateProjectCommand Database").IsNull().Throw();
            Guard.WhenArgument(factory, "CreateProjectCommand ModelsFactory").IsNull().Throw();

            this.dataBase = database;
            this.factory = factory;
        }

        public string Execute(List<string> parameters)
        {
            if (parameters.Count != 4)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }
                
            if (parameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException("Some of the passed parameters are empty!");
            }
                
            if (dataBase.Projects.Any(x => x.Name == parameters[0]))
            {
                throw new UserValidationException("A project with that name already exists!");
            }

            var name = parameters[0];
            var startingDate = parameters[1];
            var endingDate = parameters[2];
            var state = (ProjectState)int.Parse(parameters[3]);
                
            var project = factory.CreateProject(name, startingDate, endingDate, state);
            dataBase.Projects.Add(project);

            return "Successfully created a new project!";
        }     
    }
}