using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.AcademyModelsCourseTests
{
    [TestFixture]
    public class EndingDatePropertyTests
    {
        [Test]
        public void EndingDateProperty_ShouldThrowAnException_WhenInvalidValuePassed()
        {
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));
        }

        [Test]
        public void EndingDateProperty_ShouldNotThrowException_WhenValidValuePassed()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

        }

        [Test]
        public void EndingDateProperty_ShouldAssignValue_WhenValidValueIsPassed()
        {
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));
            var tt = sut.Name;

            Assert.AreEqual("OOP", sut.Name);
        }
    }
}
