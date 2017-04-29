using SchoolSystem.Contracts;
using SchoolSystem.Enums;
using SchoolSystem.Models;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    internal class CreateStudent : ICommand
    {
        private static int studentId = 0;

        public string Execute(IList<string> parameters)
        {
            string firstName = parameters[0];
            string lastName = parameters[1];
            Grade grade = (Grade)int.Parse(parameters[2]);

            var student = new Student(firstName, lastName, grade);
            PersonnelArchive.Students.Add(studentId, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {studentId++} was created.";
        }       
    }
}