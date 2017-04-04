using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.Models;
using Moq;
using System.Collections;
using System.Collections.Generic;

namespace TaskManager.Test
{
    [TestClass]
    public class TestTaskManager
    {
        [TestMethod]
        public void TestTaskManager_WhenAddTask_ShouldCallLog()
        {
         

            //Arrange
            var mockedLogger = new MockedLogger();
            var mockedIdProvider = new MockedIdProvider();
            var taskManager = new Tasker(mockedLogger, mockedIdProvider);
            

            var task = new Task("");
            //Act
            taskManager.Save(task);

            //Assert
            Assert.IsTrue(mockedLogger.IsLogCalled);

        }

        [TestMethod]
        public void TestTaskManager_WithMoq_WhenAddTask_ShouldCallLog()
        {
            //Arrange

            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            var task = new Task("");

            //Act
            taskManager.Save(task);


            //Assert
            mockedLogger.Verify();
            

        }


        [TestMethod]
        public void TestTaskManager_WithMoq_WhenAllTasksCalled_ShouldCallLogTasksCount()
        {
            //Arrange
            ICollection<Task> tasks = new List<Task>()
            {
                new Task("jgh"),
                new Task("jghffd"),
                new Task("jghzdvdv"),
                new Task("jfsbsfgh")
            };


            var mockedLogger = new Mock<ILogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);
            taskManager.Tasks = tasks;


          //  mockedLogger.Setup(x => x.Log(It.IsAny<string>()));


            //Act
            taskManager.AllTasks();


            //Assert
            mockedLogger.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(2));


        }




        public class MockedLogger : ILogger
        {
            public bool IsLogCalled;

            public void Log(string msg)
            {
                this.IsLogCalled = true;
            }
        }

        public class MockedIdProvider : IIdProvider
        {
            public int Id
            {
                get
                {
                    return 1;
                }
            }
   
        }
    }
}
