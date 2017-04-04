using System;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using Moq;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class BattkeManagerAddCreatureTests
    {
        [Test]
        public void AddCreatures_WhenCreatureIdentifierIsNill_ShouldThrowArgumentNullException()
        {
            var creaturesFactoryStub = new Mock<ICreaturesFactory>();
            var loggerStub = new Mock<ILogger>();
            var sut = new Logic.Battles.BattleManager(null, loggerStub.Object);

            Assert.Throws<ArgumentNullException>(() => sut.AddCreatures(null, 1));
        }

        [Test]
        public void AddCreatures_WhenValidIdentifierPassed_FactoryShouldCallCreateCreature()
        {
            //Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            //  VARANT S FIXTURE - SYZDAVA INSTANCIQ NA ABSTRAKTEN KLAS !

            //var fixture = new Fixture();

            //fixture.Customizations.Add(
            //    new TypeRelay(
            //        typeof(Creature),
            //        typeof(Angel)));

            // var creature = fixture.Create<Creature>();






            var creature = new Angel();

            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            //Act
            battleManager.AddCreatures(identifier, 1);

            //Assert
            mockedFactory.Verify(x => x.CreateCreature(It.IsAny<string>()), Times.Exactly(1));

        }

        [Test]
        public void AddCreature_WhenValidIdentifierIsPassed_WriteLineShouldBeCalled()
        {
            //Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);

            //var fixture = new Fixture();

            //fixture.Customizations.Add(
            //    new TypeRelay(
            //        typeof(Creature),
            //        typeof(Angel)));

            //var cerature = fixture.Create<Creature>();

            var creature = new Angel();
            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            //Act
            battleManager.AddCreatures(identifier, 1);

            //Assert
            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(1));
        }

    }
}
