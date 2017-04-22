namespace ExceptionHandling.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ExamResult
    {       
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentOutOfRangeException("The grade must be a positive number!");
            }

            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("The minimal grade must be a positive number!");
            }

            if (maxGrade <= minGrade)
            {
                throw new ArgumentOutOfRangeException("The max grade cannot be smaller or equal to the minimal grade!");
            }

            if (comments == null || comments == string.Empty)
            {
                throw new ArgumentException("The comments cannot be null or empty!");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade { get; private set; }

        public int MinGrade { get; private set; }

        public int MaxGrade { get; private set; }

        public string Comments { get; private set; }
    }
}
