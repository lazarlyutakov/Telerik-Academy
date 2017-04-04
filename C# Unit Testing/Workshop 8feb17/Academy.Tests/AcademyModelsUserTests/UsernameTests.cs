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
    public class UsernameTests
    {
        [Test]
        public void Username_ShouldThrowException_WhenInvalidValuePassed()
        {
            var sut = new UserFake("OnqOtVraca");

            
        }
    }
}
