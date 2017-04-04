namespace QualityMethods.Models
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QualityMethods.Contracts;

    public class Student : IStudent
    {
        public Student(string firstName, string lastName, OtherInformation otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public OtherInformation OtherInfo { get; }

        /// <summary>
        /// Bool method, that compares Birthday property of two objects type Student
        /// </summary>
        /// <param name="otherStudent">Student to be compared against</param>
        /// <returns>True or false</returns>
        public bool IsOlderThan(Student otherStudent)
        {
            var thisStudentBirthDate = this.OtherInfo.BirthDate;
            var otherStudentBirthDate = otherStudent.OtherInfo.BirthDate;

            return thisStudentBirthDate < otherStudentBirthDate;
        }
    }
}
