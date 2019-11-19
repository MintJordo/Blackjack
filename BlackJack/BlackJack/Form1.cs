using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using Microsoft.VisualBasic;

namespace BlackJack
{
    public partial class Form1 : Form
    {


        //import for rounded corners and code to make it happen
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        // begin game variable
        Deck deck;
        Player player1;
        Player dealer;
        int betInc = 5;
        string cardBackFileLocation = @"..\..\..\..\cards\red_back.png";
        public bool Timerbool = true;

        public void updatePlayerHandPictureBox()
        {
            if (player1.hand.show().Length >= 1)
            {
                myHand1.Visible = true;
                myHand1.BackgroundImage = Image.FromFile(player1.hand.show()[0].getCardPath());
                myHand1.BringToFront();
            }
            if (player1.hand.show().Length >= 2)
            {
                myHand2.Visible = true;
                myHand2.BackgroundImage = Image.FromFile(player1.hand.show()[1].getCardPath());
                myHand2.BringToFront();
            }
            if (player1.hand.show().Length >= 3)
            {
                myHand3.Visible = true;
                myHand3.BackgroundImage = Image.FromFile(player1.hand.show()[2].getCardPath());
                myHand3.BringToFront();
            }
            if (player1.hand.show().Length >= 4)
            {
                myHand4.Visible = true;
                myHand4.BackgroundImage = Image.FromFile(player1.hand.show()[3].getCardPath());
                myHand4.BringToFront();
            }
            if (player1.hand.show().Length == 5)
            {
                myHand5.Visible = true;
                myHand5.BackgroundImage = Image.FromFile(player1.hand.show()[4].getCardPath());
                myHand5.BringToFront();
            }
        }

        public void updateDealerHandPictureBox()
        {
            if (dealer.hand.show().Length >= 1)
            {
                dealerHand1.Visible = true;
                dealerHand1.BackgroundImage = Image.FromFile(dealer.hand.show()[0].getCardPath());
                dealerHand1.BringToFront();
            }
            if (dealer.hand.show().Length >= 2)
            {
                dealerHand2.Visible = true;
                dealerHand2.BackgroundImage = Image.FromFile(cardBackFileLocation);
                dealerHand2.BringToFront();
            }
            if (dealer.hand.show().Length >= 3)
            {
                dealerHand3.Visible = true;
                dealerHand3.BackgroundImage = Image.FromFile(cardBackFileLocation);
                dealerHand3.BringToFront();
            }
            if (dealer.hand.show().Length >= 4)
            {
                dealerHand4.Visible = true;
                dealerHand4.BackgroundImage = Image.FromFile(cardBackFileLocation);
                dealerHand4.BringToFront();
            }
            if (dealer.hand.show().Length == 5)
            {
                dealerHand5.Visible = true;
                dealerHand5.BackgroundImage = Image.FromFile(cardBackFileLocation);
                dealerHand5.BringToFront();
            }
        }

        public void showDealerCards()
        {
            if (dealer.hand.show().Length >= 1)
            {
                dealerHand1.Visible = true;
                dealerHand1.BackgroundImage = Image.FromFile(dealer.hand.show()[0].getCardPath());
                dealerHand1.BringToFront();
            }
            if (dealer.hand.show().Length >= 2)
            {
                dealerHand2.Visible = true;
                dealerHand2.BackgroundImage = Image.FromFile(dealer.hand.show()[1].getCardPath());
                dealerHand2.BringToFront();
            }
            if (dealer.hand.show().Length >= 3)
            {
                dealerHand3.Visible = true;
                dealerHand3.BackgroundImage = Image.FromFile(dealer.hand.show()[2].getCardPath());
                dealerHand3.BringToFront();
            }
            if (dealer.hand.show().Length >= 4)
            {
                dealerHand4.Visible = true;
                dealerHand4.BackgroundImage = Image.FromFile(dealer.hand.show()[3].getCardPath());
                dealerHand4.BringToFront();
            }
            if (dealer.hand.show().Length == 5)
            {
                dealerHand5.Visible = true;
                dealerHand5.BackgroundImage = Image.FromFile(dealer.hand.show()[4].getCardPath());
                dealerHand5.BringToFront();
            }
        }

