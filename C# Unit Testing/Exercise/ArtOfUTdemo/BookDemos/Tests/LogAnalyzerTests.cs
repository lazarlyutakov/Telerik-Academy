using LogAn;
using NUnit.Framework;
using System;


namespace Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {



        [Test]
        public void Analyze_WebServiceThrows_SendEmail()
        {
            var stubService = new StubService();

            stubService.ToThrow = new Exception("fake exception");

            var mockEmail = new MockEmailService();

            var log = new LogAnalyzer2();

            log.Service = stubService;
            log.Email = mockEmail;

            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            Assert.AreEqual("a", mockEmail.To);
            Assert.AreEqual("fake exception", mockEmail.Body);
            Assert.AreEqual("subject", mockEmail.Subject);
        }



        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            var mockService = new MockService();
            var log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            Assert.AreEqual("Filename too short : abc.ext", mockService.LastError);
        }









        [Test]
        public void IsValidFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
        {
            StubExtensionManager myFakeManager = new StubExtensionManager();

            myFakeManager.ShouldExtensionBeValid = true;

            //create analyzer and inject stub
            var log = new LogAnalyzer(myFakeManager);

            //Assert logic assuming extension is supported

            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsFalse(result, "File name with less than 5 chars should have failed the method, even if the extension is supported");
        }






        [Test]
        public void IsValidFileName_validFile_ReturnsTrue()
        {
            //arrange
            LogAnalyzer analyzer = new LogAnalyzer();
            //act
            bool result = analyzer.IsValidLogFileName("whatever.slf");
            //assert
            Assert.IsTrue(result, "filename should be valid!");
        }

        private LogAnalyzer m_analyzer = null;

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }
        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            bool result =
            m_analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "filename should be valid!");
        }



        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {
            bool result =
m_analyzer.IsValidLogFileName("whatever.SLF");
            Assert.IsTrue(result, "filename should be valid!");
        }
        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }


    }
}
