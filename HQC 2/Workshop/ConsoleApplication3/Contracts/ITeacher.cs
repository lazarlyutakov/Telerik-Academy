using SchoolSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Contracts
{
    public interface ITeacher
    {
        //string FirstName { get; set; }
        //string LastName { get; set; }
        //string Subject { get; set; }

        void AddMark(Subject subject, float mark);

    }
}
