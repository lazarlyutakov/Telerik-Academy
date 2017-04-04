using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class ClassOfStudents : IAddRemovePersonnel
    {
        private string textIdentifier;
        private List<Teachers> listOfTeachers = new List<Teachers>();
        private List<Students> listOfStudents = new List<Students>();
        private List<string> optionalComment = new List<string>();

        public ClassOfStudents()
        {

        }

        public ClassOfStudents(string textIdentifier)
        {
            this.textIdentifier = textIdentifier;
        }

        public ClassOfStudents(string textIdentifier, string comments)
        {
            this.textIdentifier = textIdentifier;
            this.optionalComment.Add(comments);
        }
        
        public void AddStudent(Students newStudent)
        {
            this.listOfStudents.Add(newStudent);
        }

        public void AddTeacher(Teachers newTeacher)
        {
            this.listOfTeachers.Add(newTeacher);
        }

        public void RemoveStudent(Students studentToRemove)
        {
            this.listOfStudents.Remove(studentToRemove);
        }

        public void RemoveTeacher(Teachers teacherToRemove)
        {
            this.listOfTeachers.Remove(teacherToRemove);
        }


    }
}
