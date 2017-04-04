using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSort
{
    // To see results for tasks 3, 4, 5, 9, 10, 11, 12, 13, 14, 15, 18 check Startup method

    public class Student
    {
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int age { get; private set; }
        public string FN { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }       
        public int GroupNumber { get; private set; }
        public List<float> Marks { get; private set; }

        public Student()
        {

        }

        public Student(string firstName, string surname, int age)
        {
            this.FirstName = firstName;
            this.LastName = surname;
            this.age = age;
        }

        public Student(string firstName, string surname, int age, string fn, string tel, string email, int groupNumber, params float[] marks) 
        {
            this.FirstName = firstName;
            this.LastName = surname;
            this.age = age;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = new List<float>(marks);

        }
    }
}
