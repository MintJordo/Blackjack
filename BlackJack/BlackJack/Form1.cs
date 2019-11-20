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

        public void updatePlayerSplitHandPictureBox()
        {
            if (player1.splitHand.show().Length >= 1)
            {
                myHand6.Visible = true;
                myHand6.BackgroundImage = Image.FromFile(player1.splitHand.show()[0].getCardPath());
                myHand6.BringToFront();
            }
            if (player1.splitHand.show().Length >= 2)
            {
                myHand7.Visible = true;
                myHand7.BackgroundImage = Image.FromFile(player1.splitHand.show()[1].getCardPath());
                myHand7.BringToFront();
            }
            if (player1.splitHand.show().Length >= 3)
            {
                myHand8.Visible = true;
                myHand8.BackgroundImage = Image.FromFile(player1.splitHand.show()[2].getCardPath());
                myHand8.BringToFront();
            }
            if (player1.splitHand.show().Length >= 4)
            {
                myHand9.Visible = true;
                myHand9.BackgroundImage = Image.FromFile(player1.splitHand.show()[3].getCardPath());
                myHand9.BringToFront();
            }
            if (player1.splitHand.show().Length == 5)
            {
                myHand10.Visible = true;
                myHand10.BackgroundImage = Image.FromFile(player1.splitHand.show()[4].getCardPath());
                myHand10.BringToFront();
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
            player1.splitHand.emptyHand();
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
            nameBox.BackColor = Color.FromArgb(0, 25, 50);
            usernameBox.BackColor = Color.FromArgb(0, 25, 50);
            addressBox.BackColor = Color.FromArgb(0, 25, 50);
            phoneBox.BackColor = Color.FromArgb(0, 25, 50);
            creditCardBox.BackColor = Color.FromArgb(0, 25, 50);
            passwordBox.BackColor = Color.FromArgb(0, 25, 50);
            SignUpConfirm.BackColor = Color.FromArgb(74, 154, 122);
            SignUpConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);

            //changePassword
            newPasswordTextField.BackColor = Color.FromArgb(0, 25, 50);
            confirmPasswordTextField.BackColor = Color.FromArgb(0, 25, 50);
            setPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 154, 122);
            setPassword.BackColor = Color.FromArgb(74, 154, 122);

            //forgotPassPanel
            verifyPhoneNum.BackColor = Color.FromArgb(0, 25, 50);
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

            noUserLabel.Visible = false;
        }
        public void newPass()
        {
            newPassPanel.Visible = true;
            forgotPanel.Visible = false;
            settingsPanel.Visible = false;
            newPassPanel.Location = new Point(209, 34);

            passDontMatchLabel.Visible = false;
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
                if (entered_username == username && entered_password == password) {
                    SignUpPanel.Visible = false;
                    SignInPanel.Visible = false;
                    forgotPanel.Visible = false;
                    newPassPanel.Visible = false;
                    splitButton.Visible = false;
                    testButton.Visible = true;
                    GamePanel.Visible = true;
                    GamePanel.Location = new Point(13, 13);
                    this.BackColor = Color.Green;
                    player1.setName(username);
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
            goToLogin();

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
            myHand6.Visible = false;
            myHand7.Visible = false;
            myHand8.Visible = false;
            myHand9.Visible = false;
            myHand10.Visible = false;
            myTotalLabel2.Visible = false;
            myTotalVal2.Visible = false;

            myHand1.Location = new Point(339, 309);
            myHand2.Location = new Point(359, 309);
            myHand3.Location = new Point(379, 309);
            myHand4.Location = new Point(399, 309);
            myHand5.Location = new Point(419, 309);

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
            testButton.Visible = false;

            dealerTotalVal.Text = "?";

            updatePlayerHandPictureBox();
            updateDealerHandPictureBox();
            myTotalLabel.Location = new Point(307, 277);
            myTotalVal.Location = new Point(407, 277);
            myTotalVal.Text = player1.hand.getHandTotal().ToString();

            if(player1.hand.show()[0].getCardValue() == player1.hand.show()[1].getCardValue())
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

        private void testButton_Click(object sender, EventArgs e)
        {
            Card card1, card2, card3, card4;
            string dcard1 = Interaction.InputBox("Dealer Card 1", "Dealer Hand", "(ex: 2D for 2 of Diamonds)");
            //SignInButton.Text = dcard1;
            if (dcard1.Length == 2)
            {
                card1 = new Card(dcard1.Substring(1, 1), dcard1.Substring(0, 1));
            }
            else if(dcard1.Length == 0)
            {
                return;
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
            else if (dcard2.Length == 0)
            {
                return;
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
            else if (pcard1.Length == 0)
            {
                return;
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
            else if (pcard2.Length == 0)
            {
                return;
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
            insuranceButton.Visible = false;
        }

        private void insuranceIncBet_Click(object sender, EventArgs e)
        {
            if (player1.insurance + 5 <= player1.wager / 2)
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

        private void verifyButton_Click(object sender, EventArgs e) {
            XmlDocument doc = new XmlDocument();
            doc.Load("Players.xml");
            // Check to make sure that that username and phone number match
            string entered_username = verifyUsername.Text;
            string entered_phoneNum = verifyPhoneNum.Text;
            foreach (XmlNode node in doc.DocumentElement) {
                string username = node.Attributes[0].InnerText;
                string phoneNum = node.ChildNodes[4].InnerText;
                if (entered_username == username && entered_phoneNum == phoneNum) {
                    newPass();
                }
                else {
                    noUserLabel.Visible = true;
                }
            }
        }

        private void setPassword_Click(object sender, EventArgs e) {
            string newPass = newPasswordTextField.Text;
            string confirmNewPass = confirmPasswordTextField.Text;
            if (newPass == confirmNewPass) {
                // Update XML file with new password
                XmlDocument doc = new XmlDocument();
                doc.Load("Players.xml");
                foreach (XmlNode node in doc.DocumentElement) {
                    if (verifyUsername.Text == node.Attributes[0].InnerText) {
                        node.ChildNodes[1].InnerText = confirmNewPass;
                        doc.Save("Players.xml");
                    }
                }
                goToLogin();
            }
            else {
                passDontMatchLabel.Visible = true;
            }
        }

        private void newPassPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void SignUpConfirm_Click(object sender, EventArgs e) {
            // nameBox, usernameBox, phoneBox, creditCardBox, addressBox, passwordBox
            string name = nameBox.Text;
            string username = usernameBox.Text;
            string phone = phoneBox.Text;
            string creditCard = creditCardBox.Text;
            string address = addressBox.Text;
            string password = passwordBox.Text;
            // Make sure each text field is filled out
            if (name == null || username == null || phone == null || creditCard == null || address == null || password == null) {
                Console.WriteLine("You need to fill out each text field");
            }
            else {
                // Check if username exists or not
                XmlDocument doc = new XmlDocument();
                doc.Load("Players.xml");
                bool exists = false;
                foreach (XmlNode node in doc.DocumentElement) {
                    if (username == node.Attributes[0].InnerText) {
                        exists = true;
                    }
                }
                // Username exists
                if (exists) {
                    Console.WriteLine("User already exists");
                }
                // Username doesn't exist
                else {
                    // Add user to XML file
                    
                    
                    SignUpPanel.Visible = false;
                    SignInPanel.Visible = false;
                    forgotPanel.Visible = false;
                    newPassPanel.Visible = false;
                    GamePanel.Visible = true;
                    GamePanel.Location = new Point(13, 13);
                    this.BackColor = Color.Green;
                }
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            myTotalLabel.Location = new Point(428, 277);
            myTotalVal.Location = new Point(527, 277);
            myHand1.Location = new Point(423, 309);
            myHand2.Location = new Point(443, 309);
            myHand3.Location = new Point(463, 309);
            myHand4.Location = new Point(483, 309);
            myHand5.Location = new Point(503, 309);
            player1.splitHand.addCard(player1.hand.show()[1]);
            updatePlayerSplitHandPictureBox();

            splitButton.Visible = false;

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
            settingsPanel.Visible = true;
            settingsPanel.Location = new Point(209, 34);
            this.BackColor = Color.FromArgb(0, 25, 50);

            XmlDocument doc = new XmlDocument();
            doc.Load("Players.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string username = node.Attributes[0].InnerText;
                Console.WriteLine("Comparing " + username + " to " + player1.getName());
                if (player1.getName() == username)
                {
                    //read in all the user info
                    string name = node.ChildNodes[0].InnerText;
                    string password = node.ChildNodes[1].InnerText;
                    string balance = node.ChildNodes[2].InnerText;
                    string address = node.ChildNodes[3].InnerText;
                    string phonenumber = node.ChildNodes[4].InnerText;
                    string creditcard = node.ChildNodes[5].InnerText;

                    //populate the test boxes
                    nameChange.Text = name;
                    unsmaeChange.Text = username;
                    //no passwd
                    balChange.Text = balance;
                    addChange.Text = address;
                    phoneChange.Text = phonenumber;
                    ccChange.Text = creditcard;
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
            settingsPanel.Visible = false;
            settingsPanel.Location = new Point(209, 34);
            this.BackColor = Color.Green;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passChangebtn_Click(object sender, EventArgs e)
        {
            if (passChange.Text == "") return;

            XmlDocument doc = new XmlDocument();
            doc.Load("Players.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string username = node.Attributes[0].InnerText;
                if (player1.getName() == username)
                {
                    if (passChange.Text == node.ChildNodes[1].InnerText)
                    {
                        Console.WriteLine("updating pass for " + username);
                        newPass();
                    }
                }

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void balChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void phoneChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void ccChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Players.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string username = node.Attributes[0].InnerText;
                if (player1.getName() == username)
                {
                    //read in all the user info
                    node.Attributes[0].InnerText = unsmaeChange.Text;
                    node.ChildNodes[0].InnerText = nameChange.Text;
                    //node.ChildNodes[1].InnerText;
                    node.ChildNodes[2].InnerText = balChange.Text;
                    node.ChildNodes[3].InnerText = addChange.Text;
                    node.ChildNodes[4].InnerText = phoneChange.Text;
                }
            }
            doc.Save("Players.xml");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void passChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void addChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void unsmaeChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void myTotalVal2_Click(object sender, EventArgs e)
        {

        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

