using Moq;
using NUnit.Framework;
using SchoolSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests.MarkTests
{
    [TestFixture]
    public class MarkConstructorAndPropertiesTests
    {
        [Test]
        public void Constructor_ShouldNotThrowException_WhenValidValueOfMarkPassed()
        {
            // Arrange
            float validMarkValue = 4.5f;

            // Act & Assert
            Assert.DoesNotThrow(() => new Mark(Enums.Subject.Bulgarian, validMarkValue));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenIvalidalueOfMarkPassed()
        {
            // Arrange
            float validMarkValue = 1.5f;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Mark(Enums.Subject.Bulgarian, validMarkValue));
        }

        [Test]
        public void PropertyValueGet_ShouldGetTheCorrectValue()
        {
            // Arrange
            float validMark = 4.5f;

            var mark = new Mark(Enums.Subject.Bulgarian, validMark);

            // Act
            float result = (float)mark.Value;

            // Assert
            Assert.AreEqual(validMark, result);
        }

        [Test]
        public void PropertyValueSet_ShouldSetTheCorrectValue()
        {
            // Arrange
            float validMark = 4.5f;

            var mark = new Mark(Enums.Subject.Bulgarian, validMark);

            // Act
            mark.Value = 5.5f;
            var result = mark.Value;
            var expectedOutput = 5.5f;

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
