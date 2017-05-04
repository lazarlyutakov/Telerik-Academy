using System;
using System.Linq;
using Moq;
using NUnit.Framework;
using SchoolSystem.Core;
using SchoolSystem.Core.Contracts;

namespace SchoolSystemTests.Core
{
    [TestFixture]
    public class EngineTests
    {
        [Test]
        public void Constructor_ShouldReturnInstanceOfEngine_WhenApplicableValuesPassed()
        {
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            var engine = new Engine(readerMock.Object, writerMock.Object, parserMock.Object);

            Assert.IsInstanceOf<Engine>(engine);
        }

        [Test]
        public void Constructor_ShoultThrowArgumentNullException_WhenReaderParameterInNull()
        {
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            Assert.Throws<ArgumentNullException>(() => new Engine(null, writerMock.Object, parserMock.Object));
        }

        [Test]
        public void Constructor_ShoultThrowArgumentNullException_WhenWriterParameterInNull()
        {
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            Assert.Throws<ArgumentNullException>(() => new Engine(readerMock.Object, null, parserMock.Object));
        }

        [Test]
        public void Constructor_ShoultThrowArgumentNullException_WhenParserParameterInNull()
        {
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            Assert.Throws<ArgumentNullException>(() => new Engine(readerMock.Object, writerMock.Object, null));
        }

        [Test]
        public void StartMethod_ShouldTerminateProcess_WhenEndTerminationWordEncountered()
        {
            string terminationWord = "End";

            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            var engine = new Engine(readerMock.Object, writerMock.Object, parserMock.Object);

            readerMock.Setup(r => r.Read()).Returns(terminationWord);

            engine.Start();
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        public void StartMethod_ShouldCallParseCommand_WhenPasseApplicableParameters(string command)
        {
            string terminationWord = "End";

            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            var engine = new Engine(readerMock.Object, writerMock.Object, parserMock.Object);

            readerMock.SetupSequence(r => r.Read()).Returns(command)
                                                   .Returns(terminationWord);

            engine.Start();

            parserMock.Verify(p => p.ParseCommand(It.IsAny<string>()), Times.Once);
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        public void StartMethod_ShouldCallParseParameters_WhenPasseApplicableParameters(string command)
        {
            string terminationWord = "End";

            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            var engine = new Engine(readerMock.Object, writerMock.Object, parserMock.Object);

            readerMock.SetupSequence(r => r.Read()).Returns(command)
                                                   .Returns(terminationWord);

            engine.Start();

            parserMock.Verify(p => p.ParseParameters(It.IsAny<string>()), Times.Once);
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        public void StartMethod_ShouldCallWriteLine_WhenPasseApplicableParameters(string command)
        {
            string terminationWord = "End";

            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();

            var engine = new Engine(readerMock.Object, writerMock.Object, parserMock.Object);

            readerMock.SetupSequence(r => r.Read()).Returns(command)
                                                   .Returns(terminationWord);

            engine.Start();

            writerMock.Verify(w => w.WriteLine(It.IsAny<string>()), Times.Once);
        }

        [TestCase("CreateStudent Pesho Peshev 1")]
        [TestCase("CreateTeacher Gosho Vesheff 2")]
        public void StartMethod_ShouldExecuteProcessCommand_WhenApplicableParametersPassed(string command)
        {
            string terminationWord = "End";

            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();
            var commandMock = new Mock<ICommand>();

            var engine = new Engine(readerMock.Object, writerMock.Object, parserMock.Object);

            var commandParameters = command.Split(' ').ToList();
            commandParameters.RemoveAt(0);

            readerMock.SetupSequence(r => r.Read()).Returns(command)
                                                   .Returns(terminationWord);

            parserMock.Setup(p => p.ParseCommand(command)).Returns(commandMock.Object);
            parserMock.Setup(p => p.ParseParameters(command)).Returns(commandParameters);

            engine.Start();

            commandMock.Verify(c => c.Execute(commandParameters), Times.Once);
        }
    }
}
