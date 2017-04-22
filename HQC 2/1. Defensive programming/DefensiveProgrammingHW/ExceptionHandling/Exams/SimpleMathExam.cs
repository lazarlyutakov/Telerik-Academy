namespace ExceptionHandling.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class SimpleMathExam : Exam
    {
        private const string PROBLEMS_SOLVED_EXCEPTION_MESSAGE = "The amount of solved probles must be between 0 and 10, inclusive!";

        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0 || problemsSolved > 10)
            {
                throw new ArgumentOutOfRangeException(PROBLEMS_SOLVED_EXCEPTION_MESSAGE);
            }

            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved { get; private set; }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }

            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}
