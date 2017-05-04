using Bytes2you.Validation;
using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
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
        private readonly Validator validator = new Validator();

        private Database dataBase;

        public CreateProjectCommand(Database database, ModelsFactory factory)
        {
            Guard.WhenArgument(database, "CreateProjectCommand Database").IsNull().Throw();
            Guard.WhenArgument(factory, "CreateProjectCommand ModelsFactory").IsNull().Throw();

            this.dataBase = database;
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

            var startingDateSuccessful = Convert.ToDateTime(startingDate);
            var endingDateSuccessful = Convert.ToDateTime(endingDate);

            var project = new Project(name, startingDateSuccessful, endingDateSuccessful, state);
            validator.Validate(project);

            dataBase.Projects.Add(project);

            return "Successfully created a new project!";
        }     
    }
}