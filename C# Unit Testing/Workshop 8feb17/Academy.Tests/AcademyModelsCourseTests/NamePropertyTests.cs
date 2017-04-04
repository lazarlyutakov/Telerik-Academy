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
    public class NamePropertyTests
    {
        [Test]
        public void NameProperty_ShouldThrowAnException_WhenInvalidValuePassed()
        {
            //var sut = new Course("OP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

            Assert.Throws<ArgumentException>(() => new Course("OP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11)));

        }


        [Test]
        public void NameProperty_ShouldNotThrowException_WhenValidValuePassed()
        {
            //Arrange
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));

            Assert.DoesNotThrow(() => sut.Name = "OOP");

        }

        [Test]
        public void NameProperty_ShouldAssignValue_WhenValidValueIsPassed()
        {
            var sut = new Course("OOP", 2, new DateTime(2016, 10, 10), new DateTime(2016, 11, 11));
            var tt = sut.Name;

            Assert.AreEqual("OOP", sut.Name);
        }

        
    }
}
