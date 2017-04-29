using SchoolSystem.Contracts;
using SchoolSystem.Enums;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Commands
{
    internal class CreateTeacher : ICommand
    {
        private static int teacherId;

        public string Execute(IList<string> parameters)
        {
            string firstName = parameters[0];
            string lastName = parameters[1];
            string subject = parameters[2];

            var teacher = new Teachers(firstName, lastName, (Subject)int.Parse(parameters[2]));
            PersonnelArchive.Teachers.Add(teacherId, teacher);

            return $"A new teacher with name {firstName} {lastName}, grade {subject} and ID {teacherId++} was created.";
        }
    }
}
