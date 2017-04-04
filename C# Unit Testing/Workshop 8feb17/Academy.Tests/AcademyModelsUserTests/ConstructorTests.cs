using Academy.Tests.Fakes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.AcademyModelsUserTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void UserConstructor_ReturnUserName()
        {
            var sut = new UserFake("GeiLord");

            Assert.AreEqual("GeiLord", sut.Username);
        }
    }
}
