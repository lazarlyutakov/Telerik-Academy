using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoolSystem.Contracts;
using ScoolSystem.Models;


namespace SchoolSystem.Test
{
    [TestClass]
    public class CourseTest
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
        public void CourseConstructor_CreateInstanceOfStudentCollection_ShouldReturnTrue()
        {
            var course = new Course("OOP");

            Assert.IsInstanceOfType(course.Students, typeof(ICollection<IStudent>));
        }

        [TestMethod]
        public void Course_ShouldReturnExpectedName()
        {
            //Arrange
            var course = new Course("OOP");

            //Act && Assert
            Assert.AreEqual("OOP", course.CourseName);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), AllowDerivedTypes = false)]
        public void AddStudent_StudentIsNull_ShouldThrowAnException()
        {
            //arrange
            var course = new Course("Math");
            Student student = null;

            //act && assert
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void AddStudent_CourseIsFilledWithMaximumStudentsCount_ShouldThrowAnException()
        {
            //arrange
            var course = new Course("UnitTesting");
            int maxNumb = 30;

            for (int i = 0; i <= maxNumb + 1; i++)
            {
                var student = new Student(i.ToString(), 10000 + (uint)i);
                course.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void AddStudent_StudentIsAlreadyIntheList_ShouldhrowAnException()
        {
            var course = new Course("Java");
            var student = new Student("Stoyan", 11223);

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), AllowDerivedTypes = false)]
        public void RemoveStudent_StudentIsNull_ShouldThrowException()
        {
            var course = new Course("BEl");
            Student student = null;

            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
        public void RemoveStudent_StudentIsNotInTheList_ShouldThrowException()
        {
            var course = new Course("KKA");
            var student = new Student("Liolio", 11445);

            course.RemoveStudent(student);
        }







    }
}
