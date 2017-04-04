using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class PackageVersionConstructorTests
    {
        [Test]
        public void Constructor_ShouldSetUpMajor_WhenProperValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new PackageVersion(major, minor, patch, versionType);

            //Act & Assert
            Assert.AreEqual(major, sut.Major);
        }

        [Test]
        public void Constructor_ShouldSetUpMinor_WhenProperValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new PackageVersion(major, minor, patch, versionType);

            //Act & Assert
            Assert.AreEqual(minor, sut.Minor);
        }

        [Test]
        public void Constructor_ShouldSetUpPatch_WhenProperValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new PackageVersion(major, minor, patch, versionType);

            //Act & Assert
            Assert.AreEqual(patch, sut.Patch);
        }

        [Test]
        public void Constructor_ShouldSetUpVersionType_WhenProperValuePassed()
        {
            //Arrange
            int major = 5;
            int minor = 1;
            int patch = 2;
            var versionType = VersionType.alpha;

            var sut = new PackageVersion(major, minor, patch, versionType);

            //Act & Assert
            Assert.AreEqual(versionType, sut.VersionType);
        }
    }
}
