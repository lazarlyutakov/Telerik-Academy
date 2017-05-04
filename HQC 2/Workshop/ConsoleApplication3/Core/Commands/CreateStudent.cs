using SchoolSystem.Core.Contracts;
using SchoolSystem.Enums;
using ScoolSystem.Models;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    public class CreateStudent : ICommand
    {
        private static int studentId = 0;

        public string Execute(IList<string> parameters)
        {           
            string firstName = parameters[0];
            string lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);
            
            var student = new Student(firstName, lastName, grade);

            PersonellArchive.Students.Add(studentId, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {studentId++} was created.";
        }
    }
}