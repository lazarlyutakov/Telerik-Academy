using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Contracts;
using SchoolSystem.Enums;
using SchoolSystem.Models;

namespace SchoolSystem.Core
{
    internal class Commands : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            return "";
        }

        public string CreateStudent(string firstName, string lastName, Grade grade)
        {
            int id = 0;
            var student = new Student(firstName, lastName, grade);
            PersonnelArchive.Students.Add(id, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {id++} was created.";
        }

        public string CreateTeacher(string firstName, string lastName, Subject subject)
        {
            int id = 0;
            var teacher = new Teachers(firstName, lastName, subject);
            PersonnelArchive.Teachers.Add(id, teacher);

            return $"A new teacher with name {firstName} {lastName}, grade {subject} and ID {id++} was created.";
        }

        public string RemoveStudent(int studentId)
        {
            PersonnelArchive.Students.Remove(studentId);
            return $"Student with ID {studentId} was sucessfully removed.";
        }

        public string RemoveTeacher(int teacherId)
        {
            PersonnelArchive.Teachers.Remove(teacherId);
            return $"Student with ID {teacherId} was sucessfully removed.";
        }


    }
}
