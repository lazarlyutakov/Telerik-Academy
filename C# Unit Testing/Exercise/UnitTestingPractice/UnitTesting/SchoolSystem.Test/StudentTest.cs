namespace SchoolSystem.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ScoolSystem.Models;
    using ScoolSystem.Contracts;
    using ScoolSystem.Common;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), AllowDerivedTypes = false)]
        public void StudentConstructor_WithNullName_ShouldThrowAnException()
        {
            string studentName = null;
            uint studentId = 10000;

            var student = new Student(studentName, studentId);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), AllowDerivedTypes = false)]
        public void StudentConstructor_WithEmptyStringName_ShouldThrowException()
        {
            string studentName = "";
            uint studentID = 10001;

            var student = new Student(studentName, studentID);

        }

        [TestMethod]
        public void StudentIsExpectedToHaveId()
        {
            uint studentID = 10022;
            Student studennt = new Student("lll", studentID);
            Assert.AreEqual(studentID, studennt.ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void StudentConstructor_WithLowerRangeID_ShouldThrowAnException()
        {
            var student = new Student("Kondio", 123);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void StudentConstructor_WithUpperRangeID_ShouldThrowAnException()
        {
            var student = new Student("Lia", 12555666);
        }

        [TestMethod]
        public void Student_ShouldReturnExpectedName()
        {
            var student = new Student("Petko", 12345);

            Assert.AreEqual("Petko", student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void StudentWithAlreadyUsedID_ShouldThrowAnException()
        {
            var student = new Student("Mancho", 10258);
            var student2 = new Student("Igor", 10258);

        }

        [TestMethod]
        public void JoinCourseNull_ShouldReturnException()
        {
            var student = new Student("pencho", 12356);

            Assert.ThrowsException<NullReferenceException>(() => student.JoinCourse(null));
        }

        [TestMethod]
        public void LeaveCourse_CourseIsNull_ShouldThrowAnException()
        {
            var student = new Student("Malamir", 45632);

            Assert.ThrowsException<NullReferenceException>(() => student.LeaveCourse(null));
        }




    }
}