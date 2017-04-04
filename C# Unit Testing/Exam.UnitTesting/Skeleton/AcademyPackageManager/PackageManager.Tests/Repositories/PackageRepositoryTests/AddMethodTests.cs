using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Info.Contracts;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using PackageManager.Tests.CustomExceptions;
using PackageManager.Tests.Repositories.Mocks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    public class AddMethodTests
    {
        [Test]
        public void Add_ShouldThrowArgumentNullExceptionWithMessage_WhenPackageIsNull()
        {
            //Arrange
            string message = "The package cannot be null";

            var loggerMock = new Mock<ILogger>();
            var packagesMock = new Mock<ICollection<IPackage>>();

            var sut = new PackageRepository(loggerMock.Object, packagesMock.Object);

            //Act & Assert
            Assert.That(() => sut.Add(null), Throws.ArgumentNullException.With.Message.Contains(message));
        }

        [Test]
        public void Add_ShouldNotThrowAnyExceptions_WhenPackageValid()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packagesMock = new Mock<IPackage>();
            
            var sut = new PackageRepository(loggerMock.Object);
           
            //Act & Assert
            Assert.DoesNotThrow(() => sut.Add(packagesMock.Object));

        }

        [Test]
        public void Add_ShouldAddPackageWithMessage_WhenItDoesNotExistInTheList()
        {
            //Arrange
           var loggerMock = new Mock<ILogger>();
            var packagesMock = new Mock<IPackage>();

            var packageToAddMock = new Mock<IPackage>();

            var sut = new PackageRepository(loggerMock.Object);

            //Act
            sut.Add(packagesMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Add_ShouldLogMessage_WhenPackageWithTheSameVersionExists()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packagesMock = new Mock<IPackage>();

            var versionMock = new Mock<IVersion>();
            

            packagesMock.Setup(x => x.Version).Returns(versionMock.Object);

            var sut = new PackageRepository(loggerMock.Object);

            //Act
            sut.Add(packagesMock.Object);
            sut.Add(packagesMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(4));
        }

        [Test]
        public void Add_ShouldCallUpdateMethod_WhenThePackegeExists_ButWithLowerVersion_WithException()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packagesMock = new Mock<IPackage>();
            packagesMock.Setup(x => x.CompareTo(It.IsAny<IPackage>())).Returns(1);

            var collection = new List<IPackage>()
            {
                packagesMock.Object
            };

            var sut = new PackageRepositoryMock(loggerMock.Object);

            //Act
            sut.Add(packagesMock.Object);

            //Assert
            Assert.Throws<UpdateMethodCalledException>(() => sut.Add(packagesMock.Object));
        }

        [Test]
        public void Add_ShouldCallUpdateMethod_WhenThePackegeExists_ButWithHigherVersion_lodTwice()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packagesMock = new Mock<IPackage>();
            packagesMock.Setup(x => x.CompareTo(It.IsAny<IPackage>())).Returns(-1);

            var collection = new List<IPackage>()
            {
                packagesMock.Object
            };

            var sut = new PackageRepository(loggerMock.Object, collection);

            //Act
            sut.Add(packagesMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(2));
        }

    }
}
