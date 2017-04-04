namespace SchoolSystem.Test
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ScoolSystem.Contracts;
    using ScoolSystem.Models;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), AllowDerivedTypes = false)]
        public void SchoolConstructor_WithNullName_ShouldThrowAnException()
        {
            var school = new School(null);
        }

        [TestMethod]
        //[ExpectedException(typeof(NullReferenceException), AllowDerivedTypes = false)]
        public void SchoolConstructor_WithEmptyName_ShouldThrowAnexception()
        {
            var school = new School("");

            Assert.ThrowsException<NullReferenceException>(() => school.SchoolName);
        }

        [TestMethod]
        public void SchoolName_ShouldReturnExpectedName()
        {
            var school = new School("Telerik");

            Assert.AreEqual("Telerik", school.SchoolName);
        }

        [TestMethod]
        public void SchoolConstructor_CreateInstanceOfStudentCollection_ShoulReturnTrue()
        {
            var school = new School("pyrva");

            Assert.IsInstanceOfType(school.Students, typeof(ICollection<IStudent>));
        }

        [TestMethod]
        public void SchoolConstructor_CreateInstanceOfCourseCollection_ShouldRetrunTrue()
        {
            var school = new School("ooo");

            Assert.IsInstanceOfType(school.Courses, typeof(ICollection<ICourse>));
        }

        [TestMethod]
        public void AdmitStudent_StudentIsNull_ShouldThrowAnException()
        {
            var school = new School("kl");

            Assert.ThrowsException<NullReferenceException>(() => school.AdmitStudent(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void AdmitStudent_StudentIsAlreadyInTheList_ShouldThowAnException()
        {
            var school = new School("2ro");
            var student = new Student("kurcho", 58796);

            school.AdmitStudent(student);
            school.AdmitStudent(student);
        }

        [TestMethod]
        public void AddCourse_CourseIsNull_ShouldThrowException()
        {
            var school = new School("Uyt");

            Assert.ThrowsException<NullReferenceException>(() => school.AddCourse(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void AddCourse_CourseIsAlreadyInTheList_ShouldThrowAnException()
        {
            var school = new School("MG");
            var course = new Course("Math");

            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void ExpellStudent_StudentIsNull_ShouldThrowAnException()
        {
            var school = new School("fff");

            Assert.ThrowsException<NullReferenceException>(() => school.ExpellStudent(null));
        }

        [TestMethod]
        public void ExpellStudent_StudentIsNotInTheList_ShouldThrowException()
        {
            var school = new School("kkk");
            var student = new Student("kou", 12345);

            Assert.ThrowsException<ArgumentException>(() => school.ExpellStudent(student));
        }

        [TestMethod]
        public void RemoveCourse_CourseIsNull_ShouldThrowException()
        {
            var school = new School("lkj");

            Assert.ThrowsException<NullReferenceException>(() => school.RemoveCourse(null));
        }

        [TestMethod]
        public void RemoveCourse_CourseIsNotInTheList_ShouldThrowException()
        {
            var school = new School("ggg");
                var course = new Course("Tech");

            Assert.ThrowsException<ArgumentException>(() => school.RemoveCourse(course));
        }

    }
}