﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
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
            cardsInHand.Add(c);
            numCardsInHand++;
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
            int numAces = 0;
            foreach (Card c in cardsInHand.ToArray())
            {
                total += c.getCardValue();
                if (c.getCardValue() == 11)
                {
                    numAces++;
                }
            }
            while (total > 21 && numAces > 0)
            {
                total -= 10;
                numAces--;
            }
            return total;
        }

        public int getNumCards()
        {
            return cardsInHand.Count();
        }

        public void emptyHand()
        {
            cardsInHand = new List<Card>();
            numCardsInHand = 0;
        }

        public string ToString()
        {
            string r = "";
            foreach (Card c in cardsInHand)
            {
                r = r + c.ToString() + " ";
            }
            return r;
        }
    }

}
