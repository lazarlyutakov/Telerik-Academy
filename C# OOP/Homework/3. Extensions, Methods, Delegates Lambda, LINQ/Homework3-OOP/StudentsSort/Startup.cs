using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSort
{
   public class Startup
    {
        private static List<Student> listOfStudents = new List<Student>
        {
                          new Student ( "Peter", "Ivanov", 18, "123406", "02 9812 3456", "peter.ivanov@gmail.com", 1, 4, 5, 5, 6, 4),
                          new Student ( "Gosho", "Todorov", 20, "132403", "02 8872 3465", "gosho.todorov@abv.bg", 3, 5, 5, 5, 3, 4),
                          new Student ( "Petkan", "Tomov", 21, "123506", "052 821 456", "petkan.tomov@gmail.com", 2, 3, 2, 5, 4, 4),
                          new Student ( "Dragan", "Georgiev", 23, "213406", "02 8124 356", "dragan.georgiev@abv.bg", 1, 5, 5, 6, 6, 4),
                          new Student ( "Ivan", "Draganov", 17, "323106", "032 813 456", "ivan.draganov@gmail.com", 3, 6, 5),
                          new Student ( "Nane",  "Vutov", 19, "313405", "02 9881 566", "nane.vutov@abv.bg", 1, 3, 6, 5, 6, 3)
                        };


        static void Main(string[] args)
        {
            //SortStudentsByName();
            //SortByAge();
            //SortByDescendingFirstName();
            // SortByGroupAndFirstName();
            //ExtractWithCertainEmail();
            //ExtractWithTelsInSofia();
            //ExtractExcellentMark();
            //ExtractWithStudentsWithTwoMarks();
            //ExtractMarks2006();
            //ArrangeByGroupNumber();
            SortByDepartements();
        }

        
        public static void SortStudentsByName()
        {
            var sortNames =
            from student in listOfStudents
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

            Console.WriteLine("Students with first name before last name :");
            Console.WriteLine();

            foreach (var student in sortNames)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine(new string('#', 80) + "\r\n");
        }


        public static void SortByAge()
        {

            var sortAge =
                from student in listOfStudents
                where student.age >= 18 && student.age <= 24
                select student.FirstName + " " + student.LastName;

            Console.WriteLine("Students at 18 <= age <= 24 : ");
            Console.WriteLine();

            foreach (var student in sortAge)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(new string('#', 80) + "\r\n");
        }


        public static void SortByDescendingFirstName()
        {
            Console.WriteLine("Students ordered by descending first name with lambda expression :");
            Console.WriteLine();

            var sortNames = listOfStudents.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var item in sortNames)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("Students ordered by descending first name with LINQ :");
            Console.WriteLine();

            var sortNamesWithLINQ =
                from student in listOfStudents
                orderby student.FirstName descending, student.LastName descending
                select student.FirstName + " " + student.LastName;

            foreach (var student in sortNamesWithLINQ)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(new string('#', 80) + "\r\n");
        }

        // Combines Problem 9 and 10
        public static void SortByGroupAndFirstName()
        {
            var sortByGroupAndFirstName =
                from student in listOfStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select $"{student.FirstName} {student.LastName} is in group N : {student.GroupNumber}";

            Console.WriteLine("Students in group N 2 are ( ordered by first name ascending, using LINQ ) : \r\n");
            Console.WriteLine(string.Join("\r\n", sortByGroupAndFirstName));
            Console.WriteLine(new string('-', 80) + "\r\n");
            Console.WriteLine("Ordered using Lambda expression : \r\n");

            var usingLambda = listOfStudents.OrderBy(student => student.FirstName).Where(student => student.GroupNumber == 2);

            foreach (var student in usingLambda)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " is in group N :  " + student.GroupNumber);
            }
            Console.WriteLine(new string('#', 80) + "\r\n");


        }


        public static void ExtractWithCertainEmail()
        {
            var extract =
                from student in listOfStudents
                where student.Email.EndsWith("abv.bg")
                select $"{student.FirstName} {student.LastName} --> {student.Email}";

            Console.WriteLine("Students with email in abv.bg : \r\n");
            Console.WriteLine(string.Join("\r\n", extract));
            Console.WriteLine(new string('#', 80) + "\r\n");

            



        }


        public static void ExtractWithTelsInSofia()
        {
            var telInSofia =
                from student in listOfStudents
                where student.Tel.StartsWith("02")
                select $"{student.FirstName} {student.LastName} --> {student.Tel}";

            Console.WriteLine("Students with phone number in Sofia : \r\n");
            Console.WriteLine(string.Join("\r\n", telInSofia));
            Console.WriteLine(new string('#', 80) + "\r\n");
        }


        public static void ExtractExcellentMark()
        {
            var excellentMark =
                from student in listOfStudents
                where student.Marks.Contains(6)
                select $"{student.FirstName} {student.LastName} has at least one excellent mark  ";

            Console.WriteLine("Students with at lest one excellent mark : \r\n");
            Console.WriteLine(string.Join("\r\n", excellentMark));
            Console.WriteLine(new string('#', 80) + "\r\n");
        }


        public static void ExtractWithStudentsWithTwoMarks()
        {
            ExtensionMethodProblem14.ExtractWithTwotMarks(listOfStudents);
        }


        public static void ExtractMarks2006()
        {
            var extractMarks =
                from student in listOfStudents
                where student.FN.EndsWith("06")
                select student;

            Console.WriteLine("Marks of students enrolled in 2006 : \r\n");
            foreach (var student in extractMarks)
            {
                Console.Write(string.Join("  ", student.FirstName, student.LastName + " -----> "));
                Console.WriteLine(string.Join(", ", student.Marks));
            }
            Console.WriteLine(new string('#', 80) + "\r\n");

        }


        public static void ArrangeByGroupNumber()
        {
            var byGroup =
                from student in listOfStudents
                orderby student.GroupNumber ascending
                select $"{student.FirstName} {student.LastName} is in group N : {student.GroupNumber}";

            Console.WriteLine("Students arranged by groups ( using LINQ ) : \r\n");
            Console.WriteLine(string.Join("\r\n", byGroup));
            Console.WriteLine(new string('-', 80) + "\r\n");

            ExtensionMethodProblem16.SortByGroupNumbers(listOfStudents);

            
        }


        public static void SortByDepartements()
        {
            var groups = new List<Group>
                         {
                             new Group(1, "Mathematics"),
                             new Group(2, "Foreign Language"),
                             new Group(3, "Computer Science"),
                         };

            var sortedStudents =
                from student in listOfStudents
                join discipline in groups
                on student.GroupNumber
                equals discipline.GroupNumber
                where discipline.DepartmentName == "Mathematics"
                select $"{student.FirstName} {student.LastName} is in {discipline.DepartmentName} departement .";

            Console.WriteLine("Students in the required departement : \r\n");
            Console.WriteLine(string.Join("\r\n", sortedStudents));
            Console.WriteLine(new string('#', 80) + "\r\n");
        }




    }
}

