using ProjectManager.Common.Exceptions;
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
        public string Execute(List<string> parameters)
        {
            var dataBase = new Database();

            var factory = new ModelsFactory();

            if (parameters.Count != 3)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }

            if (parameters.Any(x => x == string.Empty))
            {
                 throw new UserValidationException("Some of the passed parameters are empty!");
            }
            

            if (dataBase.Projects[int.Parse(parameters[0])].Users.Any() && 
                dataBase.Projects[int.Parse(parameters[0])].Users.Any(x => x.UN == parameters[1]))
            {
                throw new UserValidationException("A user with that username already exists!");
            }

            dataBase.Projects[int.Parse(parameters[0])].Users.Add(factory.CreateUser(parameters[1], parameters[2]));

            return "Successfully created a new user!";
        }
    }
}