        public void endGame()
        {
            showDealerCards();
            dealerTotalVal.Text = dealer.hand.getHandTotal().ToString();
            if (player1.hand.getNumCards() == 5)
            {
                player1.addMoney(player1.wager * 2);
            }
            if (player1.hand.getHandTotal() <= 21 && dealer.hand.getHandTotal() <= 21 && player1.hand.getHandTotal() > dealer.hand.getHandTotal())
            {
                player1.addMoney(player1.wager * 2);
            }
            if (dealer.hand.getHandTotal() > 21 && player1.hand.getHandTotal() <= 21)
            {
                player1.addMoney(player1.wager * 2);
            }
            if (player1.hand.getHandTotal() == dealer.hand.getHandTotal())
            {
                player1.addMoney(player1.wager);
            }
            if (dealer.hand.getHandTotal() == 21 && dealer.hand.show().Length == 2)
            {
                player1.addMoney(player1.insurance * 2 + player1.insurance);
            }
            player1.wager = 0;
            player1.insurance = 0;
            insuranceLabel.Visible = false;
            betLabel.Text = "Bet: $0";
            moneyBal.Text = "$" + player1.getMoney().ToString();

            standButton.Visible = false;
            hitButton.Visible = false;
            dealButton.Visible = false;
            insuranceIncBet.Visible = false;
            insuranceDecBet.Visible = false;
            incBet.Visible = true;
            decBet.Visible = true;

            player1.hand.emptyHand();
            dealer.hand.emptyHand();

            testButton.Visible = true;
            //timer Code
            BetTimer.Enabled = true;
            blinkPanel.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);


            deck.shuffle();
        }

