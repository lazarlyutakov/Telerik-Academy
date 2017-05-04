using System;
using SchoolSystem.Contracts;
using SchoolSystem.Contracts.Abstraction;
using SchoolSystem.Enums;

namespace ScoolSystem.Models
{
    public class Teacher : Person, ITeacher
    {
        private const int MaxAmountOfMarks = 20;

        public Teacher(string firstName, string lastName, Subject subject) : base(firstName, lastName)
        {
            this.Subject = subject;
        }

        public Subject Subject { get; set; }

        public void AddMark(IStudent student, float markValue)
        {
            if (student.Marks.Count >= 20)
            {
                throw new ArgumentOutOfRangeException("Each student is allowed of up to 20 marks!");
            }

            var markToAdd = new Mark(this.Subject, markValue);
            student.Marks.Add(markToAdd);
        }
    }
}       