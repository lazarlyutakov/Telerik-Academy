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
    public class MinorPropertyTests
    {
        [Test]
        public void MinorProperty_ShouldThrowArgumentException_WhenInvalidValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new MockPackageVersion(major, minor, patch, versionType);

            int invalidValue = -2;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Minor = invalidValue);
        }

        [Test]
        public void MinorProperty_ShouldNotThrowAnyExceptions_WhenValidValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new MockPackageVersion(major, minor, patch, versionType);

            //Act & Assert
            Assert.DoesNotThrow(() => sut.Minor = minor);
        }
    }
}
