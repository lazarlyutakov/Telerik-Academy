using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public static class SortWorkersExtension
    {
        public static void SortWorkersMoneyPerHour(this List<Worker> listOfWorkers)
        {
            // order Students using LINQ
            var sortedWorkers =
                from workers in listOfWorkers
                orderby workers.MoneyPerHour() descending
                select $"{workers.FirstName} {workers.LastName} ----> {workers.MoneyPerHour()}";
            Console.WriteLine("Workers ordered by money per hour (descending) : \r\n");
            Console.WriteLine(string.Join("\r\n", sortedWorkers));
            Console.WriteLine(new string('=', 100) + "\r\n");

            // using Lambda expression
            var sortEm = listOfWorkers.OrderBy(wrk => wrk.MoneyPerHour());
        }
    }
}
