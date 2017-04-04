using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasker.Models;

namespace Tasker.Test.Models.TaskTests
{
    [TestFixture]
    public class IdTests
    {
        [TestCase(-1)]
        [TestCase(-10)]
        public void Id_ShouldThrowArgumentException_WhenPassedValueInInvalidRange(int value)
        {

            //Arrange
            var sut = new Task("Valid Description");

            //Act && Assert
            Assert.Throws<ArgumentException>(() => sut.Id = value);
        }

        [TestCase(1)]
        [TestCase(10)]
        public void Id_ShouldSetPassedValue_WhenPassedValueIsValid(int value)
        {
            //arrange
            var sut = new Task("Valid Description");

            //Act
            sut.Id = value;

            //Assert
            Assert.AreEqual(value, sut.Id);

        }

        [TestCase(1)]
        [TestCase(10)]
        public void Id_ShouldNotThrowArgumentException_WhenPassedValueInInvalidRange(int value)
        {

            //Arrange
            var sut = new Task("Valid Description");

            //Act && Assert
            Assert.DoesNotThrow(() => sut.Id = value);
        }
    }
}
