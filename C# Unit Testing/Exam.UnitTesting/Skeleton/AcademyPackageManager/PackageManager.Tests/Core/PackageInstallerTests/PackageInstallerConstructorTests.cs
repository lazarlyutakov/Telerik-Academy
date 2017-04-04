using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Core.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Core.PackageInstallerTests
{
    [TestFixture]
    public class PackageInstallerConstructorTests
    {
        [Test]
        public void Constructor_ShouldRestorPackeges_WhenObjectIsCreated()
        {
            //Arrange
            var downloaderMock = new Mock<IDownloader>();
            var projectMock = new Mock<IProject>();

            var packageMock = new Mock<IPackage>();

            projectMock.Setup(x => x.PackageRepository.GetAll()).Returns(new List<IPackage>()
            {
                packageMock.Object,
                packageMock.Object
            });

            //Act
            var installer = new PackageInstallerMock(downloaderMock.Object, projectMock.Object);

            //Assert
            Assert.AreEqual(2, installer.Counter);
               
        }
    }
}
