using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasker.Core.Providers;

namespace Tasker.Test.Core.Provider.IdProviderTests
{
    [TestFixture]
    public class NextIdTests
    {
        [Test]
        public void NextId_ShouldReturn_IncrementedValue_WhenInvoked()
        {
            var sut = new IdProvider();

            var resultOne = sut.NextId();
            var resultTwo = sut.NextId();

            Assert.AreEqual(0, resultOne);
            Assert.AreEqual(1, resultTwo);
        }
    }
}
