using SchoolSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Commands
{
    public class RemoveTeacher : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int teacherToRemoveId = int.Parse(parameters[0]);
            PersonellArchive.Teachers.Remove(teacherToRemoveId);

            return $"Teacher with ID {teacherToRemoveId} was sucessfully removed.";
        }
    }
}
