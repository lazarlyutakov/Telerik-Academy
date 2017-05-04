using SchoolSystem.Enums;
using System.Collections.Generic;

namespace SchoolSystem.Contracts
{
    public interface IStudent
    {
        Grade Grade { get; set; }

        IList<IMark> Marks { get; }

        string ListMarks();
    }
}
