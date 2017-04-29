using SchoolSystem.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    internal class RemoveStudent : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int studentIdToRemove = int.Parse(parameters[2]);
            PersonnelArchive.Students.Remove(studentIdToRemove);

            return $"Student with ID {studentIdToRemove} was sucessfully removed.";
        }
    }
}