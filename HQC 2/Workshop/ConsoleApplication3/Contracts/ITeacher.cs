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
        string FirstName { get; }
        string LastName { get; }
        Subject Subject { get; }

        void AddMark(IStudent student, float mark);

    }
}
