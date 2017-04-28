using System;
using System.Collections.Generic;
using ConsoleApplication3;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Teachers
    {
        private string firstName;
        private string lastName;
        private Subject subject; 
                      
        public Teachers(string firstName, string lastName, Subject subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }

        public void AddMark(Student teacher, float val)
        {
            var cain = new Mark(subject, val);
            this.teacher.mark.Add(cain);
        }
    }
}