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
    public class UpdateMethodTests
    {
        [Test]
        public void Update_ShouldThrowArgumentNullException_WhenPackageIsNull()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();

            var sut = new PackageRepository(loggerMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Update(null));

        }

        [Test]
        public void Update_ShouldThrowArgumentNullException_WhenPackageIsNotFound()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packageMock = new Mock<IPackage>();

            var sut = new PackageRepository(loggerMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Update(packageMock.Object));
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);

        }

        [Test]
        public void Update_ReturnTrueAndUpdate_WhenPackageIsFoundWithLowerVersion()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("name");
            packageMock.Setup(x => x.Url).Returns("url");
            packageMock.Setup(x => x.Dependencies).Returns(new List<IPackage>());
            packageMock.Setup(x => x.Version.Major).Returns(6);
            packageMock.Setup(x => x.Version.Minor).Returns(2);
            packageMock.Setup(x => x.Version.Patch).Returns(5);
            packageMock.Setup(x => x.Version.VersionType).Returns(Enums.VersionType.alpha);

            packageMock.Setup(x => x.CompareTo(It.IsAny<IPackage>())).Returns(1);
            packageMock.Setup(x => x.Equals(packageMock.Object)).Returns(true);

            var packageMockAdded = new Mock<IPackage>();

            packageMockAdded.Setup(x => x.Name).Returns("name");

            var collection = new List<IPackage>()
            {
                packageMockAdded.Object
            };

            var sut = new PackageRepository(loggerMock.Object, collection);

            //Act
            var result = sut.Update(packageMock.Object);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Update_ThrowArgumentException_WhenPackageIsFoundWithHigherVersion()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("name");
            packageMock.Setup(x => x.Url).Returns("url");
            packageMock.Setup(x => x.Dependencies).Returns(new List<IPackage>());
            packageMock.Setup(x => x.Version.Major).Returns(6);
            packageMock.Setup(x => x.Version.Minor).Returns(2);
            packageMock.Setup(x => x.Version.Patch).Returns(5);
            packageMock.Setup(x => x.Version.VersionType).Returns(Enums.VersionType.alpha);

            packageMock.Setup(x => x.CompareTo(It.IsAny<IPackage>())).Returns(-1);
            packageMock.Setup(x => x.Equals(packageMock.Object)).Returns(true);

            var packageMockAdded = new Mock<IPackage>();

            packageMockAdded.Setup(x => x.Name).Returns("name");

            var collection = new List<IPackage>()
            {
                packageMockAdded.Object
            };

            var sut = new PackageRepository(loggerMock.Object, collection);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Update(packageMock.Object));
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Update_ReturnFalseAndUpdate_WhenPackageIsFoundWithSameVersion()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("name");
            packageMock.Setup(x => x.Url).Returns("url");
            packageMock.Setup(x => x.Dependencies).Returns(new List<IPackage>());
            packageMock.Setup(x => x.Version.Major).Returns(6);
            packageMock.Setup(x => x.Version.Minor).Returns(2);
            packageMock.Setup(x => x.Version.Patch).Returns(5);
            packageMock.Setup(x => x.Version.VersionType).Returns(Enums.VersionType.alpha);

            packageMock.Setup(x => x.CompareTo(It.IsAny<IPackage>())).Returns(0);
            packageMock.Setup(x => x.Equals(packageMock.Object)).Returns(true);

            var packageMockAdded = new Mock<IPackage>();

            packageMockAdded.Setup(x => x.Name).Returns("name");

            var collection = new List<IPackage>()
            {
                packageMockAdded.Object
            };

            var sut = new PackageRepository(loggerMock.Object, collection);

            //Act
            var result = sut.Update(packageMock.Object);

            //Assert
            Assert.IsFalse(result);
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }
    }
}
