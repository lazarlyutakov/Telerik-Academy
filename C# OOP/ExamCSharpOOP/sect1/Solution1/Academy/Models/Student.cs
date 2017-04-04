using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
   public class Student : IStudent
    {
        private string name;
        private Track track;
        private IList<ICourseResult> courseResults;

        public string Username
        {
            get
            {
                return this.Username;
            }
            set
            {
                if(value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentOutOfRangeException("User's username should be between 3 and 16 symbols long!");
                }
                this.Username = value;
            }
        }

        public Track Track { get; set; }

        public IList<ICourseResult> CourseResults { get; set; }

        public Student(string username, Track track, IList<ICourseResult> courseresults)
        {
            this.Username = username;
            this.Track = track;
            this.CourseResults = courseResults;
        }

    }
}
