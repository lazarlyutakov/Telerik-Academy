using Moq;
using NUnit.Framework;
using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Commands;
using ProjectManager.Data;
using ProjectManager.Enumerations;
using ProjectManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerTests
{
    [TestFixture]
    public class CreateTaskCommandTests
    {
        [TestCase(3)]
        [TestCase(5)]
        public void ExecuteMethod_ShouldThrowException_WhenInvalidParametersCountPassed(int parametersCount)
        {
            // Arrange
            var parameters = new List<string>(parametersCount);
            var dataBaseMock = new Mock<IDatabase>();

            var sut = new CreateTaskCommand(dataBaseMock.Object);

            // Act & Assert
            Assert.Throws<UserValidationException>(() => sut.Execute(parameters));
        }

        [Test]
        public void ExecuteMethod_ShouldThrowException_WhenEmptyParametersPassed()
        {
            // Arrange
            var parameters = new List<string>();           
            var dataBaseMock = new Mock<IDatabase>();

            var sut = new CreateTaskCommand(dataBaseMock.Object);

            // Act
            string item = String.Empty;
            parameters.Add(item);

            // Act & Assert
            Assert.Throws<UserValidationException>(() => sut.Execute(parameters));
        }

        //[Test]
        //public void ExecuteMethod_ShouldCreateTaskWithExactlyThoseParameters()
        //{
        //    // Arrange
        //    var dataBaseMock = new Mock<IDatabase>();
        //    var userMock = new Mock<IUser>();
        //    var sut = new CreateTaskCommand(dataBaseMock.Object);

        //    var parameters = new List<string>(4);
        //    var expectedName = "ivan";
        //    var expectedOwner = userMock.Object;
        //    var expectedState = TaskState.Done;

        //    // Act
        //    var task = sut.Execute(parameters)

        //    // Act & Assert
        //    Assert.AreEqual(expectedName, task.na)
        //}
    }
}
