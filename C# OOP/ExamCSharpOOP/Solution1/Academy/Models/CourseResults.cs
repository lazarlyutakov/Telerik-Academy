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
        private ICourse course;
        private float examPoints;
        private float coursePoints;
        private Grade grade;

        public ICourse Course { get; set; }

        public float ExamPoints { get; set; }


        public float CoursePoints { get; set; }


        public Grade Grade
        {
            get
            {

                if (examPoints >= 65 || coursePoints >= 75)
                {
                    return Grade.Excellent; 
                }
                else if (examPoints < 60 && examPoints >= 30 || coursePoints < 75 && coursePoints >= 45)
                {
                    return Grade.Passed;
                }
                else
                {
                    return Grade.Failed;
                }
            }

        }


        public CourseResults(ICourse course, float examPoints, float coursePoints)
        {
            
            this.Course = course;
            this.ExamPoints = examPoints;
            this.CoursePoints = coursePoints;


        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "*{0}: Points - {1}, Grade - {2}", this.Course, this.CoursePoints, this.Grade);
        }


    }
}
