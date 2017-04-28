using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Enums;
using SchoolSystem.Contracts;

namespace SchoolSystem.Models
{
    public class Teachers : ITeacher
    {
        private string firstName;
        private string lastName;
        private Subject subject; 
                      
        public Teachers(string firstName, string lastName, Subject subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.subject = subject;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length < 2 || value.Length > 31 || !Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentOutOfRangeException("The first name must be between 1 and 31 symbols");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 2 || value.Length > 31 || !Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentOutOfRangeException("The last name must be between 1 and 31 symbols");
                }

                this.lastName = value;
            }
        }

        public void AddMark(Subject subject, float mark)
        {
            var studentMark = new Mark(subject, mark);
            student.Mark.Add(studentMark);
        }
    }
}