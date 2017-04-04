using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private readonly double weekSalary;
        private uint workHoursPerDay;

        public double WeekSalary { get { return this.weekSalary; } }
        public uint WorkHoursPerDay { get { return this.workHoursPerDay; } }

        public Worker (string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, double weekSalary, uint workHoursPerDay) : base(firstName, lastName)
        {
            if (weekSalary > 0)
            {
                this.weekSalary = weekSalary;
            }
            else
            {
                throw new ArgumentException("Salary must be a number greater than zero !");
            }

            if (workHoursPerDay > 0 && workHoursPerDay <= 24)
            {
                this.workHoursPerDay = workHoursPerDay;
            }
            else
            {
                throw new ArgumentException("Work hours per day must be in the range [1.....24] !");
            }
        }



        public double MoneyPerHour()
        {
            double salaryPerHour = (weekSalary / 5) / workHoursPerDay;
            return salaryPerHour;
        }
    }
}
