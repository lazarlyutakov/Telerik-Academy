using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using ProjectManager.Core.Commands.Contracts;
using ProjectManager.Data;
using ProjectManager.Enumerations;
using ProjectManager.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManager.Core.Commands
{
    public class CreateTaskCommand : ICommand
    {
        private readonly Validator validator = new Validator();

        public string Execute(List<string> parameters)
        {
            var dataBase = new Database();

            if (parameters.Count != 4)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }               

            if (parameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException("Some of the passed parameters are empty!");
            }

            var projectId = int.Parse(parameters[0]);
            var userId = int.Parse(parameters[1]);
            var name = parameters[2];
            var state = (TaskState)int.Parse(parameters[3]);

            var projectOfOwner = dataBase.Projects[projectId];
            var owner = projectOfOwner.Users[userId];

            var task = new Task(name, owner, state);
            validator.Validate(task);

            return "Successfully created a new task!";
        }
    }
}