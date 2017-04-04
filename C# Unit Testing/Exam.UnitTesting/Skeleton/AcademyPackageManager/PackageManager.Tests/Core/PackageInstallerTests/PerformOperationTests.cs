using Moq;
using NUnit.Framework;
using PackageManager.Core;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Core.PackageInstallerTests
{
    [TestFixture]
    public class PerformOperationTests
    {
        [Test]
        public void PerformOperation_ShouldCall2TimesDownloadAnd1TimeRemove_WhenInstallPassedAndDependenciesListIsEmpty()
        {
            var downloaderMock = new Mock<IDownloader>();
            var projectMock = new Mock<IProject>();

            var packageMock = new Mock<IPackage>();

            projectMock.Setup(x => x.PackageRepository.GetAll()).Returns(new List<IPackage>());

            packageMock.Setup(x => x.Dependencies).Returns(new List<IPackage>());

            var installer = new PackageInstaller(downloaderMock.Object, projectMock.Object);

            installer.Operation = Enums.InstallerOperation.Install;

            //Act
            installer.PerformOperation(packageMock.Object);

            //Assert
            
            downloaderMock.Verify(x => x.Remove(It.IsAny<string>()), Times.Once);
            downloaderMock.Verify(x => x.Download(It.IsAny<string>()), Times.Exactly(2));

        }

        [Test]
        public void PerformOperation_ShouldMultiplyBy2DownloadAndRemoveCallTimes_WhenInstallPassedAndDependenciesListIsNotEmpty()
        {
            var downloaderMock = new Mock<IDownloader>();
            var projectMock = new Mock<IProject>();

            var packageMock = new Mock<IPackage>();
            var packageDependencyMock = new Mock<IPackage>();

            projectMock.Setup(x => x.PackageRepository.GetAll()).Returns(new List<IPackage>());

            packageDependencyMock.Setup(x => x.Dependencies).Returns(new List<IPackage>());

            packageMock.Setup(x => x.Dependencies).Returns(new List<IPackage>()
            {
                packageDependencyMock.Object
            });

            var installer = new PackageInstaller(downloaderMock.Object, projectMock.Object);

            installer.Operation = Enums.InstallerOperation.Install;

            //Act
            installer.PerformOperation(packageMock.Object);

            //Assert

            downloaderMock.Verify(x => x.Remove(It.IsAny<string>()), Times.Exactly(2));
            downloaderMock.Verify(x => x.Download(It.IsAny<string>()), Times.Exactly(4));

        }


    }
}
