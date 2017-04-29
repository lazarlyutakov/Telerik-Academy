using SchoolSystem.Enums;
using System.Collections.Generic;

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