using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace UnitTestDeckClass
{
    [TestClass]
    public class UnitTestDeckClass
    {
        [TestMethod]
        public void UnitTestGetCardRepeatedlyFromDeck()
        {
            //arrange
            Deck d = new Deck();
            Card c1;
            Card c2;
            Card c3;
            Card c4;
            Card c5;
            //act
            c1 = d.getCard();
            c2 = d.getCard();
            c3 = d.getCard();
            c4 = d.getCard();
            c5 = d.getCard();
            //assert
            Assert.AreNotEqual(c1, c2);
            Assert.AreNotEqual(c1, c3);
            Assert.AreNotEqual(c1, c4);
            Assert.AreNotEqual(c1, c5);

            Assert.AreNotEqual(c2, c3);
            Assert.AreNotEqual(c2, c4);
            Assert.AreNotEqual(c2, c5);

            Assert.AreNotEqual(c3, c4);
            Assert.AreNotEqual(c3, c5);

            Assert.AreNotEqual(c4, c5);
        }

        [TestMethod]
        public void UnitTestGetCardFromDeckThenShuffleAndRedraw()
        {
            //this test may fail on rare occasion but is unlikely
            //arrange
            Deck d = new Deck();
            Card c1, c6;
            Card c2, c7;
            Card c3, c8;
            Card c4, c9;
            Card c5, c10;
            //act
            c1 = d.getCard();
            c2 = d.getCard();
            c3 = d.getCard();
            c4 = d.getCard();
            c5 = d.getCard();

            d.shuffle();

            c6 = d.getCard();
            c7 = d.getCard();
            c8 = d.getCard();
            c9 = d.getCard();
            c10 = d.getCard();

            //assert
            Assert.AreNotEqual(c1, c6);
            Assert.AreNotEqual(c2, c7);
            Assert.AreNotEqual(c3, c8);
            Assert.AreNotEqual(c4, c8);
            Assert.AreNotEqual(c5, c10);
        }
    }
}
