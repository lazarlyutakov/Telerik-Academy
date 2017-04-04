using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSort
{
    public static class ExtensionMethodProblem14
    {
        public static void ExtractWithTwotMarks(this List<Student> listOfStudents)
        {
            var withTwoMarks = listOfStudents.Where(student => student.Marks.Count == 2);

            Console.WriteLine("Students with exactly two marks : \r\n");
            foreach (var item in withTwoMarks)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine(new string('#', 80) + "\r\n");
        }
    }
}
