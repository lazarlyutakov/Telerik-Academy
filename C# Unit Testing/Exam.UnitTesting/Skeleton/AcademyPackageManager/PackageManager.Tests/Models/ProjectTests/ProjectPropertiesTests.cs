using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;
using PackageManager.Tests.Models.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class ProjectPropertiesTests
    {
        [Test]
        public void PropertyNameGet_ShouldReturnProperValue()
        {
            //Arrange
            string name = "Valid name";
            string location = "Valid location";
            var packagesMock = new Mock<IRepository<IPackage>>();

            var sut = new Project(name, location, packagesMock.Object);

            //Act
            var result = sut.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [Test]
        public void PropertyNameSet_ShouldAssignValueCorrectly()
        {
            //Arrange
            string name = "Valid name";
            string location = "Valid location";
            var packagesMock = new Mock<IRepository<IPackage>>();

            var sut = new MockProject(name, location, packagesMock.Object);

            //Act
            sut.Name = "other name";
            string result = sut.Name;
            string expectedOutput = "other name";

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void PropertyLocationGet_ShouldReturnCorrectValue()
        {
            //Arrange
            string name = "Valid name";
            string location = "Valid location";
            var packagesMock = new Mock<IRepository<IPackage>>();

            var sut = new Project(name, location, packagesMock.Object);

            //Act
            var result = sut.Location;

            //Assert
            Assert.AreEqual(location, result);
        }

        [Test]
        public void PropertyLocationSet_ShouldAssignValueCorrectly()
        {
            //Arrange
            string name = "Valid name";
            string location = "Valid location";
            var packagesMock = new Mock<IRepository<IPackage>>();

            var sut = new MockProject(name, location, packagesMock.Object);

            //Act
            sut.Location = "other location";
            string result = sut.Location;
            string expectedOutput = "other location";

            //Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
