using SchoolSystem.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    internal class TeacherAddMark : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int teacherId = int.Parse(parameters[0]);
            int studentId = int.Parse(parameters[1]);
            float mark = float.Parse(parameters[2]);

            var teacherToAddMark = PersonnelArchive.Teachers[teacherId];
            var studentToReceiveMark = PersonnelArchive.Students[studentId];

            teacherToAddMark.AddMark(studentToReceiveMark, mark);

            return $"Teacher {teacherToAddMark.FirstName} {teacherToAddMark.LastName} added mark {mark} to student {studentToReceiveMark.FirstName} {studentToReceiveMark.LastName} in {teacherToAddMark.Subject}.";
        }
    }
}