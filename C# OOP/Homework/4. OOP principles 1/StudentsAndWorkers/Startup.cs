using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Startup
    {
      

        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Ivan", "Petrov", 5));
            listOfStudents.Add(new Student("Peter", "Dimitrov", 5.52f));
            listOfStudents.Add(new Student("Paco", "Stoyanov", 4));
            listOfStudents.Add(new Student("Mitko", "Georgiev", 5.23f));
            listOfStudents.Add(new Student("Gosho", "Ivanov", 6));
            listOfStudents.Add(new Student("Joro", "Stamatov", 3.54f));
            listOfStudents.Add(new Student("Mariq", "Pencheva", 4.87f));
            listOfStudents.Add(new Student("Stanka", "Dimitrova", 4.25f));
            listOfStudents.Add(new Student("Ani", "Qneva", 5.32f));
            listOfStudents.Add(new Student("Bobi", "Turboto", 2));



            List<Worker> listOfWorkers = new List<Worker>();

            listOfWorkers.Add(new Worker("Vaklin", "Dzverev", 650, 8));
            listOfWorkers.Add(new Worker("Bai", "Ivan", 450, 6));
            listOfWorkers.Add(new Worker("Dobri", "Dzhurov", 700, 7));
            listOfWorkers.Add(new Worker("Penio", "Goshov", 800, 8));
            listOfWorkers.Add(new Worker("Ilko", "Toshev", 650, 7));
            listOfWorkers.Add(new Worker("Joro", "Peshev", 1200, 8));
            listOfWorkers.Add(new Worker("Martin", "Dimov", 400, 5));
            listOfWorkers.Add(new Worker("Paco", "Keleshev", 650, 8));
            listOfWorkers.Add(new Worker("Gaco", "Bacov", 850, 7));
            listOfWorkers.Add(new Worker("Tosho", "Vankov", 650, 8));


            // order students
            SortStudentsExtension.SortStudentsAscendingMarks(listOfStudents);

            //order workers
            SortWorkersExtension.SortWorkersMoneyPerHour(listOfWorkers);

            var mergedLists = listOfStudents.Concat<Human>(listOfWorkers);

            //using LINQ
            var sortMergedList =
                from elements in mergedLists
                orderby elements.FirstName, elements.LastName
                select elements;

            Console.WriteLine("Both list merged and sorted by first and last name : \r\n");
            foreach (var element in sortMergedList)
            {
                Console.WriteLine(element.FirstName + " " + element.LastName);
            }
            Console.WriteLine(new string('=', 100) + "\r\n");


            //using Lambda
            //var sortCombined = mergedLists.OrderBy(ml => ml.FirstName).ThenBy(ml => ml.LastName);
            //foreach (var item in sortCombined)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName);
            //}


        }

        
    }
}
