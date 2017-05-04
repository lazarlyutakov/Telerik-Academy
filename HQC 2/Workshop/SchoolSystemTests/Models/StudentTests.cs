using System;
using Moq;
using NUnit.Framework;
using SchoolSystem.Contracts;
using SchoolSystem.Enums;
using ScoolSystem.Models;

namespace SchoolSystemTests.Models
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void Constructor_ShoulReturnInstanceOfStudent_WhenProperValuesPassed()
        {
            var student = new Student("ivan", "ivanov", SchoolSystem.Enums.Grade.Eleventh);

            Assert.IsInstanceOf<Student>(student);
        }

        [Test]
        public void Constructor_ShoulAssignCorrectFirstName_WhenProperValuePassed()
        {
            string correctName = "ivan";

            var sut = new Student("ivan", "ivanov", SchoolSystem.Enums.Grade.Fifth);

            Assert.AreEqual(correctName, sut.FirstName);
        }

        [Test]
        public void Constructor_ShoulAssignCorrectLastName_WhenProperValuePassed()
        {
            string correctName = "ivanov";

            var sut = new Student("ivan", "ivanov", SchoolSystem.Enums.Grade.Fifth);

            Assert.AreEqual(correctName, sut.LastName);
        }

        [Test]
        public void Constructor_ShoulAssignCorrectGrade_WhenProperValuePassed()
        {
            var correctGrade = Grade.Fifth;

            var sut = new Student("ivan", "ivanov", SchoolSystem.Enums.Grade.Fifth);

            Assert.AreEqual(correctGrade, sut.Grade);
        }

        [Test]
        public void Constructor_ShouldSetInstanceOfMarkProperty_WhenInitialized()
        {
            var sut = new Student("ivan", "ivanov", SchoolSystem.Enums.Grade.Fifth);

            Assert.AreNotEqual(null, sut.Marks);
        }

        [TestCase("i")]
        [TestCase("ivanovivanovivanovivanovivanovivanov")]
        [TestCase("5624585")]
        [TestCase("?><%")]
        public void Constructor_ShouldThrowException_WhenFirstNameIsNotValid(string invalidName)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student(invalidName, "ivanov", Grade.Eighth));
        }

        [TestCase("i")]
        [TestCase("ivanovivanovivanovivanovivanovivanov")]
        [TestCase("5624585")]
        [TestCase("?><%")]
        public void Constructor_ShouldThrowException_WhenLastNameIsNotValid(string invalidName)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student("ivan", invalidName, Grade.Eighth));
        }

        [Test]
        public void ListMarksMethod_ReturnErrorMessage_WhenStudentHasNoMarks()
        {
            var student = new Student("ivan", "ivanov", Grade.Eighth);

            var output = student.ListMarks().ToLower();
            var expected = "no marks";

            Assert.That(output.Contains(expected));
        }

        [Test]
        public void ListMarksMethod_ShouldListTheMarks_WhenTheStudentHas()
        {
            var student = new Student("ivan", "ivanov", Grade.Eighth);

            var markMock = new Mock<IMark>();
            markMock.Setup(m => m.Subject).Returns(Subject.Bulgarian);
            markMock.Setup(m => m.MarkValue).Returns(4);

            student.Marks.Add(markMock.Object);

            var realOutput = student.ListMarks().ToLower();

            var expectedResult = "these marks";

            Assert.That(realOutput.Contains(expectedResult));
        }
    }
}