using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class School : IAddRemoveClasses
    {
        private string name;
        private List<ClassOfStudents> schoolClasses = new List<ClassOfStudents>();

        public string Name { get { return this.name; } }

        public School(string name)
        {
            this.name = name;
        }


        public void AddClass(ClassOfStudents classToAdd)
        {
            this.schoolClasses.Add(classToAdd);
        }


        public void RemoveClass(ClassOfStudents classToRemove)
        {
            this.schoolClasses.Remove(classToRemove);
        }
    }
}
