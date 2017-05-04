using Bytes2you.Validation;
using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Commands.Contracts;
using ProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Core.Commands
{

    sealed class ListProjectsCommand : ICommand
    {
       private Database dataBase;

        public ListProjectsCommand(Database dataBase)
        {
            // guard clause
            Guard.WhenArgument(dataBase, "ListProjectsCommand Database").IsNull().Throw();
            this.dataBase = dataBase;
        }

        public string Execute(List<string> parameters)
        {
            if (parameters.Count != 0)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }
                
            if (parameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException("Some of the passed parameters are empty!");
            }
                
            return string.Join(Environment.NewLine, this.dataBase.Projects);
        }
    }
}