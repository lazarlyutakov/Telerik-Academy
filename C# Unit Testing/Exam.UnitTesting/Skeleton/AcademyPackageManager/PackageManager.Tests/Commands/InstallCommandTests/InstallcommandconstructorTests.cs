using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Commands.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    public class InstallcommandconstructorTests
    {
        [Test]
        public void Constructor_ShouldThrowArgumentNullException_WhenInstallerIsNull()
        {
            //Arrange
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new InstallCommand(null, packageMock.Object));
        }

        [Test]
        public void Constructor_ShouldThrowArgumentNullException_WhenPackageIsNull()
        {
            //Arrange
            var installerMock = new Mock<IInstaller<IPackage>>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new InstallCommand(installerMock.Object, null));
        }


         [Test]
        public void Constructor_ShouldCorrectlySetInstaller()
        {
            //Arrange
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            var sut = new MockInstallCommand(installerMock.Object, packageMock.Object);

            //Act & Asser
            Assert.AreEqual(installerMock.Object, sut.MyInstaller);
        }

         [Test]
        public void Constructor_ShouldCorrectlySetPackaeg()
        {
            //Arrange
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            var sut = new MockInstallCommand(installerMock.Object, packageMock.Object);

            //Act & Asser
            Assert.AreEqual(packageMock.Object, sut.MyPackage);
        }

        [Test]
        public void Constructor_ShouldCorrectlySetOperation()
        {
            //Arrange
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            var sut = new MockInstallCommand(installerMock.Object, packageMock.Object);

            //Act & Asser
            Assert.AreEqual(InstallerOperation.Install, installerMock.Object.Operation);
        }
    }
}
