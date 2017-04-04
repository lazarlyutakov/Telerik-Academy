using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public interface IAddRemovePersonnel
    {
        void AddTeacher(Teachers newTeacher);
        void AddStudent(Students newStudent);
        void RemoveTeacher(Teachers teacherToRemove);
        void RemoveStudent(Students studentToRemove);
    }
}
