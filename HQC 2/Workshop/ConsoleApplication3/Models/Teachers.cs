using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Enums;
using SchoolSystem.Contracts;
using System.Text.RegularExpressions;

namespace SchoolSystem.Models
{
    internal class Teachers : ITeacher
    {
        private string firstName;
        private string lastName;
        private Subject subject; 
                      
        public Teachers(string firstName, string lastName, Subject subject)
        {
            if (firstName.Length < 2 || firstName.Length > 31 || !Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentOutOfRangeException("The first name must be between 1 and 31 symbols");
            }
            else
            {
                this.firstName = firstName;
            }

            if (lastName.Length < 2 || lastName.Length > 31 || !Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentOutOfRangeException("The last name must be between 1 and 31 symbols");
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
            var studentMark = new Mark(this.Subject, mark);
            student.Mark.Add(studentMark);
        }
    }
}