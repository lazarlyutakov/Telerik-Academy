
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
    public class DeleteMethodTests
    {
        [Test]
        public void Delete_ShouldThrowArgumenNullException_WhenPassedParameterIsNull()
        {
            //Arrange
            string message = "Package cannot be null";

            var loggerMock = new Mock<ILogger>();
            var packagesMock = new Mock<ICollection<IPackage>>();

            var sut = new PackageRepository(loggerMock.Object, packagesMock.Object);

            //Act & Assert
            Assert.That(() => sut.Delete(null), Throws.ArgumentNullException.With.Message.Contains(message));
        }

        [Test]
        public void Delete_ShouldThrowArgumentNullException_WhenMethodInvokedAndNoPackageFound_WithMessage()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packagesCollectionMock = new Mock<IPackage>();

            var sut = new PackageRepository(loggerMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Delete(packagesCollectionMock.Object));
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Delete_ShouldNotAnyExceptions_WhenMethodInvokedAndPackageFound()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packagesCollectionMock = new Mock<IPackage>();

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(5);
            versionMock.Setup(x => x.Minor).Returns(2);
            versionMock.Setup(x => x.Patch).Returns(6);
            versionMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            packagesCollectionMock.Setup(x => x.Name).Returns("name");
            packagesCollectionMock.Setup(x => x.Url).Returns("url");
            packagesCollectionMock.Setup(x => x.Version).Returns(versionMock.Object);
            packagesCollectionMock.Setup(x => x.Dependencies).Returns(new List<IPackage>());

            packagesCollectionMock.Setup(x => x.Equals(packagesCollectionMock.Object)).Returns(true);

            var collection = new List<IPackage>()
            {
                packagesCollectionMock.Object
            };

            var sut = new PackageRepository(loggerMock.Object, collection);


            //Act & Assert
            Assert.DoesNotThrow(() => sut.Delete(packagesCollectionMock.Object));
        }

        [Test]
        public void Delete_ShouldLogMessageThreeTimes_WhenPackageWithSuchVersionIsAddedAlreadt()
        {
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

            packageMockAdded.Setup(x => x.Dependencies).Returns(new List<IPackage>()
            {
                packageMock.Object
            });

            packageMockAdded.Setup(x => x.Equals(It.IsAny<IPackage>())).Returns(false);

            var collection = new List<IPackage>()
            {
                packageMock.Object,
                packageMockAdded.Object
            };

            var sut = new PackageRepository(loggerMock.Object, collection);

            //Act
            sut.Delete(packageMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(3));

            }

        [Test]
        public void Delete_ShouldReturnPackageDeleted_WhenPackageDeletedSuccessfully()
        {
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

            var collection = new List<IPackage>()
            {
                packageMock.Object,
            };

            var sut = new PackageRepository(loggerMock.Object, collection);

            //Act
            var removedPackage = sut.Delete(packageMock.Object);

            //Assert
            Assert.AreEqual(packageMock.Object, removedPackage);

        }
    }


    }

