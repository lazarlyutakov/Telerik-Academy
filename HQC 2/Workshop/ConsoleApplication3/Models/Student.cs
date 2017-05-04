using System.Collections.Generic;
using System.Linq;
using SchoolSystem;
using SchoolSystem.Contracts;
using SchoolSystem.Contracts.Abstraction;
using SchoolSystem.Enums;
using System.Text;

namespace ScoolSystem.Models
{
    public class Student : Person, IStudent
    {        
        public Student(string firstName, string lastName, Grade grade) : base(firstName, lastName)
        {
            this.Grade = grade;
            this.Marks = new List<IMark>();
        }

        public Grade Grade { get; set; }

        public IList<IMark> Marks { get; private set; }

        public string ListMarks()
        {
            if (this.Marks.Count == 0)
            {
                return "This student has no marks.";
            }

            var builder = new StringBuilder();
            builder.AppendLine("The student has these marks:");

            var listedMarks = this.Marks.Select(m => $"{m.Subject} => {m.MarkValue}").ToList();

            listedMarks.ForEach(m => builder.AppendLine(m));
            return builder.ToString();
        }
    }
}
