using SchoolSystem.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    internal class StudentListMarks : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int studentsId = int.Parse(parameters[2]);
            var studentToList = PersonnelArchive.Students[studentsId];

            return studentToList.ListMarks();
        }
    }
}