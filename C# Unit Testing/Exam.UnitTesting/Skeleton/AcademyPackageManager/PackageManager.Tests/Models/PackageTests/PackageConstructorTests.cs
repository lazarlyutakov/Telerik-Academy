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
    public class PackageConstructorTests
    {
        [Test]
        public void Constructor_ShoutSetCorrectlyName_WhenAppropriateValuesPassed()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            //Act & Assert
            Assert.AreEqual(name, sut.Name);
        }


        [Test]
        public void Constructor_ShoutSetCorrectlyVersion_WhenAppropriateValuesPassed()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);

            //Act & Assert
            Assert.AreEqual(versionMock.Object, sut.Version);
        }

        [Test]
        public void Constructor_ShoutSetCorrectlyDependencies_WhenAppropriateValuesPassed()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object, dependenciesMock.Object);           

            //Act & Assert
            Assert.AreEqual(dependenciesMock.Object, sut.Dependencies);
        }

        [Test]
        public void Constructor_ShouldSetDependenciesCorrectlyForOptionalParameter()
        {
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.AreEqual(0, sut.Dependencies.Count);

        }

    }
}
