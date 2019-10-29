using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        Deck deck;
        Player player1;
        Player dealer;


        public void updatePlayerHandPictureBox()
        {
            if (player1.hand.show().Length >= 1)
            {
                myHand1.Visible = true;
                myHand1.BackgroundImage = Image.FromFile(player1.hand.show()[0].getCardPath());
            }
            if (player1.hand.show().Length >= 2)
            {
                myHand2.Visible = true;
                myHand2.BackgroundImage = Image.FromFile(player1.hand.show()[1].getCardPath());
            }
            if (player1.hand.show().Length >= 3)
            {
                myHand3.Visible = true;
                myHand3.BackgroundImage = Image.FromFile(player1.hand.show()[2].getCardPath());
            }
            if (player1.hand.show().Length >= 4)
            {
                myHand4.Visible = true;
                myHand4.BackgroundImage = Image.FromFile(player1.hand.show()[3].getCardPath());
            }
            if (player1.hand.show().Length == 5)
            {
                myHand5.Visible = true;
                myHand5.BackgroundImage = Image.FromFile(player1.hand.show()[4].getCardPath());
            }
        }


        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            player1 = new Player();
            dealer = new Player();
            dealerHand1.Visible = false;
            dealerHand2.Visible = false;
            dealerHand3.Visible = false;
            dealerHand4.Visible = false;
            dealerHand5.Visible = false;

            myHand1.Visible = false;
            myHand2.Visible = false;
            myHand3.Visible = false;
            myHand4.Visible = false;
            myHand5.Visible = false;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void myHand1_Click(object sender, EventArgs e)
        {

        }

        private void dealerHand2_Click(object sender, EventArgs e)
        {

        }

        private void myTotal_Click(object sender, EventArgs e)
        {

        }

        private void moneyLabel_Click(object sender, EventArgs e)
        {

        }



        private void hitButton_Click(object sender, EventArgs e)
        {
            player1.hand.addCard(deck.getCard());
            updatePlayerHandPictureBox();

        }

        private void standButton_Click(object sender, EventArgs e)
        {

        }

        private void incBet_Click(object sender, EventArgs e)
        {

        }

        private void decBet_Click(object sender, EventArgs e)
        {

        }

        private void moneyBal_Click(object sender, EventArgs e)
        {

        }

        private void dealerHand1_Click(object sender, EventArgs e)
        {

        }

        private void deckCard_Click(object sender, EventArgs e)
        {

        }

        private void dealerTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void dealerTotalVal_Click(object sender, EventArgs e)
        {

        }

        private void myTotalVal_Click(object sender, EventArgs e)
        {

        }

        private void betLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myHand2_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand5_Click(object sender, EventArgs e)
        {

        }

        private void MyCard5_Click(object sender, EventArgs e)
        {

        }
    }
}
