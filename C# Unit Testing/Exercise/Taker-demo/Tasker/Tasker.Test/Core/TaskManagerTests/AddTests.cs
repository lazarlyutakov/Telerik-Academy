using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasker.Core;
using Tasker.Core.Contracts;
using Tasker.Models.Contracts;
using Tasker.Test.Core.TaskManagerTests.Fakes;

namespace Tasker.Test.Core.TaskManagerTests
{
   [TestFixture]
   public class AddTests
    {
        [Test]
        public void Add_ShouldThrowArgumentNullException_WhenPassedNullvalue()
        {
           
            var idProviderStub = new Mock<IIdProvider>();
            var consoleLoggerStub = new Mock<ILogger>();
            var sut = new TaskManager(idProviderStub.Object, consoleLoggerStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.Add(null));
        }

        [TestCase(0)]
        [TestCase(5)]
        public void Add_ShouldAssignIdToProvidedTask_WhenValidTaskIsPassed(int expectedValue)
        {
    
            var taskMock = new Mock<ITask>();
            var idProviderStub = new Mock<IIdProvider>();
            var consoleLoggerStub = new Mock<ILogger>();
            idProviderStub.Setup(x => x.NextId()).Returns(expectedValue);

            var sut = new TaskManager(idProviderStub.Object, consoleLoggerStub.Object);

            sut.Add(taskMock.Object);

            taskMock.VerifySet(x => x.Id = expectedValue);
        }

        [Test]
        public void Add_ShouldlogMessage_WhenAddedProvidedTaskToCollection()
        {
            var taskStub = new Mock<ITask>();
            var idProviderStub = new Mock<IIdProvider>();
            var consoleLoggerMock = new Mock<ILogger>();
            var sut = new TaskManager(idProviderStub.Object, consoleLoggerMock.Object);

            sut.Add(taskStub.Object);

            consoleLoggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Add_ShouldAddtaskToCollection_WhenProvidedTaskIsValid()
        {
            var taskStub = new Mock<ITask>();
            var idProviderStub = new Mock<IIdProvider>();
            var consoleLoggerMock = new Mock<ILogger>();
            var sut = new TaskManagerFake(idProviderStub.Object, consoleLoggerMock.Object);

            sut.Add(taskStub.Object);

            Assert.That(() => sut.ExposedTasks.Contains(taskStub.Object));
        }

    }
}
