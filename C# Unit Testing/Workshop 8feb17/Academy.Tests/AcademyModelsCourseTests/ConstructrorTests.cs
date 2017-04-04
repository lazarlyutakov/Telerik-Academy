using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.AcademyModelsCourseTests
{
    [TestFixture]
    public class ConstructrorTests
    {
        [Test]
        public void CourseConstructor_ShouldReturnExpectedName_WhenPassedValidValue()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

            //Act & Assert
            Assert.AreEqual("OOP", sut.Name);          
        }

        [Test]
        public void CourseConstructor_ShouldReturnExpectedLecturesPerWeek_WhenPassedValidValue()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

            //Act & Assert
            Assert.AreEqual(2, sut.LecturesPerWeek);
        }

        [Test]
        public void CourseConstructor_ShouldReturnExpectedStartDate_WhenPassedValidValue()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

            //Act & Assert
            Assert.AreEqual(new DateTime(2016, 10, 10), sut.StartingDate);
        }

        [Test]
        public void CourseConstructor_ShouldReturnExpectedEndDate_WhenPassedValidValue()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

            //Act & Assert
            Assert.AreEqual(new DateTime(2016, 11, 11), sut.EndingDate);
        }

        [Test]
        public void CourseConstructor_ShouldInitializeOnLineStudentsCollection()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));
            var studentStub = new Mock<IStudent>();

            //Act
            sut.OnlineStudents.Add(studentStub.Object);

            //Assert
            Assert.That(() => sut.OnlineStudents.Contains(studentStub.Object));
        }

        [Test]
        public void CourseConstructor_ShouldInitializeOnSiteStudentsCollection()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));
            var studentStub = new Mock<IStudent>();

            //Act
            sut.OnsiteStudents.Add(studentStub.Object);

            //Assert
            Assert.That(() => sut.OnsiteStudents.Contains(studentStub.Object));
        }

        [Test]
        public void CourseConstructor_ShouldInitializeLecturesCollection()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));
            var lectureStub = new Mock<ILecture>();

            //Act
            sut.Lectures.Add(lectureStub.Object);

            //Assert
            Assert.That(() => sut.Lectures.Contains(lectureStub.Object));
        }


        //Vtori nachin za testvane
        [Test]
        public void CourseConstructor_CreateInstanceOfStudentCollection_ShoulReturnTrue()
        {
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

            Assert.IsInstanceOf( typeof(ICollection<IStudent>), sut.OnlineStudents);
        }
    }
}
