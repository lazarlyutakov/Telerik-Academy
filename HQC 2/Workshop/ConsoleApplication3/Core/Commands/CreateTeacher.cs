using SchoolSystem.Core.Contracts;
using SchoolSystem.Enums;
using ScoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Commands
{
    public class CreateTeacher : ICommand
    {
        private static int teacherId = 0;

        public string Execute(IList<string> parameters)
        {
            string firstName = parameters[0];
            string lastName = parameters[1];
            var subject = (Subject)int.Parse(parameters[2]);

            var teacher = new Teacher(firstName, lastName, subject);

            PersonellArchive.Teachers.Add(teacherId, teacher);

            return $"A new student with name {firstName} {lastName}, subject {subject} and ID {teacherId++} was created.";
        }
    }
}