        /* This function intercepts all the commands sent to the application. 
            It checks to see of the message is a mouse click in the application. 
            It passes the action to the base action by default. It reassigns 
            the action to the title bar if it occured in the client area
            to allow the drag and move behavior.
        */
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public void makeLogin()
        {
            GamePanel.Visible = false;
            SignInPanel.Visible = false;
            forgotPanel.Visible = false;
            newPassPanel.Visible = false;
            incorrectLabel.Visible = false;
            testButton.Visible = false;

            SignUpPanel.BackColor = Color.FromArgb(0, 25, 50);
            SignInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);
            this.BackColor = Color.FromArgb(0, 25, 50);
            underSignUp.BackColor = Color.FromArgb(74, 154, 122);
            FirstNameBox.BackColor = Color.FromArgb(0, 25, 50);
            UserNameBox.BackColor = Color.FromArgb(0, 25, 50);
            addressBox.BackColor = Color.FromArgb(0, 25, 50);
            phoneBox.BackColor = Color.FromArgb(0, 25, 50);
            ccBox.BackColor = Color.FromArgb(0, 25, 50);
            PasswordBox.BackColor = Color.FromArgb(0, 25, 50);
            SignUpConfirm.BackColor = Color.FromArgb(74, 154, 122);
            SignUpConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);

            //changePassword
            Password1.BackColor = Color.FromArgb(0, 25, 50);
            Password2.BackColor = Color.FromArgb(0, 25, 50);
            setPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);
            setPassword.BackColor = Color.FromArgb(74, 154, 122);

            //forgotPassPanel
            verifyNum.BackColor = Color.FromArgb(0, 25, 50);
            verifyUsername.BackColor = Color.FromArgb(0, 25, 50);
            verifyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);
            verifyButton.BackColor = Color.FromArgb(74, 154, 122);

            SignUpPanel.Visible = true;
            SignUpPanel.Location = new Point(209, 34);

        }
        public void goToLogin()
        {

            SignUpPanel.Visible = false;
            GamePanel.Visible = false;
            forgotPanel.Visible = false;

            SignInPanel.BackColor = Color.FromArgb(0, 25, 50);
            SignUpButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);
            this.BackColor = Color.FromArgb(0, 25, 50);
            underSignIn2.BackColor = Color.FromArgb(74, 154, 122);
            UserNameBox2.BackColor = Color.FromArgb(0, 25, 50);
            passwordBox2.BackColor = Color.FromArgb(0, 25, 50);
            SignInConfirm.BackColor = Color.FromArgb(74, 154, 122);
            SignInConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);

            SignInPanel.Visible = true;
            SignInPanel.Location = new Point(209, 34);

        }
        public void forgotPass()
        {
            SignInPanel.Visible = false;
            forgotPanel.Visible = true;
            forgotPanel.Location = new Point(209, 34);
        }
        public void newPass()
        {
            newPassPanel.Visible = true;
            forgotPanel.Visible = false;
            newPassPanel.Location = new Point(209, 34);
        }
        public void LaunchGame()
        {

            // Check right here if login is correct
            string entered_username = UserNameBox2.Text;
            string entered_password = passwordBox2.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load("Players.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string username = node.Attributes[0].InnerText;
                string password = node.ChildNodes[1].InnerText;
                Console.WriteLine(username);
                if (entered_username == username && entered_password == password)
                {
                    SignUpPanel.Visible = false;
                    SignInPanel.Visible = false;
                    forgotPanel.Visible = false;
                    newPassPanel.Visible = false;
                    testButton.Visible = true;
                    GamePanel.Visible = true;
                    GamePanel.Location = new Point(13, 13);
                    this.BackColor = Color.Green;
                }
                else
                {
                    incorrectLabel.Visible = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            makeLogin();

            this.Size = new Size(800, 450);
            //Timer Code
            BetTimer.Start();
            BetTimer.Enabled = true;

            //Get rounded corners on the form
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            moneyBal.Text = System.IO.File.ReadAllText(@"..\..\..\Money.txt");
            if (moneyBal.Text == "$0")
            {
                moneyBal.Text = "$100";
            }

            //Hide Deal Button until bet
            dealButton.Visible = false;

            hitButton.Visible = false;
            standButton.Visible = false;

            dealerTotalLabel.Visible = false;
            dealerTotalVal.Visible = false;

            myTotalLabel.Visible = false;
            myTotalVal.Visible = false;

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

        public void startGame()
        {
            //Timer Code
            BetTimer.Enabled = false;
            blinkPanel.BackColor = System.Drawing.Color.DarkGreen;

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

            player1.hand.addCard(deck.getCard());
            dealer.hand.addCard(deck.getCard());
            player1.hand.addCard(deck.getCard());
            dealer.hand.addCard(deck.getCard());

            dealButton.Visible = false;
            splitButton.Visible = false;
            insuranceButton.Visible = false;
            hitButton.Visible = true;
            standButton.Visible = true;
            dealerTotalLabel.Visible = true;
            dealerTotalVal.Visible = true;
            myTotalLabel.Visible = true;
            myTotalVal.Visible = true;
            incBet.Visible = false;
            decBet.Visible = false;
            insuranceIncBet.Visible = false;
            insuranceDecBet.Visible = false;
            insuranceLabel.Visible = false;

            dealerTotalVal.Text = "?";

            updatePlayerHandPictureBox();
            updateDealerHandPictureBox();
            myTotalVal.Text = player1.hand.getHandTotal().ToString();

            if (player1.hand.show()[0].Number == player1.hand.show()[1].Number)
            {
                splitButton.Visible = true;
            }
            if (dealer.hand.show()[0].Number == "A")
            {
                insuranceButton.Visible = true;
            }
        }
        public void startGame2(Card a, Card b, Card c, Card d)
        {
            //Timer Code
            BetTimer.Enabled = false;
            blinkPanel.BackColor = System.Drawing.Color.DarkGreen;

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

            player1.hand.addCard(c);
            dealer.hand.addCard(a);
            player1.hand.addCard(d);
            dealer.hand.addCard(b);

            dealButton.Visible = false;
            splitButton.Visible = false;
            hitButton.Visible = true;
            standButton.Visible = true;
            dealerTotalLabel.Visible = true;
            dealerTotalVal.Visible = true;
            myTotalLabel.Visible = true;
            myTotalVal.Visible = true;
            incBet.Visible = false;
            decBet.Visible = false;
            testButton.Visible = false;

            dealerTotalVal.Text = "?";

            updatePlayerHandPictureBox();
            updateDealerHandPictureBox();
            myTotalVal.Text = player1.hand.getHandTotal().ToString();

            if (player1.hand.show()[0].Number == player1.hand.show()[1].Number)
            {
                splitButton.Visible = true;
            }
            if (dealer.hand.show()[0].Number == "A" || dealer.hand.show()[0].Number == "a")
            {
                insuranceButton.Visible = true;
            }
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
            splitButton.Visible = false;
            insuranceButton.Visible = false;
            if (player1.hand.getNumCards() < 5)
            {
                player1.hand.addCard(deck.getCard());
                updatePlayerHandPictureBox();
                myTotalVal.Text = player1.hand.getHandTotal().ToString();
                if (player1.hand.getHandTotal() > 21)
                {
                    if (dealer.hand.getHandTotal() < 17)
                    {
                        System.Threading.Thread.Sleep(500);
                        dealer.hand.addCard(deck.getCard());
                        updateDealerHandPictureBox();
                    }
                    endGame();

                }
            }
            if (player1.hand.getNumCards() == 5)
            {
                endGame();
            }

        }

        private void standButton_Click(object sender, EventArgs e)
        {

            splitButton.Visible = false;
            insuranceButton.Visible = false;
            while (dealer.hand.getHandTotal() < 17)
            {
                dealer.hand.addCard(deck.getCard());
                updateDealerHandPictureBox();
                System.Threading.Thread.Sleep(500);
            }
            endGame();
        }

        private void incBet_Click(object sender, EventArgs e)
        {
            if (player1.getMoney() - betInc >= 0)
            {
                player1.wager += betInc;
                player1.takeMoney(betInc);
                betLabel.Text = "Bet: $" + player1.wager.ToString();
                moneyBal.Text = "$" + player1.getMoney();

                //Dont show dealer button until they bet.
                if (player1.wager > 0)
                    dealButton.Visible = true;
            }
        }

        private void decBet_Click(object sender, EventArgs e)
        {
            if (player1.wager > 0)
            {
                player1.wager -= betInc;
                player1.addMoney(betInc);
                betLabel.Text = "Bet: $" + player1.wager.ToString();
                moneyBal.Text = "$" + player1.getMoney();

                //Dont show dealer button until they bet.
                if (player1.wager <= 0)
                    dealButton.Visible = false;
            }
        }

        private void insuranceBet()
        {
            insuranceIncBet.Visible = true;
            insuranceDecBet.Visible = true;
            insuranceLabel.Visible = true;
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"..\..\..\Money.txt", moneyBal.Text);
            Close();
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timerbool = !Timerbool;
            if (Timerbool)
                blinkPanel.BackColor = System.Drawing.Color.DarkGreen;
            if (!Timerbool)
                blinkPanel.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            goToLogin();
        }

        private void FirstLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserNameBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton2_Click(object sender, EventArgs e)
        {
            makeLogin();
        }

        private void SignInConfirm_Click(object sender, EventArgs e)
        {
            LaunchGame();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
            forgotPass();
        }

        private void MyTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            goToLogin();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            goToLogin();
        }

        private void SignUpConfirm_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Card card1, card2, card3, card4;
            string dcard1 = Interaction.InputBox("Dealer Card 1", "Dealer Hand", "(ex: 2D for 2 of Diamonds)");
            //SignInButton.Text = dcard1;
            if (dcard1.Length == 2)
            {
                card1 = new Card(dcard1.Substring(1, 1), dcard1.Substring(0, 1));
            }
            else
            {
                card1 = new Card(dcard1.Substring(2, 1), dcard1.Substring(0, 2));
            }
            string dcard2 = Interaction.InputBox("Dealer Card 2", "Dealer Hand", "(ex: 2D for 2 of Diamonds)");
            //SignInButton.Text = dcard2;
            if (dcard2.Length == 2)
            {
                card2 = new Card(dcard2.Substring(1, 1), dcard2.Substring(0, 1));
            }
            else
            {
                card2 = new Card(dcard2.Substring(2, 1), dcard2.Substring(0, 2));
            }
            string pcard1 = Interaction.InputBox("Player Card 1", "Player Hand", "(ex: 2D for 2 of Diamonds)");
            //SignInButton.Text = pcard1;
            if (pcard1.Length == 2)
            {
                card3 = new Card(pcard1.Substring(1, 1), pcard1.Substring(0, 1));
            }
            else
            {
                card3 = new Card(pcard1.Substring(2, 1), pcard1.Substring(0, 2));
            }
            string pcard2 = Interaction.InputBox("Player Card 2", "Players Hand", "(ex: 2D for 2 of Diamonds)");
            //SignInButton.Text = pcard2;
            if (pcard2.Length == 2)
            {
                card4 = new Card(pcard2.Substring(1, 1), pcard2.Substring(0, 1));
            }
            else
            {
                card4 = new Card(pcard2.Substring(2, 1), pcard2.Substring(0, 2));
            }
            startGame2(card1, card2, card3, card4);
        }
        private void insuranceButton_Click(object sender, EventArgs e)
        {
            insuranceBet();
        }

        private void insuranceIncBet_Click(object sender, EventArgs e)
        {
            if (player1.insurance < player1.wager / 2)
            {
                player1.insurance += betInc;
                player1.takeMoney(betInc);
                insuranceLabel.Text = "Insurance: $" + player1.insurance.ToString();
                moneyBal.Text = "$" + player1.getMoney();
            }
        }

        private void insuranceDecBet_Click(object sender, EventArgs e)
        {
            if (player1.insurance > 0)
            {
                player1.insurance -= betInc;
                player1.addMoney(betInc);
                insuranceLabel.Text = "Insurance: $" + player1.insurance.ToString();
                moneyBal.Text = "$" + player1.getMoney();
            }
        }

    }
}

