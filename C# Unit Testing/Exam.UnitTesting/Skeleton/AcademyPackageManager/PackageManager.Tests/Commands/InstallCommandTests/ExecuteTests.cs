using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
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
    public class ExecuteTests
    {
        [Test]
        public void Execute_ShouldCallOperationFromInstaller()
        {
 
            //Arrange
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            var sut = new MockInstallCommand(installerMock.Object, packageMock.Object);

            //Act
            sut.Execute();

            //Assert
            installerMock.Verify(x => x.PerformOperation(packageMock.Object), Times.Once);
        }
    }

    }

