using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Tests.Models.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests.PropertiesTests
{
    [TestFixture]
    public class VersionTypePropertyTests
    {
        //[Test]
        public void VersionTypeProperty_ShouldThrowArgumentException_WhenInvalidValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new MockPackageVersion(major, minor, patch, versionType);

            //Act & Assert
            //Assert.Throws<ArgumentException>(() => typeof(sut.VersionType) != typeof(VersionType));
        }

        [Test]
        public void VersiontypeProperty_ShouldNotThrowAnyExceptions_WhenValidValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new MockPackageVersion(major, minor, patch, versionType);

            //Act & Assert
            Assert.DoesNotThrow(() => sut.VersionType = versionType);
        }
    }
}
