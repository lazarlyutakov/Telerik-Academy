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
    public class CompareToTests
    {
        [Test]
        public void CompareTo_ShouldTrowArgumentNullException_WhenInvalidParameterPassed()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);          
            
            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.CompareTo(null));
        }

        [Test]
        public void CompareTo_ShouldNotThrowAnyExceptions_WhenValidParameterPassed()
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
            Assert.DoesNotThrow(() => sut.CompareTo(otherMock.Object));
        }

        [Test]
        public void CompareTo_ShouldThrowArgumentException_WhenTheNameOfThePassedPackegeIsTheSame()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("other name");

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CompareTo(otherMock.Object));
        }

        [Test]
        public void CompareTo_ShouldReturnMinusOne_WhenPassedPackageIsHigherVersion()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(10);
            versionMock.Setup(x => x.Minor).Returns(5);
            versionMock.Setup(x => x.Patch).Returns(15);
            versionMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var versionOtherMock = new Mock<IVersion>();
            versionOtherMock.Setup(x => x.Major).Returns(20);
            versionOtherMock.Setup(x => x.Minor).Returns(10);
            versionOtherMock.Setup(x => x.Patch).Returns(30);
            versionOtherMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("valid name");
            otherMock.Setup(x => x.Url).Returns("url");
            otherMock.Setup(x => x.Version).Returns(versionOtherMock.Object);
            otherMock.Setup(x => x.Dependencies).Returns(dependenciesMock.Object);

            //Act
            var result = sut.CompareTo(otherMock.Object);

            //Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void CompareTo_ShouldReturnOne_WhenPassedPackageIsLowerVersion()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(100);
            versionMock.Setup(x => x.Minor).Returns(50);
            versionMock.Setup(x => x.Patch).Returns(155);
            versionMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var versionOtherMock = new Mock<IVersion>();
            versionOtherMock.Setup(x => x.Major).Returns(20);
            versionOtherMock.Setup(x => x.Minor).Returns(10);
            versionOtherMock.Setup(x => x.Patch).Returns(30);
            versionOtherMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("valid name");
            otherMock.Setup(x => x.Url).Returns("url");
            otherMock.Setup(x => x.Version).Returns(versionOtherMock.Object);
            otherMock.Setup(x => x.Dependencies).Returns(dependenciesMock.Object);

            //Act
            var result = sut.CompareTo(otherMock.Object);

            //Assert
            Assert.AreEqual(1, result);           
        }

        [Test]
        public void CompareTo_ShouldReturnZero_WhenPassedPackageIsTheSameVersion()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            versionMock.Setup(x => x.Major).Returns(20);
            versionMock.Setup(x => x.Minor).Returns(10);
            versionMock.Setup(x => x.Patch).Returns(30);
            versionMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var versionOtherMock = new Mock<IVersion>();
            versionOtherMock.Setup(x => x.Major).Returns(20);
            versionOtherMock.Setup(x => x.Minor).Returns(10);
            versionOtherMock.Setup(x => x.Patch).Returns(30);
            versionOtherMock.Setup(x => x.VersionType).Returns(Enums.VersionType.alpha);

            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            var otherMock = new Mock<IPackage>();
            otherMock.Setup(x => x.Name).Returns("valid name");
            otherMock.Setup(x => x.Url).Returns("url");
            otherMock.Setup(x => x.Version).Returns(versionOtherMock.Object);
            otherMock.Setup(x => x.Dependencies).Returns(dependenciesMock.Object);

            //Act
            var result = sut.CompareTo(otherMock.Object);

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
