using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasker.Models;

namespace Tasker.Test.Models.TaskTests
{
    [TestFixture]
    public class CtorTests
    {
        public void Ctor_ShouldAssignDescription_WhenInvoked()
        {
            var expected = "Valid Description";
            var sut = new Task(expected);

            Assert.AreEqual(expected, sut.Description);
        }
    }
}
