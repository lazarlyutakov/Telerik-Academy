using ArmyOfCreatures.Extended.Creatures;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Tests.Fakes;
using Moq;
using NUnit.Framework;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ArmyOfCreatures.Tests.ExtendedTests.CreaturesTests
//{
//    [TestFixture]
//    public class TestCreatures
//    {
//        [TestCase(4, 5, 4, 2)]
//        public void CreatureConstructor_ShouldReturnExpectedAttack(int attack, int defense, int healthPoints, decimal damage)
//        {
//            var sut = new FakeCreature(attack, defense, healthPoints, damage);

//            Assert.AreEqual(attack, sut.Attack);
//        }

//        [TestCase(4, 5, 4, 2)]
//        public void CreatureConstructor_ShouldReturnExpectedDefense(int attack, int defense, int healthPoints, decimal damage)
//        {
//            var sut = new FakeCreature(attack, defense, healthPoints, damage);

//            Assert.AreEqual(defense, sut.Defense);
//        }

//        [TestCase(4, 5, 4, 2)]
//        public void CreatureConstructor_ShouldReturnHealthPoints(int attack, int defense, int healthPoints, decimal damage)
//        {
//            var sut = new FakeCreature(attack, defense, healthPoints, damage);

//            Assert.AreEqual(healthPoints, sut.HealthPoints);
//        }

//        [TestCase(4, 5, 4, 2)]
//        public void CreatureConstructor_ShouldReturnDamage(int attack, int defense, int healthPoints, decimal damage)
//        {
//            var sut = new FakeCreature(attack, defense, healthPoints, damage);

//            Assert.AreEqual(damage, sut.Damage);
//        }

//        [TestCase(4, 5, 4, 2)]
//        public void AddSpeciality_ShouldAddSpeciality_WhenValidValueProvided(int attack, int defense, int healthPoints, decimal damage)
//        {
//            var specialityStub = new Mock<SpecialityFake>();
//            var sut = new FakeCreature(attack, defense, healthPoints, damage);

//            sut.AddSpecialty(specialityStub.Object);

//            Assert.That(() => sut.FakeSpecialties.Contains(specialityStub.Object));
//        }
//    }
//}
