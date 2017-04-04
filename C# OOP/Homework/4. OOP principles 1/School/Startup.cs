using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Startup
    {
        static void Main(string[] args)
        {

            School someSchool = new School("Ivan Vazov");

            ClassOfStudents _8b = new ClassOfStudents("8 B");

            Students ivan = new Students("Ivan", 10);
            Students mitko = new Students("Mitko", 15);
            Students petko = new Students("Petko", 20);

            _8b.AddStudent(ivan);
            _8b.AddStudent(mitko);
            _8b.AddStudent(petko);

            ivan.AddComment("Iskam 6 !");
            
           
            Disciplines literature = new Disciplines("Literature", 20, 10);
            Disciplines journalism = new Disciplines("Journalism", 30, 40);


            Teachers vuchkov = new Teachers("Profesor Vuchkov");

            vuchkov.AddComment("Gledam i ne vqrvam na ushite si !");
            vuchkov.AddDiscipline(literature);
            vuchkov.AddDiscipline(journalism);

            _8b.AddTeacher(vuchkov);

            someSchool.AddClass(_8b);

            Console.WriteLine("Class number of {0} is : {1}", petko.Name, petko.ClassNumber);

            foreach (var item in vuchkov.OptionalComments)
            {
                Console.WriteLine("Professor Vuchkov declared : {0}", item);
            }

            Console.WriteLine();
            Console.WriteLine("He teaches the following disciplines : ");
            foreach (var item in vuchkov.Disciplines)
            {
                Console.WriteLine(item.NameOfLecture);
            }

            





        }
    }
}
