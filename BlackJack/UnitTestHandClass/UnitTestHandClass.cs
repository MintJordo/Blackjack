using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace UnitTestHandClass
{
    [TestClass]
    public class UnitTestHandClass
    {
        [TestMethod]
        public void UnitTestAceInHand()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("spade", "A");
            Card c2 = new Card("diamond", "3");
            h1.addCard(c1);
            h1.addCard(c2);

            bool aceInHandExpected = true;
            bool aceInHandActual;

            //act
            aceInHandActual = h1.aceInHand();

            //assert
            Assert.AreEqual(aceInHandExpected, aceInHandActual);
        }

        [TestMethod]
        public void UnitTestAceNotInHand()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("spade", "6");
            Card c2 = new Card("diamond", "3");
            h1.addCard(c1);
            h1.addCard(c2);

            bool aceInHandExpected = false;
            bool aceInHandActual;

            //act
            aceInHandActual = h1.aceInHand();

            //assert
            Assert.AreEqual(aceInHandExpected, aceInHandActual);
        }

        [TestMethod]
        public void UnitTestHandTotalWithOneAce()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("club","7");
            Card c2 = new Card("diamond", "4");
            Card c3 = new Card("heart", "5");
            Card c4 = new Card("spade", "A");
            h1.addCard(c1);
            h1.addCard(c2);
            h1.addCard(c3);
            h1.addCard(c4);
            int expectedTotal = 17;
            int actualTotal;
            //act
            actualTotal = h1.getHandTotal();
            //assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void UnitTestHandTotalWithTwoAces()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("club", "10");
            Card c2 = new Card("spade", "A");
            Card c3 = new Card("diamond", "7");
            Card c4 = new Card("heart", "A");
            
            h1.addCard(c1);
            h1.addCard(c2);
            h1.addCard(c3);
            h1.addCard(c4);
            int expectedTotal = 19;
            int actualTotal;
            //act
            actualTotal = h1.getHandTotal();
            //assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void UnitTestHandTotalWithOneAceOver21()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("club", "10");
            Card c2 = new Card("spade", "A");
            Card c3 = new Card("diamond", "7");
            Card c4 = new Card("heart", "Q");

            h1.addCard(c1);
            h1.addCard(c2);
            h1.addCard(c3);
            h1.addCard(c4);
            int expectedTotal = 28;
            int actualTotal;
            //act
            actualTotal = h1.getHandTotal();
            //assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void UnitTestHandTotalWithOneAceAs11()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("club", "10");
            Card c2 = new Card("spade", "A");

            h1.addCard(c1);
            h1.addCard(c2);
            int expectedTotal = 21;
            int actualTotal;
            //act
            actualTotal = h1.getHandTotal();
            //assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void UnitTestHandTotalWithNoAces()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("club", "10");
            Card c2 = new Card("diamond", "7");
            Card c3 = new Card("heart", "3");

            h1.addCard(c1);
            h1.addCard(c2);
            h1.addCard(c3);
            int expectedTotal = 20;
            int actualTotal;
            //act
            actualTotal = h1.getHandTotal();
            //assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void UnitTestHandTotalJustTwoAces()
        {
            //arrange
            Hand h1 = new Hand();
            Card c1 = new Card("club", "A");
            Card c2 = new Card("diamond", "A");

            h1.addCard(c1);
            h1.addCard(c2);
            int expectedTotal = 12;
            int actualTotal;
            //act
            actualTotal = h1.getHandTotal();
            //assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }
    }
}
