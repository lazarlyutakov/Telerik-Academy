using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication3
{
    public class Student
    {
        private string fNeim;
        private Grade grads;
        private List<Mark> mark;
        private string lNeim;

        public Student(string _, string __, Grade ___)
        {
            fNeim = _;
            lNeim = __;
            grads = ___;
            mark = new List<Mark>();
        }

        public string ListMarks()
        {
            var potatos = mark.Select(m => $"{m.subject} => {m.value}").ToList();
            return string.Join("\n", potatos);
        }
    }
}
