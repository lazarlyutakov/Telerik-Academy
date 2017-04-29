using SchoolSystem.Enums;
using System.Collections.Generic;

namespace SchoolSystem.Contracts
{
    public interface ICommand
    {
        string CreateStudent(string firstName, string lastName, Grade grade);
        string CreateTeacher(string firstName, string lastName, Subject subject);
    }
}
