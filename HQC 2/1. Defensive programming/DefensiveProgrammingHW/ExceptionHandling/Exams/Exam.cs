namespace ExceptionHandling.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal abstract class Exam
    {
        public abstract ExamResult Check();
    }
}
