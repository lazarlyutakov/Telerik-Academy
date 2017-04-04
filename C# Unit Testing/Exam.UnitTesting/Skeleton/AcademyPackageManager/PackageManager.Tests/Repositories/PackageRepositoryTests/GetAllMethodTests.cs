using Moq;
using NUnit.Framework;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    public class GetAllMethodTests
    {
        [Test]
        public void GetAll_ShouldReturnEmptyCollection_WhenTheCollectionIsNotPassed()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packageMock = new Mock<IPackage>();

            var collection = new List<IPackage>();

            var sut = new PackageRepository(loggerMock.Object);

            //Act
            var found = sut.GetAll();

            //Assert
            Assert.AreEqual(0, found.Count());
        }

            [Test]
            public void GetAll_ShouldReturnCollectionWithNumbersOfElementsPassed_WhenTheCollectionPassedIsNotEmpty()
            {
                //Arrange
                var loggerMock = new Mock<ILogger>();
                var packageMock = new Mock<IPackage>();

                var collection = new List<IPackage>()
                {
                    packageMock.Object
                };

                var sut = new PackageRepository(loggerMock.Object, collection);

                //Act
                var found = sut.GetAll();

                //Assert
                Assert.AreEqual(1, found.Count());
            }
        }
}
