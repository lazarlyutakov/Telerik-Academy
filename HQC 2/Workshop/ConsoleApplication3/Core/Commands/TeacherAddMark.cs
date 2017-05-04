using SchoolSystem.Core.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    public class TeacherAddMark : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            int teacherId = int.Parse(parameters[0]);
            int studentId = int.Parse(parameters[1]);
            float markValue = float.Parse(parameters[2]);

            var student = PersonellArchive.Students[studentId];
            var teacher = PersonellArchive.Teachers[teacherId];

            teacher.AddMark(student, markValue);

            return $"Teacher {teacher.FirstName} {teacher.LastName} added mark {markValue} to student {student.FirstName} {student.LastName} in {teacher.Subject}.";
        }
    }
}