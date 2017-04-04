using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class EqualsTests
    {
        [Test]
        public void Equals_ShouldThrowArgumentNullException_WhenValuePassedIsNull()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Equals(null));
        }

        [Test]
        public void Equals_ShouldThrowArgumentException_WhenValuePassedIsNotIPackage()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Equals(5));
        }

        [Test]
        public void Equals_ShouldNotThrowAnyExceptions_WhenValuePassedIsValid()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("valid name");
            otherMock.Setup(x => x.Url).Returns("url");
            otherMock.Setup(x => x.Version).Returns(versionMock.Object);
            otherMock.Setup(x => x.Dependencies).Returns(dependenciesMock.Object);

            //Act & Assert
            Assert.DoesNotThrow(() => sut.Equals(otherMock.Object));
        }

        [Test]
        public void Equals_ShouldNotThrowAnyExceptions_WhenValuePassedIsIPackage()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("valid name");
            otherMock.Setup(x => x.Url).Returns("url");
            otherMock.Setup(x => x.Version).Returns(versionMock.Object);
            otherMock.Setup(x => x.Dependencies).Returns(dependenciesMock.Object);

            //Act & Assert
            Assert.DoesNotThrow(() => sut.Equals(otherMock.Object));
        }

        [Test]
        public void Equals_CheckIfPassedPackageEqualsToThePackage()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(10);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(15);
            versionMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var versionOtherMock = new Mock<IVersion>();
            versionOtherMock.Setup(x => x.Major).Returns(10);
            versionOtherMock.Setup(x => x.Minor).Returns(5);
            versionOtherMock.Setup(x => x.Patch).Returns(15);
            versionOtherMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("valid name");
            otherMock.Setup(x => x.Url).Returns("url");
            otherMock.Setup(x => x.Version).Returns(versionOtherMock.Object);
            otherMock.Setup(x => x.Dependencies).Returns(dependenciesMock.Object);

            //Act
            var result = sut.Equals(otherMock.Object);

            //Assert
            Assert.AreEqual(true, result);
           
        }

        [Test]
        public void Equals_CheckIfPassedPackageDoesNotEqualToThePackage()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(10);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(15);
            versionMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var versionOtherMock = new Mock<IVersion>();
            versionOtherMock.Setup(x => x.Major).Returns(20);
            versionOtherMock.Setup(x => x.Minor).Returns(10);
            versionOtherMock.Setup(x => x.Patch).Returns(30);
            versionOtherMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("valid name");
            otherMock.Setup(x => x.Url).Returns("url");
            otherMock.Setup(x => x.Version).Returns(versionOtherMock.Object);
            otherMock.Setup(x => x.Dependencies).Returns(dependenciesMock.Object);

            //Act
            var result = sut.Equals(otherMock.Object);

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
