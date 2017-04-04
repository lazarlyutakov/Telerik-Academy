using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;
using Academy.Models.Contracts;
using System.Globalization;

namespace Academy.Models
{
   public class CourseResults : ICourseResult
    {
        private readonly ICourse course;
        private readonly float examPoints;
        private readonly float coursePoints;
        private readonly Grade grade;

        public ICourse Course { get;}

        public float ExamPoints { get; }
 

        public float CoursePoints { get; }
      

        public Grade Grade { get; }


        public CourseResults(ICourse course, float examPoints, float coursePoints)
        {
            this.Course = course;

            if(examPoints < 0 || examPoints > 1000)
            {
                throw new ArgumentOutOfRangeException("Course result's exam points should be between 0 and 1000!");
            }
            this.ExamPoints = examPoints;

            if(coursePoints < 0 || coursePoints > 125)
            {
                throw new ArgumentOutOfRangeException("Course result's course points should be between 0 and 125!");
            }
            this.CoursePoints = coursePoints;

            if(examPoints >= 65 || coursePoints >= 75)
            {
                this.Grade = Grade.Excellent;
            }
            else if(examPoints < 60 && examPoints >= 30 || coursePoints < 75 && coursePoints >= 45)
            {
                this.Grade = Grade.Passed;
            }
            else
            {
                this.Grade = Grade.Failed;
            }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "*{0}: Points - {1}, Grade - {2}", this.Course, this.CoursePoints, this.Grade);
        }


    }
}
