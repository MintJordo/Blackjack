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

        Deck deck = new Deck();

        Hand myHand = new Hand();
        Hand dealerHand = new Hand();
        int playerMoney = 100;

        PictureBox[] dealerHandCardPictures = new PictureBox[5];
        PictureBox[] player1HandCardPictures = new PictureBox[5];


        public Form1()
        {
            InitializeComponent();
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
            myHand.addCard(deck.getCard());

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
    }
}
