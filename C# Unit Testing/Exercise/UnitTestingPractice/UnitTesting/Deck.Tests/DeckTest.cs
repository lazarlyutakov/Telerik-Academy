using System;


namespace Deck.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;
    using SantaseLogic;
    using SantaseLogic.Cards;
    using Moq;

    [TestFixture]
    public class DeckTests
    {

        [Test]
        public void DeckConstructor_TrumpCard_ShouldNotBeNull()
        {
            var deck = new Deck();

            Assert.IsNotNull(deck.TrumpCard);
        }

        [Test]
        public void CardsLeft_ShouldBe24()
        {
            var deck = new Deck();

            Assert.AreEqual(deck.CardsLeft, 24);
        }

        [Test]
        public void GetNextCard_AfterLastCardIsDrown_ShouldThrowAnException()
        {
            var deck = new Deck();

            for (int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        public void GetNextCard_After24CardsAreDrownd_ShouldBeLeft0Cards()
        {
            var deck = new Deck();

            for (int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(deck.CardsLeft, 0);
        }

        [TestCase(5, 24 - 5)]
        [TestCase(10, 24 - 10)]
        [TestCase(15, 24 - 15)]
        public void GetNextCard_CardsLeft_ShouldDecreaseNTimesAfterNDraws(int draws, int ecpectedCadrsLeft)
        {
            var deck = new Deck();
            
            for (int i = 0; i < draws; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(ecpectedCadrsLeft, deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_ShouldNotReturnNullCard()
        {
            var deck = new Deck();

            Assert.IsFalse(deck.GetNextCard() == null);
        }

        [Test]
        public void ChangeTrumpcard_ShouldChangeTrumpCardCorrectly()
        {
            var deck = new Deck();
            Card newTrumpCard = Card.GetCard(CardSuit.Heart, CardType.Jack);
            deck.ChangeTrumpCard(newTrumpCard);
            Card changedtrumpCard = deck.TrumpCard;

            Assert.AreEqual(newTrumpCard, changedtrumpCard);
        }

        [Test]
        public void ChangeTrumpCard_LastCardOfDeck_ShouldBeTheTrumpCard()
        {
            var deck = new Deck();
            Card newTrumpCard = new Card(CardSuit.Spade, CardType.Nine);
            deck.ChangeTrumpCard(newTrumpCard);
            int cardsCount = deck.CardsLeft;

            for (int i = 0; i < cardsCount - 1; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(newTrumpCard, deck.GetNextCard());
        }




    }

}

