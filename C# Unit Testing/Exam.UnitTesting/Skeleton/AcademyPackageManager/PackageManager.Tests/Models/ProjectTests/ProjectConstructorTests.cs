using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class ProjectConstructorTests
    {
        [Test]
        public void Constructor_ShouldSeUpName_WhenProperValuePassed()
        {
            //Arrange
            string name = "Valid name";
            string location = "Valid location";
            var packagesMock = new Mock<IRepository<IPackage>>();

            var sut = new Project(name, location, packagesMock.Object);

            //Act & Assert
            Assert.AreEqual(name, sut.Name);
        }


        [Test]
        public void Constructor_ShouldSeUpLocation_WhenProperValuePassed()
        {
            //Arrange
            string name = "Valid name";
            string location = "Valid location";
            var packagesMock = new Mock<IRepository<IPackage>>();

            var sut = new Project(name, location, packagesMock.Object);

            //Act & Assert
            Assert.AreEqual(location, sut.Location);
        }

        [Test]
        public void Constructor_ShouldSeUpPackageRepository_WhenProperValuePassed()
        {
            //Arrange
            string name = "Valid name";
            string location = "Valid location";
            var packagesMock = new Mock<IRepository<IPackage>>();

            var sut = new Project(name, location, packagesMock.Object);

            //Act & Assert
            Assert.AreEqual(packagesMock.Object, sut.PackageRepository);
        }

        [Test]
        public void Constructor_ShoultSetPackageRepositoryCorrectlyForOptionalParameterPackages()
        {
            //Arrange
            var sut = new Project("valid name", "location");

            //Act & Assert
            Assert.IsInstanceOf<IRepository<IPackage>>(sut.PackageRepository);

        }

    }
}
