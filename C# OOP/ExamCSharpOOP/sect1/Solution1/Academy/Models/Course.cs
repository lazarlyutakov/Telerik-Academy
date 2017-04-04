using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private IList<IStudent> onSiteStudents;
        private IList<IStudent> onlineStudents;
        private IList<ILecture> lectures;

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

        public DateTime EndingDate { get; set; }

        public IList<IStudent> OnsiteStudents { get;  }

        public IList<IStudent> OnlineStudents { get;  }

        public IList<ILecture> Lectures { get; }


        public Course(string name, int lecturesPerWeek, DateTime startingDate, DateTime endingDate, IList<IStudent> onSiteStudents,
                        IList<IStudent> onlineStudents, IList<ILecture> lectures)
            
        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this.StartingDate = startingDate;
            this.endingDate = endingDate;
            this.onSiteStudents = onSiteStudents;
            this.onlineStudents = onlineStudents;
            this.lectures = lectures;

        }
    }
}
