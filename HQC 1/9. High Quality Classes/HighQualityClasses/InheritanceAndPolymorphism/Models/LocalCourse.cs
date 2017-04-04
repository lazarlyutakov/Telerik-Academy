namespace InheritanceAndPolymorphism.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using InheritanceAndPolymorphism.Abstraction;

    internal class LocalCourse : Course
    {
        public LocalCourse(string courseName) : base(courseName)
        {
        }

        public LocalCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab) : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Course { Name = ");

            // Not working. FormatException..Any idea why?
            // result.AppendFormat("{0} { Name = ", this.GetType().Name);
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
