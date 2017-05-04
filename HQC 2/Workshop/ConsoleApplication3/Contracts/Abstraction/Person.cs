using System;
using System.Text.RegularExpressions;

namespace SchoolSystem.Contracts.Abstraction
{
    public abstract class Person
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 31;

        private const string InvalidNameLengthMessage = "The name must be between 2 and 31 characters, latin letter only!";

        private string firstName;
        private string lastName;

        protected Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length < MinNameLength || value.Length > MaxNameLength || !Regex.Match(value, "^[a-zA-Z]+$").Success)
                {
                    throw new ArgumentOutOfRangeException(InvalidNameLengthMessage);
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

            set
            {
                if (value.Length < MinNameLength || value.Length > MaxNameLength || !Regex.Match(value, "^[a-zA-Z]+$").Success)
                {
                    throw new ArgumentOutOfRangeException(InvalidNameLengthMessage);
                }

                this.lastName = value;
            }
        }
    }
}