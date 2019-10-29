using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    class Player
    {
        private int money;
        public Hand hand;
        public PictureBox[] cardDisplay;
        private string name;

        public Player()
        {
            money = 100;
            hand = new Hand();
            name = "DBDSC";
        }

        public Player(int m)
        {
            money = m;
            hand = new Hand();
            name = "DBDSC";
        }

        public Player(int m, string s)
        {
            money = m;
            hand = new Hand();
            name = s;
        }

        public Player(string s)
        {
            money = 100;
            hand = new Hand();
            name = s;
        }

        void addMoney(int m)
        {
            money += m;
        }

        void takeMoney(int m)
        {
            money -= m;
        }
    }
}
