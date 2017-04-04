using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using System.Globalization;


namespace Academy.Models
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private readonly IList<IStudent> onSiteStudents;
        private readonly IList<IStudent> onlineStudents;
        private readonly IList<ILecture> lectures;

        public string Name
        {
            get
            {
                return this.name;
            }
             set
            {
                if(value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentOutOfRangeException("The name of the course must be between 3 and 45 symbols!");
                }
                this.name = value;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }
             set
            {
                if(value < 1 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures per week must be between 1 and 7!");
                }
                this.lecturesPerWeek = value;
            }
        }

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate
        {
            get
            {
                return this.StartingDate.AddDays(30);
            }

            set
            {
                this.endingDate = this.startingDate.AddDays(30);
            }
        }
   

        public IList<IStudent> OnsiteStudents { get;  }

        public IList<IStudent> OnlineStudents { get;  }

        public IList<ILecture> Lectures { get; }


        public Course(string name, int lecturesPerWeek, DateTime startingDate)
                        

        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this.StartingDate = startingDate;
            this.endingDate = endingDate;
            this.onSiteStudents = onSiteStudents;
            this.onlineStudents = onlineStudents;
            this.lectures = lectures;

        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, @"*Course
                                                                 - Name: {0}
                                                                 - Lectures per week: {1}
                                                                 - Starting date: {2}
                                                                 - Ending date: {3}
                                                                 - Lectures: {4}",
                                                                 this.Name, this.LecturesPerWeek, this.StartingDate, this.EndingDate, this.Lectures);
        }
    }

  
}
