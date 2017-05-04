using System;
using NUnit.Framework;
using SchoolSystem.Enums;
using ScoolSystem.Models;

namespace SchoolSystemTests.Models
{
    [TestFixture]
    public class MarkTests
    {
        [Test]
        public void Constructor_ShouldReturnInstanceOfMark_WhenProperValuesPassed()
        {
            var mark = new Mark(Subject.Bulgarian, 4);

            Assert.IsInstanceOf<Mark>(mark);
        }

        [Test]
        public void Constructor_SHouldSetCorrectValueOfSubject_WhenValidParameterPassed()
        {
            var validValue = Subject.Bulgarian;
            var mark = new Mark(Subject.Bulgarian, 4);

            Assert.AreEqual(validValue, mark.Subject);
        }

        [Test]
        public void Constructor_SHouldSetCorrectValueOfMarkValue_WhenValidParameterPassed()
        {
            var validValue = 4;
            var mark = new Mark(Subject.Bulgarian, 4);

            Assert.AreEqual(validValue, mark.MarkValue);
        }

        [TestCase(1)]
        [TestCase(8)]
        public void Constructor_ShouldThrowArgumentOutOfRangeException_WhenInvalidValuePassed(float invalidValue)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Mark(Subject.Bulgarian, invalidValue));
        }
    }
}
