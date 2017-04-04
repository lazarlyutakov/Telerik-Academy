using AnimalHierarchy;
using NUnit.Framework;
using System;
using System.IO;

namespace TestAnimalHierarchy
{
    [TestFixture]
    public class TestKitten
    {
        [Test]
        public void AnimalSound_Should_LogToConsole_WhenInvoked()
        {
            //Arrange
            var message = "Meooow, meooww..";
            var sut = new Kitten("penka", 2, "female");

            var outputStream = new StringWriter();
            var defaultStream = Console.Out;
            Console.SetOut(outputStream);

            //Act
            sut.AnimalSound();

            //Assert
            Assert.AreEqual(message + Environment.NewLine, outputStream.ToString());
            Console.SetOut(defaultStream);
        }

        [Test]
        public void KittenConstructor_ShouldReturnExpectedname()
        {
            string expectedName = "penka";
            var sut = new Kitten("penka", 2, "female");

            Assert.AreEqual(expectedName, sut.Name);
    
        }

        [Test]
        public void KittenConstructor_ShouldReturnExpectedAge()
        {
            int expectedAge = 2;
            var sut = new Kitten("penka", 2, "female");

            Assert.AreEqual(expectedAge, sut.Age);

        }

        [Test]
        public void KittenConstructor_ShouldReturnExpectedGender()
        {
            string expectedGender = "female";
            var sut = new Kitten("penka", 2, "female");

            Assert.AreEqual(expectedGender, sut.Gender);

        }

        [Test]
        public void KittenGenderProperty_ShouldThrowAnException_WhenGenderIsNotFemale()
        {
            var sut = new Kitten("penka", 2, "male");

            Assert.Throws<ArgumentException>(() => sut.Gender.Equals("male"));
            


        }
    }
}
