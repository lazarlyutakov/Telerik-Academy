using System;

using NUnit.Framework;
using Tasker.Models;

namespace Tasker.Test.Models.TaskTests
{

   [TestFixture]
   public class DescriptionTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("    ")]
        public void Description_ShouldThrowArgumentNullException_WhenPassedNullOrEmptyValue(string value)
        {
            var sut = new Task("Valid Description");

            Assert.Throws<ArgumentNullException>(() => sut.Description = value);
        }
        
    }
}
