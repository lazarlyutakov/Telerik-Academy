using System;
using System.Collections.Generic;
using SchoolSystem.Enums;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SchoolSystem.Contracts;

namespace SchoolSystem.Models
{
    internal class Student : IStudent
    {
        private const int MIN_NAME_LENGTH = 2;
        private const int MAX_NAME_LENGTH = 31;
        private const int MAX_AMOUNT_OF_MARKS = 20;

        private string firstName;
        private string lastName;
        private Grade grade;
        private List<Mark> mark;

        public Student(string firstName, string lastName, Grade grade)
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

            this.grade = grade;

            if (this.mark.Count > MAX_AMOUNT_OF_MARKS)
            {
                throw new ArgumentOutOfRangeException("The maximum amount of marks is 20!");
            }
            else
            {
                this.mark = new List<Mark>();
            }
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

        public Grade Grade { get; }

        public List<Mark> Mark
        {
            get
            {
                return this.mark;
            }
        }

        public string ListMarks()
        {
            if (this.Mark.Count == 0)
            {
                return "The student has no marks.";
            }

            var builder = new StringBuilder();
            builder.AppendLine("The student has these marks:");

            var marksAsString = this.Mark
                .Select(m => $"{m.Subject} => {m.Value}")
                .ToList();

            marksAsString.ForEach(m => builder.AppendLine(m));

            return builder.ToString();
        }
    }
}
