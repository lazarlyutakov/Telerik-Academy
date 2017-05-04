using Bytes2you.Validation;
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
    public class CreateProjectCommand : ICommand
    {
        public Database dataBase;
        public ModelsFactory zavod;

        public string Execute(List<string> prms)
        {
            if (prms.Count != 4) throw new UserValidationException("Invalid command parameters count!");
            if (prms.Any(x => x == string.Empty)) throw new UserValidationException("Some of the passed parameters are empty!");
            if (dataBase.Projects.Any(x => x.Name == prms[0])) throw new UserValidationException("A project with that name already exists!");

            var project = zavod.CreateProject(prms[0], prms[1], prms[2], prms[3]);
            dataBase.Projects.Add(project);

            return "Successfully created a new project!";
        }

        public CreateProjectCommand(Database database, ModelsFactory factory)
        {
            Guard.WhenArgument(database, "CreateProjectCommand Database").IsNull().Throw();
            Guard.WhenArgument(
                factory, "CreateProjectCommand ModelsFactory")
                .IsNull().Throw();

            db = database;
            zavod = factory;
        }
    }
}
