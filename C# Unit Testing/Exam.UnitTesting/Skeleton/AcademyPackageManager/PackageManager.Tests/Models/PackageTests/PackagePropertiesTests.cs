using Moq;
using NUnit.Framework;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Models.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class PackagePropertiesTests
    {
        [Test]
        public void PropertyNameGet_ShoudReturnProperValue()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new MockPackage(name, versionMock.Object, dependenciesMock.Object);

            //Act
            var result = sut.Name;

            //Assert
            Assert.AreEqual(name, result);            
        }

        [Test]
        public void PropertyNameSet_ShoudAssigvaluesProperly()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new MockPackage(name, versionMock.Object, dependenciesMock.Object);

            //Act
            sut.Name = "other name";
            var result = sut.Name;
            string expectedOutput = "other name";

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void PropertyVersionGet_ShoudReturnProperValue()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new MockPackage(name, versionMock.Object, dependenciesMock.Object);

            //Act
            var result = sut.Version;

            //Assert
            Assert.AreEqual(versionMock.Object, result);
        }


        [Test]
        public void PropertyURL_ShoudBeProperlyAssigned()
        {
            //Arrange
            string name = "valid name";

            var versionMock = new Mock<IVersion>();
            var dependenciesMock = new Mock<ICollection<IPackage>>();

            var sut = new MockPackage(name, versionMock.Object, dependenciesMock.Object);

            //Act
            sut.Url = "valid url";
            string expectedOutput = "valid url";

            //Assert
            Assert.AreEqual(expectedOutput, sut.Url);
        }
    }
}
