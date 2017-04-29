using System;
using System.Text.RegularExpressions;
using SchoolSystem.Contracts;
using SchoolSystem.Enums;

namespace SchoolSystem.Models
{
    internal class Teachers : ITeacher
    {
        private const int MIN_NAME_LENGTH = 2;
        private const int MAX_NAME_LENGTH = 31;

        private string firstName;
        private string lastName;
        private Subject subject; 
                      
        public Teachers(string firstName, string lastName, Subject subject)
        {
            if (firstName.Length < MIN_NAME_LENGTH || firstName.Length > MAX_NAME_LENGTH || !Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentOutOfRangeException("The first name must be between 2 and 31 symbols");
            }
            else
            {
                this.firstName = firstName;
            }

            if (lastName.Length < MIN_NAME_LENGTH || lastName.Length > MAX_NAME_LENGTH || !Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentOutOfRangeException("The last name must be between 2 and 31 symbols");
            }
            else
            {
                this.lastName = lastName;
            }
            
            this.subject = subject;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public Subject Subject
        {
            get
            {
                return this.subject;
            }
        }

        public void AddMark(IStudent student, float mark)
        {
            int maxStudents = 20;

            if (student.Mark.Count >= maxStudents)
            {
                throw new ArgumentException($"The student's marks count cannot be more than: {maxStudents}!");
            }

            var newMark = new Mark(this.Subject, mark);
            student.Mark.Add(newMark);
        }
    }
}