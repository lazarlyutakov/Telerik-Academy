using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using PackageManager.Tests.Models.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests.PropertiesTests
{
    [TestFixture]
    public class MajorPropertyTests
    {
        [Test]
        public void MajorProperty_ShouldThrowArgumentException_WhenInvalidValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new MockPackageVersion(major, minor, patch, versionType);

            int invalidValue = -2;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Major = invalidValue);
        }

        [Test]
        public void MajorProperty_ShouldNotThrowAnyExceptions_WhenValidValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new MockPackageVersion(major, minor, patch, versionType);

            //Act & Assert
            Assert.DoesNotThrow(() => sut.Major = major);
        }
    }
}
