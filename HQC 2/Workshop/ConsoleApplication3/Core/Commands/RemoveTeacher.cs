using SchoolSystem.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    internal class RemoveTeacher : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int teacherIdToRemove = int.Parse(parameters[2]);
            PersonnelArchive.Teachers.Remove(teacherIdToRemove);

            return $"Student with ID {teacherIdToRemove} was sucessfully removed.";
        }
    }
}