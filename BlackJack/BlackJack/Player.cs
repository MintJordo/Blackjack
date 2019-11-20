using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class Player
    {
        private int money;
        public int wager;
        public int insurance;
        public Hand hand;
        public Hand splitHand;
        public List<PictureBox> cardDisplay;
        private string name;

        public Player()
        {
            money = 100;
            hand = new Hand();
            splitHand = new Hand();
            cardDisplay = new List<PictureBox>();
            name = "DBDSC";
        }

        public Player(int m)
        {
            money = m;
            hand = new Hand();
            splitHand = new Hand();
            cardDisplay = new List<PictureBox>();
            name = "DBDSC";
        }

        public Player(int m, string s)
        {
            money = m;
            hand = new Hand();
            splitHand = new Hand();
            cardDisplay = new List<PictureBox>();
            name = s;
        }

        public Player(string s)
        {
            money = 100;
            hand = new Hand();
            splitHand = new Hand();
            cardDisplay = new List<PictureBox>();
            name = s;
            Console.WriteLine("created user with name " + s);
        }

        public void addMoney(int m)
        {
            money += m;
        }

        public void takeMoney(int m)
        {
            money -= m;
        }

        public int getMoney()
        {
            return money;
        }

        public string getName()
        {
            return name;
        }
        
        public void setName(string s)
        {
            name = String.Copy(s);
        }
        
    }
}
