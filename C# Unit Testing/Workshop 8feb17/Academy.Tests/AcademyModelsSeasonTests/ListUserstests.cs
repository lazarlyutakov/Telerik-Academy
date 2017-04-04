//using Academy.Models;
//using Academy.Models.Contracts;
//using Moq;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Academy.Tests.AcademyModelsSeasonTests
//{
//    [TestFixture]
//    public class ListUserstests
//    {
//        [Test]
//        public void ListUsers_ShouldReturnListOfUsersAndTrainers()
//        {
//            var sut = new Season(2016, 2016, Models.Enums.Initiative.CoderDojo);
//            var trainerMock = new Mock<ITrainer>();


//            sut.Trainers.Add(trainerMock.Object);

            
//            trainerMock.Verify(x => x.ToString(), Times.Once);
//        }
//    }
//}
