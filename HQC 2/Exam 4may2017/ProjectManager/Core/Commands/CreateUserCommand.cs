using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using ProjectManager.Core.Commands.Contracts;
using ProjectManager.Data;
using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Core.Commands
{
    public class CreateUserCommand : ICommand
    {
        private readonly Validator validator = new Validator();

        public string Execute(List<string> parameters)
        {
            var dataBase = new Database();

            if (parameters.Count != 3)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }

            if (parameters.Any(x => x == string.Empty))
            {
                 throw new UserValidationException("Some of the passed parameters are empty!");
            }
            

            if (dataBase.Projects[int.Parse(parameters[0])].Users.Any() && 
                dataBase.Projects[int.Parse(parameters[0])].Users.Any(x => x.UserName == parameters[1]))
            {
                throw new UserValidationException("A user with that username already exists!");
            }

            var projectId = int.Parse(parameters[0]);
            var userName = parameters[1];
            var email = parameters[2];

            var user = new User(userName, email);
            validator.Validate(user);

            var projectToAddUserTo = dataBase.Projects[projectId];
            projectToAddUserTo.Users.Add(user);

            return "Successfully created a new user!";
        }
    }
}
