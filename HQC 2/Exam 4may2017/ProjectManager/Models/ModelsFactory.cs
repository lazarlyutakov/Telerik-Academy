using Bytes2you.Validation;
using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using ProjectManager.Enumerations;
using ProjectManager.Models.Contracts;
using System;

namespace ProjectManager.Models
{
    public class ModelsFactory
    {
        private readonly Validator validator = new Validator();

        public Project CreateProject(string name, string startingDate, string endingDate, ProjectState state)
        {
            DateTime starting;
            DateTime end;

            var startingDateSuccessful = DateTime.TryParse(startingDate, out starting);
            var endingDateSuccessful = DateTime.TryParse(endingDate, out end);

            if (!startingDateSuccessful)
            {
                throw new UserValidationException("Failed to parse the passed starting date!");
            }

            if (!endingDateSuccessful)
            {
                throw new UserValidationException("Failed to parse the passed ending date!");
            }

            var project = new Project(name, starting, end, state);
            validator.Validate(project);

            return project;
        }

        public Task CreateTask(string name, IUser owner, TaskState state)
        {
            var task = new Task(name, owner, state);
            validator.Validate(task);

            return task;
        }


        public User CreateUser(string username, string email)
        {
            var user = new User(email, username);
            validator.Validate(user);

            return user;
        }
    }
}
