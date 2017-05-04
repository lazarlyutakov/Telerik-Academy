using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SchoolSystem.Contracts;
using SchoolSystem.Enums;
using ScoolSystem.Models;

namespace SchoolSystemTests.Models
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void Construcotr_ShouldReturnInstanceOfTeacher_WhenCorrectValuesPassed()
        {
            var teacher = new Teacher("Ivan", "Ivanov", Subject.Bulgarian);

            Assert.IsInstanceOf<Teacher>(teacher);
        }

        [Test]
        public void Constructor_ShouldAssignCorrectFirstName_WhneProperValuePassed()
        {
            var correctName = "Ivan";
            var teacher = new Teacher("Ivan", "Ivanov", Subject.Bulgarian);

            Assert.AreEqual(correctName, teacher.FirstName);
        }

        [Test]
        public void Constructor_ShouldAssignCorrectLastName_WhneProperValuePassed()
        {
            var correctName = "Ivanov";
            var teacher = new Teacher("Ivan", "Ivanov", Subject.Bulgarian);

            Assert.AreEqual(correctName, teacher.LastName);
        }

        [Test]
        public void Constructor_ShouldAssignCorrectSubject_WhneProperValuePassed()
        {
            var correctSubject = Subject.Bulgarian;
            var teacher = new Teacher("Ivan", "Ivanov", Subject.Bulgarian);

            Assert.AreEqual(correctSubject, teacher.Subject);
        }

        [Test]
        public void AddMarkMethod_ShouldThrowArgumentOutOfRangeException_WhenMoreThanAllowedMarksExist()
        {
            var teacher = new Teacher("Ivan", "Ivanov", Subject.Bulgarian);

            var studentMock = new Mock<IStudent>();
            var markMock = new Mock<IMark>();

            markMock.Setup(m => m.Subject).Returns(Subject.Bulgarian);
            markMock.Setup(m => m.MarkValue).Returns(4);

            studentMock.Setup(s => s.Marks.Count).Returns(20);

            Assert.Throws<ArgumentOutOfRangeException>(() => teacher.AddMark(studentMock.Object, 4));
        }

        [Test]
        public void AddMarkMethod_ShouldAddMarkToStudentsList()
        {
            float markValue = 4;
            int expectedMarksCount = 1;

            var teacher = new Teacher("Ivan", "Ivanov", Subject.Bulgarian);

            var studentMock = new Mock<IStudent>();
            var markMock = new Mock<IMark>();

            studentMock.Setup(s => s.Marks).Returns(new List<IMark>());

            teacher.AddMark(studentMock.Object, markValue);
           
            Assert.AreEqual(expectedMarksCount, studentMock.Object.Marks.Count);
        }
    }
}