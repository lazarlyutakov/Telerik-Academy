using SchoolSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Commands
{
    public class RemoveStudent : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int studentToRemoveId = int.Parse(parameters[0]);
            PersonellArchive.Students.Remove(studentToRemoveId);

            return $"Student with ID {studentToRemoveId} was sucessfully removed.";
        }
    }
}