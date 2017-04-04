using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Tests.Fakes;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class BattleManagerAttackTests
    {
        [Test]
        public void Attack_ShouldThrowArgumentException_WhenAttackerCreatureIdentifierIsNull()
        {
            //Arrange
            var creaturesFactoryStub = new Mock<ICreaturesFactory>();
            var loggerStub = new Mock<ILogger>();
            var sut = new MockedBattleManager(creaturesFactoryStub.Object, loggerStub.Object);
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Attack(identifier, identifier));
        }

        [Test]
        public void Attack_ShouldThrowArgumentException_WhenDefenderCreatureIdentifierIsNull()
        {
            //Arrange
            var creaturesFactoryStub = new Mock<ICreaturesFactory>();
            var loggerStub = new Mock<ILogger>();
            var sut = new Logic.Battles.BattleManager(creaturesFactoryStub.Object, loggerStub.Object);
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Attack(identifier, identifier));
        }

        [Test]
        public void Attack_WhenAttackIsSuccessfull_ShoulCallWriteLine6Times()
        {
            //Arrange
            var creaturesFactoryStub = new Mock<ICreaturesFactory>();
            var loggerMock = new Mock<ILogger>();
            var sut = new MockedBattleManager(creaturesFactoryStub.Object, loggerMock.Object);

            var identifier1 = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var identifier2 = CreatureIdentifier.CreatureIdentifierFromString("Angel(2)");

            var creature = new Angel();
           
            creaturesFactoryStub.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);
            loggerMock.Setup(x => x.WriteLine(It.IsAny<string>()));


            //Act
            sut.AddCreatures(identifier1, 1);
            sut.AddCreatures(identifier2, 1);
            sut.Attack(identifier1, identifier2);

            //Assert
            loggerMock.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(6));
        }

        //[Test]
        public void Attack_WhenAttackingOwnArmy_ShouldThrow()
        {
            //Arrange
            var mockedfacttory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var mockedCreaturesInBatlle = new Mock<ICreaturesInBattle>();

            var sut = new MockedBattleManager(mockedfacttory.Object, mockedLogger.Object);

            var identifier1 = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var identifier2 = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            var creature = new Angel();

            mockedfacttory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);
            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

            //Act
            sut.AddCreatures(identifier1, 1);
            sut.AddCreatures(identifier2, 1);

            //Assert
            Assert.Throws<ArgumentException>(() => sut.Attack(identifier1, identifier2)); 

        }
    }
}
