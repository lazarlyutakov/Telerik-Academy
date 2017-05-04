using SchoolSystem.Core.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    public class StudentListMarks : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int studentsId = int.Parse(parameters[0]);

            return PersonellArchive.Students[studentsId].ListMarks();
        }
    }
}