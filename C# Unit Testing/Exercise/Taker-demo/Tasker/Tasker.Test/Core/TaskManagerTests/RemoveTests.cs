using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasker.Core;
using Tasker.Core.Contracts;
using Tasker.Models;
using Tasker.Models.Contracts;
using Tasker.Test.Core.TaskManagerTests.Fakes;

namespace Tasker.Test.Core.TaskManagerTests
{
    [TestFixture]
    public class RemoveTests
    {
        [Test]
        public void Remove_ShouldThrowException_WhenTaskIsNull()
        {
            var providerStub = new Mock<IIdProvider>();
            var loggerStub = new Mock<ILogger>();

            var sut = new TaskManager(providerStub.Object, loggerStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.Remove(null));
        }

        [Test]
        public void Remove_ShouldThrowException_WhenTaskIsNotTheList()
        {
            var providerStub = new Mock<IIdProvider>();
            var loggerStub = new Mock<ILogger>();
            var taskStub = new Mock<ITask>();

            var sut = new TaskManager(providerStub.Object, loggerStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.Remove(taskStub.Object));
        }

        [Test]
        public void Remove_ShouldLogMessage_WhenRemovedTaskFromCollection()
        {
            var taskStub = new Mock<ITask>();
            var providerStub = new Mock<IIdProvider>();
            var consoleLoggerMock = new Mock<ILogger>();
            var sut = new TaskManager(providerStub.Object, consoleLoggerMock.Object);

            sut.Add(taskStub.Object);
            sut.Remove(taskStub.Object);

            consoleLoggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.AtLeastOnce);
        }

        [Test]
        public void Remove_ShouldRemoveTask_WhenProvidedTaskIsValid()
        {
            var taskStub = new Mock<ITask>();
            var providerStub = new Mock<IIdProvider>();
            var loggerStub = new Mock<ILogger>();
            var sut = new TaskManagerFake(providerStub.Object, loggerStub.Object);

            sut.Add(taskStub.Object);
            sut.Remove(taskStub.Object);

            
            Assert.That(() => !sut.ExposedTasks.Contains(taskStub.Object));

        }

    }
}
