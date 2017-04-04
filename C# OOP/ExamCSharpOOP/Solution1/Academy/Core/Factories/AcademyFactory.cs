using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;

namespace Academy.Core.Factories
{
    public class AcademyFactory : IAcademyFactory
    {
        private static IAcademyFactory instanceHolder = new AcademyFactory();

        // private because of Singleton design pattern
        private AcademyFactory()
        {
        }

        public static IAcademyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ISeason CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Initiative parsedInitiativeAsEnum;
            Enum.TryParse<Initiative>(initiative, out parsedInitiativeAsEnum);

           

           return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public IStudent CreateStudent(string username, string track)
        {

            var currentUserName = username;
            //var parsedTrack = track;
            Track parsedTrackEnum;
            Enum.TryParse<Track>(track, out parsedTrackEnum);
            return new Student(currentUserName, parsedTrackEnum);

            //throw new NotImplementedException("Student class not attached to factory.");
        }

        public ITrainer CreateTrainer(string username, string technologies)
        {
            var currentUserName = username;
            var tech = new List<string>(technologies.Split(','));

            return new Trainer(currentUserName, tech);
            //throw new NotImplementedException("Trainer class not attached to factory.");
        }

        public ICourse CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            var currentName = name;
            var parsedLectures = int.Parse(lecturesPerWeek);
            var parsedDate = DateTime.ParseExact(startingDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            return new Course(currentName, parsedLectures, parsedDate);
            //throw new NotImplementedException("Course class not attached to factory.");
        }

        public ILecture CreateLecture(string name, string date, ITrainer trainer)
        {

            var currentName = name;
            var parsedDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var currentTrainer = trainer;

            return new Lecture(currentName, parsedDate, currentTrainer);
            //throw new NotImplementedException("Lecture class not attached to factory.");
        }

        public ILectureResouce CreateLectureResouce(string type, string name, string url)
        {
            // Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;

            //switch (type)
            //{
            //    case "video":
            //    case "presentation": 
            //    case "demo": 
            //    case "homework": 
            //    default: throw new ArgumentException("Invalid lecture resource type");
            //}

            // TODO: Implement this
            throw new NotImplementedException("LectureResouce classes not attached to factory.");
        }

        public ICourseResult CreateCourseResult(ICourse course, string examPoints, string coursePoints)
        {

            var currentCourse = course;
            var currentExamPoints = float.Parse(examPoints);
            var currentCoursePOints = float.Parse(coursePoints);

            if (currentExamPoints < 0 || currentExamPoints > 1000)
            {
                throw new ArgumentOutOfRangeException("Course result's exam points should be between 0 and 1000!");
            }

            if (currentCoursePOints < 0 || currentCoursePOints > 125)
            {
                throw new ArgumentOutOfRangeException("Course result's course points should be between 0 and 125!");
            }

            return new CourseResults(currentCourse, currentExamPoints, currentCoursePOints);
            //throw new NotImplementedException("CourseResult class not attached to factory.");
        }
    }
}
