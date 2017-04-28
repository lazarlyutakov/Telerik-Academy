using SchoolSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Contracts
{
    public interface IStudent
    {
        string FirstName { get; }
        string LastName { get; }
        Grade Grade { get; }
        List<Mark> Mark { get; }

        string ListMarks();
    }
}
