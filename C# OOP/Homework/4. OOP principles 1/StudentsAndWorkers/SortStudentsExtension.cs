using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public static class SortStudentsExtension
    {
        public static void SortStudentsAscendingMarks(this List<Student> listOfStudents)
        {
            // order Students using LINQ
            var sortedStudents =
                from students in listOfStudents
                orderby students.Grade ascending
                select $"{students.FirstName} {students.LastName} ----> {students.Grade}";
            Console.WriteLine("Students ordered by grade (ascending) : \r\n");
            Console.WriteLine(string.Join("\r\n", sortedStudents));
            Console.WriteLine(new string('=', 100) + "\r\n");

            // using Lambda expression
            var sortEm = listOfStudents.OrderBy(st => st.Grade);
        }
    }
}
