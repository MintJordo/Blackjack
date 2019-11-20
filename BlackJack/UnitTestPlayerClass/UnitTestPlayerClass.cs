using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace UnitTestPlayerClass
{
    [TestClass]
    public class UnitTestPlayerClass
    {
        [TestMethod]
        public void TestPlayerClassInstantiateWithMoney()
        {
            //Arrange
            Player p1;
            int expectedMoney = 100;
            int actualMoney;
            //Act
            p1 = new Player(100);
            actualMoney = p1.getMoney();
            //Assert
            Assert.AreEqual(expectedMoney, actualMoney);
        }

        [TestMethod]
        public void TestPlayerClassAddMoney()
        {
            //Arrange
            Player p1 = new Player(100);
            int expectedMoney = 150;
            int actualMoney;
            //Act
            p1.addMoney(50);
            actualMoney = p1.getMoney();
            //Assert
            Assert.AreEqual(expectedMoney, actualMoney);
        }

        [TestMethod]
        public void TestPlayerClassRemoveMoney()
        {
            //Arrange
            Player p1 = new Player(100);
            int expectedMoney = 50;
            int actualMoney;
            //Act
            p1.takeMoney(50);
            actualMoney = p1.getMoney();
            //Assert
            Assert.AreEqual(expectedMoney, actualMoney);
        }
    }
}
