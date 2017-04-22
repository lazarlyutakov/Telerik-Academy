namespace ExceptionHandling.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class CSharpExam : Exam
    {
        private const string SCORE_OUT_OF_RANGE_EXCEPTION_MESSAGE = "The score must be between 0 and 100, inclusive!";       

        public CSharpExam(int score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException(SCORE_OUT_OF_RANGE_EXCEPTION_MESSAGE);
            }

            this.Score = score;
        }

        public int Score { get; private set; }

        public override ExamResult Check()
        {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
