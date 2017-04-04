using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSort
{
    public static class ExtensionMethodProblem16
    {
        public static void SortByGroupNumbers(this List<Student> listOfStudents)
        {
            var sortByGroups = listOfStudents.OrderBy(st => st.GroupNumber);

            Console.WriteLine("Student arranged by group number ( using extension method ): \r\n");
            foreach (var item in sortByGroups)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " is in group N " + item.GroupNumber);
            }
            Console.WriteLine(new string('#', 80) + "\r\n");
        }
    }
}
