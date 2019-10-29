﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        private List<Card> cardsInHand;
        int numCardsInHand;

        public Hand()
        {
            cardsInHand = new List<Card>();
            numCardsInHand = 0;
        }

        public void addCard(Card c)
        {
            if(numCardsInHand < 5)
                cardsInHand.Add(c);
        }

        public Card[] show()
        {
            return cardsInHand.ToArray();
        }

        public Boolean aceInHand()
        {
            foreach (Card c in cardsInHand.ToArray())
            {
                if (c.Number == "A")
                    return true;
            }
            return false;
        }

        public int getHandTotal()
        {
            int total = 0;
            foreach (Card c in cardsInHand.ToArray())
            {
                total += Int32.Parse(c.getCardValue());
            }
            if (total > 21)
            {
                if(aceInHand())
                {
                    total -= 10;
                }
            }
            return total;
        }
    }

}
