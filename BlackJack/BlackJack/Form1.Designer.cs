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

namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyBal = new System.Windows.Forms.Label();
            this.myTotalLabel = new System.Windows.Forms.Label();
            this.myTotalVal = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.dealerTotalVal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.betLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.dealerHand5 = new System.Windows.Forms.PictureBox();
            this.dealerHand4 = new System.Windows.Forms.PictureBox();
            this.dealerHand3 = new System.Windows.Forms.PictureBox();
            this.myHand5 = new System.Windows.Forms.PictureBox();
            this.myHand4 = new System.Windows.Forms.PictureBox();
            this.myHand3 = new System.Windows.Forms.PictureBox();
            this.deckCard = new System.Windows.Forms.PictureBox();
            this.myHand2 = new System.Windows.Forms.PictureBox();
            this.myHand1 = new System.Windows.Forms.PictureBox();
            this.dealerHand2 = new System.Windows.Forms.PictureBox();
            this.dealerHand1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.myTotalVal2 = new System.Windows.Forms.Label();
            this.myTotalLabel2 = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.myHand10 = new System.Windows.Forms.PictureBox();
            this.myHand9 = new System.Windows.Forms.PictureBox();
            this.myHand8 = new System.Windows.Forms.PictureBox();
            this.myHand7 = new System.Windows.Forms.PictureBox();
            this.myHand6 = new System.Windows.Forms.PictureBox();
            this.blinkPanel = new System.Windows.Forms.Panel();
            this.newPassPanel = new System.Windows.Forms.Panel();
            this.passDontMatchLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.setPassword = new System.Windows.Forms.Button();
            this.confirmNewPassword = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.forgotPanel = new System.Windows.Forms.Panel();
            this.noUserLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.verifyUserLabel1 = new System.Windows.Forms.Label();
            this.UsernameLabelVerify = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.signUpError = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.ccLabel = new System.Windows.Forms.Label();
            this.SignUpConfirm = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Label();
            this.underSignUp = new System.Windows.Forms.Panel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BetTimer = new System.Windows.Forms.Timer(this.components);
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.forgotLabel = new System.Windows.Forms.Label();
            this.SignInConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameLabel2 = new System.Windows.Forms.Label();
            this.welcomeBack = new System.Windows.Forms.Label();
            this.underSignIn2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SignUpButton2 = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelSettings = new System.Windows.Forms.Label();
            this.passChangebtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.loggedinTag = new System.Windows.Forms.Label();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.balChange = new ePOSOne.btnProduct.MyTextBox();
            this.phoneChange = new ePOSOne.btnProduct.MyTextBox();
            this.ccChange = new ePOSOne.btnProduct.MyTextBox();
            this.addChange = new ePOSOne.btnProduct.MyTextBox();
            this.unsmaeChange = new ePOSOne.btnProduct.MyTextBox();
            this.passChange = new ePOSOne.btnProduct.MyTextBox();
            this.nameChange = new ePOSOne.btnProduct.MyTextBox();
            this.splitHitButton = new ePOSOne.btnProduct.Button_WOC();
            this.splitStandButton = new ePOSOne.btnProduct.Button_WOC();
            this.insuranceButton = new ePOSOne.btnProduct.Button_WOC();
            this.splitButton = new ePOSOne.btnProduct.Button_WOC();
            this.insuranceDecBet = new ePOSOne.btnProduct.Button_WOC();
            this.insuranceIncBet = new ePOSOne.btnProduct.Button_WOC();
            this.decBet = new ePOSOne.btnProduct.Button_WOC();
            this.incBet = new ePOSOne.btnProduct.Button_WOC();
            this.hitButton = new ePOSOne.btnProduct.Button_WOC();
            this.standButton = new ePOSOne.btnProduct.Button_WOC();
            this.dealButton = new ePOSOne.btnProduct.Button_WOC();
            this.phoneBox = new ePOSOne.btnProduct.MyTextBox();
            this.creditCardBox = new ePOSOne.btnProduct.MyTextBox();
            this.passwordBox = new ePOSOne.btnProduct.MyTextBox();
            this.addressBox = new ePOSOne.btnProduct.MyTextBox();
            this.usernameBox = new ePOSOne.btnProduct.MyTextBox();
            this.nameBox = new ePOSOne.btnProduct.MyTextBox();
            this.confirmPasswordTextField = new ePOSOne.btnProduct.MyTextBox();
            this.newPasswordTextField = new ePOSOne.btnProduct.MyTextBox();
            this.verifyPhoneNum = new ePOSOne.btnProduct.MyTextBox();
            this.verifyUsername = new ePOSOne.btnProduct.MyTextBox();
            this.passwordBox2 = new ePOSOne.btnProduct.MyTextBox();
            this.UserNameBox2 = new ePOSOne.btnProduct.MyTextBox();
            this.testButton = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand1)).BeginInit();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand6)).BeginInit();
            this.blinkPanel.SuspendLayout();
            this.newPassPanel.SuspendLayout();
            this.forgotPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(60, 1);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(105, 32);
            this.moneyLabel.TabIndex = 7;
            this.moneyLabel.Text = "Money:";
            this.moneyLabel.Click += new System.EventHandler(this.moneyLabel_Click);
            // 
            // moneyBal
            // 
            this.moneyBal.AutoSize = true;
            this.moneyBal.Enabled = false;
            this.moneyBal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBal.Location = new System.Drawing.Point(158, 1);
            this.moneyBal.Name = "moneyBal";
            this.moneyBal.Size = new System.Drawing.Size(45, 32);
            this.moneyBal.TabIndex = 8;
            this.moneyBal.Text = "$1";
            this.moneyBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyBal.Click += new System.EventHandler(this.moneyBal_Click);
            // 
            // myTotalLabel
            // 
            this.myTotalLabel.AutoSize = true;
            this.myTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalLabel.Location = new System.Drawing.Point(430, 274);
            this.myTotalLabel.Name = "myTotalLabel";
            this.myTotalLabel.Size = new System.Drawing.Size(105, 32);
            this.myTotalLabel.TabIndex = 9;
            this.myTotalLabel.Text = "Total:";
            this.myTotalLabel.Click += new System.EventHandler(this.myTotal_Click);
            // 
            // myTotalVal
            // 
            this.myTotalVal.AutoSize = true;
            this.myTotalVal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalVal.Location = new System.Drawing.Point(530, 274);
            this.myTotalVal.Name = "myTotalVal";
            this.myTotalVal.Size = new System.Drawing.Size(30, 32);
            this.myTotalVal.TabIndex = 10;
            this.myTotalVal.Text = "0";
            this.myTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myTotalVal.Click += new System.EventHandler(this.myTotalVal_Click);
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalLabel.Location = new System.Drawing.Point(307, 122);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(105, 32);
            this.dealerTotalLabel.TabIndex = 11;
            this.dealerTotalLabel.Text = "Total:";
            this.dealerTotalLabel.Click += new System.EventHandler(this.dealerTotalLabel_Click);
            // 
            // dealerTotalVal
            // 
            this.dealerTotalVal.AutoSize = true;
            this.dealerTotalVal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalVal.Location = new System.Drawing.Point(406, 122);
            this.dealerTotalVal.Name = "dealerTotalVal";
            this.dealerTotalVal.Size = new System.Drawing.Size(30, 32);
            this.dealerTotalVal.TabIndex = 12;
            this.dealerTotalVal.Text = "?";
            this.dealerTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dealerTotalVal.Click += new System.EventHandler(this.dealerTotalVal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.insuranceDecBet);
            this.panel1.Controls.Add(this.insuranceIncBet);
            this.panel1.Controls.Add(this.decBet);
            this.panel1.Controls.Add(this.incBet);
            this.panel1.Controls.Add(this.betLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 160);
            this.panel1.TabIndex = 16;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(17, 66);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(120, 32);
            this.betLabel.TabIndex = 16;
            this.betLabel.Text = "Bet: $0";
            this.betLabel.Click += new System.EventHandler(this.betLabel_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::BlackJack.Properties.Resources.x;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(767, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 23;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dealerHand5
            // 
            this.dealerHand5.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand5.BackgroundImage = global::BlackJack.Properties.Resources._10C;
            this.dealerHand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand5.Enabled = false;
            this.dealerHand5.Image = global::BlackJack.Properties.Resources.transparent;
            this.dealerHand5.Location = new System.Drawing.Point(377, 4);
            this.dealerHand5.Name = "dealerHand5";
            this.dealerHand5.Size = new System.Drawing.Size(73, 109);
            this.dealerHand5.TabIndex = 22;
            this.dealerHand5.TabStop = false;
            this.dealerHand5.Click += new System.EventHandler(this.DealerHand5_Click);
            // 
            // dealerHand4
            // 
            this.dealerHand4.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand4.BackgroundImage = global::BlackJack.Properties.Resources._9H;
            this.dealerHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand4.Location = new System.Drawing.Point(360, 4);
            this.dealerHand4.Name = "dealerHand4";
            this.dealerHand4.Size = new System.Drawing.Size(73, 109);
            this.dealerHand4.TabIndex = 21;
            this.dealerHand4.TabStop = false;
            // 
            // dealerHand3
            // 
            this.dealerHand3.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.dealerHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand3.Location = new System.Drawing.Point(342, 4);
            this.dealerHand3.Name = "dealerHand3";
            this.dealerHand3.Size = new System.Drawing.Size(73, 109);
            this.dealerHand3.TabIndex = 20;
            this.dealerHand3.TabStop = false;
            // 
            // myHand5
            // 
            this.myHand5.BackColor = System.Drawing.Color.Transparent;
            this.myHand5.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand5.Location = new System.Drawing.Point(502, 309);
            this.myHand5.Name = "myHand5";
            this.myHand5.Size = new System.Drawing.Size(73, 109);
            this.myHand5.TabIndex = 19;
            this.myHand5.TabStop = false;
            this.myHand5.Click += new System.EventHandler(this.MyCard5_Click);
            // 
            // myHand4
            // 
            this.myHand4.BackColor = System.Drawing.Color.Transparent;
            this.myHand4.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand4.Location = new System.Drawing.Point(483, 309);
            this.myHand4.Name = "myHand4";
            this.myHand4.Size = new System.Drawing.Size(73, 109);
            this.myHand4.TabIndex = 18;
            this.myHand4.TabStop = false;
            // 
            // myHand3
            // 
            this.myHand3.BackColor = System.Drawing.Color.Transparent;
            this.myHand3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand3.Location = new System.Drawing.Point(462, 309);
            this.myHand3.Name = "myHand3";
            this.myHand3.Size = new System.Drawing.Size(73, 109);
            this.myHand3.TabIndex = 17;
            this.myHand3.TabStop = false;
            // 
            // deckCard
            // 
            this.deckCard.BackgroundImage = global::BlackJack.Properties.Resources.red_back;
            this.deckCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deckCard.Location = new System.Drawing.Point(524, 1);
            this.deckCard.Name = "deckCard";
            this.deckCard.Size = new System.Drawing.Size(73, 109);
            this.deckCard.TabIndex = 6;
            this.deckCard.TabStop = false;
            this.deckCard.Click += new System.EventHandler(this.deckCard_Click);
            // 
            // myHand2
            // 
            this.myHand2.BackColor = System.Drawing.Color.Transparent;
            this.myHand2.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand2.Location = new System.Drawing.Point(443, 309);
            this.myHand2.Name = "myHand2";
            this.myHand2.Size = new System.Drawing.Size(73, 109);
            this.myHand2.TabIndex = 5;
            this.myHand2.TabStop = false;
            this.myHand2.Click += new System.EventHandler(this.myHand2_Click);
            // 
            // myHand1
            // 
            this.myHand1.BackColor = System.Drawing.Color.Transparent;
            this.myHand1.BackgroundImage = global::BlackJack.Properties.Resources._10C;
            this.myHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand1.Location = new System.Drawing.Point(423, 309);
            this.myHand1.Name = "myHand1";
            this.myHand1.Size = new System.Drawing.Size(73, 109);
            this.myHand1.TabIndex = 4;
            this.myHand1.TabStop = false;
            this.myHand1.Click += new System.EventHandler(this.myHand1_Click);
            // 
            // dealerHand2
            // 
            this.dealerHand2.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand2.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.dealerHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand2.Location = new System.Drawing.Point(322, 4);
            this.dealerHand2.Name = "dealerHand2";
            this.dealerHand2.Size = new System.Drawing.Size(73, 109);
            this.dealerHand2.TabIndex = 3;
            this.dealerHand2.TabStop = false;
            this.dealerHand2.Click += new System.EventHandler(this.dealerHand2_Click);
            // 
            // dealerHand1
            // 
            this.dealerHand1.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand1.BackgroundImage = global::BlackJack.Properties.Resources._9H;
            this.dealerHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand1.Location = new System.Drawing.Point(307, 4);
            this.dealerHand1.Name = "dealerHand1";
            this.dealerHand1.Size = new System.Drawing.Size(73, 109);
            this.dealerHand1.TabIndex = 2;
            this.dealerHand1.TabStop = false;
            this.dealerHand1.Click += new System.EventHandler(this.dealerHand1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 10);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(-5, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 10);
            this.panel3.TabIndex = 29;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Green;
            this.GamePanel.Controls.Add(this.outcomeLabel);
            this.GamePanel.Controls.Add(this.loggedinTag);
            this.GamePanel.Controls.Add(this.splitHitButton);
            this.GamePanel.Controls.Add(this.splitStandButton);
            this.GamePanel.Controls.Add(this.dealerHand5);
            this.GamePanel.Controls.Add(this.dealerHand4);
            this.GamePanel.Controls.Add(this.dealerHand3);
            this.GamePanel.Controls.Add(this.dealerHand2);
            this.GamePanel.Controls.Add(this.dealerHand1);
            this.GamePanel.Controls.Add(this.myTotalVal2);
            this.GamePanel.Controls.Add(this.myTotalLabel2);
            this.GamePanel.Controls.Add(this.SettingsButton);
            this.GamePanel.Controls.Add(this.insuranceLabel);
            this.GamePanel.Controls.Add(this.myHand10);
            this.GamePanel.Controls.Add(this.myHand9);
            this.GamePanel.Controls.Add(this.myHand8);
            this.GamePanel.Controls.Add(this.myHand7);
            this.GamePanel.Controls.Add(this.myHand6);
            this.GamePanel.Controls.Add(this.insuranceButton);
            this.GamePanel.Controls.Add(this.splitButton);
            this.GamePanel.Controls.Add(this.blinkPanel);
            this.GamePanel.Controls.Add(this.hitButton);
            this.GamePanel.Controls.Add(this.standButton);
            this.GamePanel.Controls.Add(this.dealButton);
            this.GamePanel.Controls.Add(this.moneyBal);
            this.GamePanel.Controls.Add(this.moneyLabel);
            this.GamePanel.Controls.Add(this.myHand5);
            this.GamePanel.Controls.Add(this.myHand4);
            this.GamePanel.Controls.Add(this.myHand3);
            this.GamePanel.Controls.Add(this.dealerTotalVal);
            this.GamePanel.Controls.Add(this.dealerTotalLabel);
            this.GamePanel.Controls.Add(this.myTotalVal);
            this.GamePanel.Controls.Add(this.myTotalLabel);
            this.GamePanel.Controls.Add(this.deckCard);
            this.GamePanel.Controls.Add(this.myHand2);
            this.GamePanel.Controls.Add(this.myHand1);
            this.GamePanel.Location = new System.Drawing.Point(31, 404);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(753, 424);
            this.GamePanel.TabIndex = 32;
            this.GamePanel.Visible = false;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // myTotalVal2
            // 
            this.myTotalVal2.AutoSize = true;
            this.myTotalVal2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalVal2.Location = new System.Drawing.Point(299, 274);
            this.myTotalVal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myTotalVal2.Name = "myTotalVal2";
            this.myTotalVal2.Size = new System.Drawing.Size(30, 32);
            this.myTotalVal2.TabIndex = 45;
            this.myTotalVal2.Text = "0";
            this.myTotalVal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myTotalVal2.Visible = false;
            this.myTotalVal2.Click += new System.EventHandler(this.myTotalVal2_Click);
            // 
            // myTotalLabel2
            // 
            this.myTotalLabel2.AutoSize = true;
            this.myTotalLabel2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalLabel2.Location = new System.Drawing.Point(197, 274);
            this.myTotalLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myTotalLabel2.Name = "myTotalLabel2";
            this.myTotalLabel2.Size = new System.Drawing.Size(105, 32);
            this.myTotalLabel2.TabIndex = 44;
            this.myTotalLabel2.Text = "Total:";
            this.myTotalLabel2.Visible = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Image = global::BlackJack.Properties.Resources.icons8_person_64;
            this.SettingsButton.Location = new System.Drawing.Point(0, 0);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(60, 57);
            this.SettingsButton.TabIndex = 45;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.AutoSize = true;
            this.insuranceLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceLabel.Location = new System.Drawing.Point(5, 171);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(210, 32);
            this.insuranceLabel.TabIndex = 39;
            this.insuranceLabel.Text = "Insurance: $0";
            this.insuranceLabel.Visible = false;
            // 
            // myHand10
            // 
            this.myHand10.BackColor = System.Drawing.Color.Transparent;
            this.myHand10.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand10.Location = new System.Drawing.Point(273, 309);
            this.myHand10.Margin = new System.Windows.Forms.Padding(2);
            this.myHand10.Name = "myHand10";
            this.myHand10.Size = new System.Drawing.Size(73, 109);
            this.myHand10.TabIndex = 43;
            this.myHand10.TabStop = false;
            this.myHand10.Visible = false;
            // 
            // myHand9
            // 
            this.myHand9.BackColor = System.Drawing.Color.Transparent;
            this.myHand9.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand9.Location = new System.Drawing.Point(253, 309);
            this.myHand9.Margin = new System.Windows.Forms.Padding(2);
            this.myHand9.Name = "myHand9";
            this.myHand9.Size = new System.Drawing.Size(73, 109);
            this.myHand9.TabIndex = 42;
            this.myHand9.TabStop = false;
            this.myHand9.Visible = false;
            // 
            // myHand8
            // 
            this.myHand8.BackColor = System.Drawing.Color.Transparent;
            this.myHand8.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand8.Location = new System.Drawing.Point(233, 309);
            this.myHand8.Margin = new System.Windows.Forms.Padding(2);
            this.myHand8.Name = "myHand8";
            this.myHand8.Size = new System.Drawing.Size(73, 109);
            this.myHand8.TabIndex = 41;
            this.myHand8.TabStop = false;
            this.myHand8.Visible = false;
            // 
            // myHand7
            // 
            this.myHand7.BackColor = System.Drawing.Color.Transparent;
            this.myHand7.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand7.Location = new System.Drawing.Point(213, 309);
            this.myHand7.Margin = new System.Windows.Forms.Padding(2);
            this.myHand7.Name = "myHand7";
            this.myHand7.Size = new System.Drawing.Size(73, 109);
            this.myHand7.TabIndex = 40;
            this.myHand7.TabStop = false;
            this.myHand7.Visible = false;
            // 
            // myHand6
            // 
            this.myHand6.BackColor = System.Drawing.Color.Transparent;
            this.myHand6.BackgroundImage = global::BlackJack.Properties.Resources._10C;
            this.myHand6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand6.Location = new System.Drawing.Point(193, 309);
            this.myHand6.Margin = new System.Windows.Forms.Padding(2);
            this.myHand6.Name = "myHand6";
            this.myHand6.Size = new System.Drawing.Size(73, 109);
            this.myHand6.TabIndex = 39;
            this.myHand6.TabStop = false;
            this.myHand6.Visible = false;
            // 
            // blinkPanel
            // 
            this.blinkPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.blinkPanel.Controls.Add(this.panel1);
            this.blinkPanel.Location = new System.Drawing.Point(2, 255);
            this.blinkPanel.Name = "blinkPanel";
            this.blinkPanel.Size = new System.Drawing.Size(166, 166);
            this.blinkPanel.TabIndex = 30;
            // 
            // newPassPanel
            // 
            this.newPassPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.newPassPanel.Controls.Add(this.passDontMatchLabel);
            this.newPassPanel.Controls.Add(this.label9);
            this.newPassPanel.Controls.Add(this.setPassword);
            this.newPassPanel.Controls.Add(this.confirmNewPassword);
            this.newPassPanel.Controls.Add(this.newPassword);
            this.newPassPanel.Controls.Add(this.label12);
            this.newPassPanel.Controls.Add(this.confirmPasswordTextField);
            this.newPassPanel.Controls.Add(this.newPasswordTextField);
            this.newPassPanel.Controls.Add(this.panel10);
            this.newPassPanel.Location = new System.Drawing.Point(1084, 5);
            this.newPassPanel.Name = "newPassPanel";
            this.newPassPanel.Size = new System.Drawing.Size(376, 352);
            this.newPassPanel.TabIndex = 36;
            this.newPassPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.newPassPanel_Paint);
            // 
            // passDontMatchLabel
            // 
            this.passDontMatchLabel.AutoSize = true;
            this.passDontMatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.passDontMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passDontMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passDontMatchLabel.Location = new System.Drawing.Point(102, 256);
            this.passDontMatchLabel.Name = "passDontMatchLabel";
            this.passDontMatchLabel.Size = new System.Drawing.Size(174, 18);
            this.passDontMatchLabel.TabIndex = 18;
            this.passDontMatchLabel.Text = "Passwords do not match";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(161, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cancel";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // setPassword
            // 
            this.setPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.setPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setPassword.FlatAppearance.BorderSize = 0;
            this.setPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.setPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPassword.ForeColor = System.Drawing.Color.White;
            this.setPassword.Location = new System.Drawing.Point(63, 284);
            this.setPassword.Name = "setPassword";
            this.setPassword.Size = new System.Drawing.Size(246, 35);
            this.setPassword.TabIndex = 16;
            this.setPassword.Text = "Set Password";
            this.setPassword.UseVisualStyleBackColor = false;
            this.setPassword.Click += new System.EventHandler(this.setPassword_Click);
            // 
            // confirmNewPassword
            // 
            this.confirmNewPassword.AutoSize = true;
            this.confirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.confirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.confirmNewPassword.Location = new System.Drawing.Point(60, 201);
            this.confirmNewPassword.Name = "confirmNewPassword";
            this.confirmNewPassword.Size = new System.Drawing.Size(146, 16);
            this.confirmNewPassword.TabIndex = 15;
            this.confirmNewPassword.Text = "Confirm New Password";
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.BackColor = System.Drawing.Color.Transparent;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.Color.Gray;
            this.newPassword.Location = new System.Drawing.Point(62, 132);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(98, 16);
            this.newPassword.TabIndex = 13;
            this.newPassword.Text = "New Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(40, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(282, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Please enter new password.";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(65, 56);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(118, 3);
            this.panel10.TabIndex = 5;
            // 
            // forgotPanel
            // 
            this.forgotPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.forgotPanel.Controls.Add(this.noUserLabel);
            this.forgotPanel.Controls.Add(this.label4);
            this.forgotPanel.Controls.Add(this.verifyButton);
            this.forgotPanel.Controls.Add(this.verifyUserLabel1);
            this.forgotPanel.Controls.Add(this.UsernameLabelVerify);
            this.forgotPanel.Controls.Add(this.label7);
            this.forgotPanel.Controls.Add(this.verifyPhoneNum);
            this.forgotPanel.Controls.Add(this.verifyUsername);
            this.forgotPanel.Controls.Add(this.panel9);
            this.forgotPanel.Location = new System.Drawing.Point(1189, 368);
            this.forgotPanel.Name = "forgotPanel";
            this.forgotPanel.Size = new System.Drawing.Size(376, 352);
            this.forgotPanel.TabIndex = 35;
            // 
            // noUserLabel
            // 
            this.noUserLabel.AutoSize = true;
            this.noUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.noUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noUserLabel.ForeColor = System.Drawing.Color.Red;
            this.noUserLabel.Location = new System.Drawing.Point(69, 255);
            this.noUserLabel.Name = "noUserLabel";
            this.noUserLabel.Size = new System.Drawing.Size(238, 18);
            this.noUserLabel.TabIndex = 18;
            this.noUserLabel.Text = "Information does not match a user.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(161, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cancel";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // verifyButton
            // 
            this.verifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.verifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verifyButton.FlatAppearance.BorderSize = 0;
            this.verifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.verifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.White;
            this.verifyButton.Location = new System.Drawing.Point(63, 284);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(246, 35);
            this.verifyButton.TabIndex = 16;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = false;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // verifyUserLabel1
            // 
            this.verifyUserLabel1.AutoSize = true;
            this.verifyUserLabel1.BackColor = System.Drawing.Color.Transparent;
            this.verifyUserLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyUserLabel1.ForeColor = System.Drawing.Color.Gray;
            this.verifyUserLabel1.Location = new System.Drawing.Point(60, 201);
            this.verifyUserLabel1.Name = "verifyUserLabel1";
            this.verifyUserLabel1.Size = new System.Drawing.Size(98, 16);
            this.verifyUserLabel1.TabIndex = 15;
            this.verifyUserLabel1.Text = "Phone Number";
            this.verifyUserLabel1.Click += new System.EventHandler(this.Label5_Click);
            // 
            // UsernameLabelVerify
            // 
            this.UsernameLabelVerify.AutoSize = true;
            this.UsernameLabelVerify.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabelVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabelVerify.ForeColor = System.Drawing.Color.Gray;
            this.UsernameLabelVerify.Location = new System.Drawing.Point(62, 132);
            this.UsernameLabelVerify.Name = "UsernameLabelVerify";
            this.UsernameLabelVerify.Size = new System.Drawing.Size(77, 16);
            this.UsernameLabelVerify.TabIndex = 13;
            this.UsernameLabelVerify.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Please verify user information";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(43, 36);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(79, 2);
            this.panel9.TabIndex = 5;
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.SignUpPanel.Controls.Add(this.signUpError);
            this.SignUpPanel.Controls.Add(this.phoneLabel);
            this.SignUpPanel.Controls.Add(this.phoneBox);
            this.SignUpPanel.Controls.Add(this.ccLabel);
            this.SignUpPanel.Controls.Add(this.creditCardBox);
            this.SignUpPanel.Controls.Add(this.SignUpConfirm);
            this.SignUpPanel.Controls.Add(this.passwordLabel);
            this.SignUpPanel.Controls.Add(this.addressLabel);
            this.SignUpPanel.Controls.Add(this.usernameLabel);
            this.SignUpPanel.Controls.Add(this.FirstLabel);
            this.SignUpPanel.Controls.Add(this.CreateAccount);
            this.SignUpPanel.Controls.Add(this.passwordBox);
            this.SignUpPanel.Controls.Add(this.addressBox);
            this.SignUpPanel.Controls.Add(this.usernameBox);
            this.SignUpPanel.Controls.Add(this.nameBox);
            this.SignUpPanel.Controls.Add(this.underSignUp);
            this.SignUpPanel.Controls.Add(this.SignInButton);
            this.SignUpPanel.Controls.Add(this.signUpButton);
            this.SignUpPanel.Location = new System.Drawing.Point(17, 31);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(376, 352);
            this.SignUpPanel.TabIndex = 33;
            this.SignUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUpPanel_Paint);
            // 
            // signUpError
            // 
            this.signUpError.AutoSize = true;
            this.signUpError.BackColor = System.Drawing.Color.Transparent;
            this.signUpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpError.ForeColor = System.Drawing.Color.Red;
            this.signUpError.Location = new System.Drawing.Point(120, 288);
            this.signUpError.Name = "signUpError";
            this.signUpError.Size = new System.Drawing.Size(0, 18);
            this.signUpError.TabIndex = 19;
            this.signUpError.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Gray;
            this.phoneLabel.Location = new System.Drawing.Point(62, 125);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(91, 15);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone Number";
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.BackColor = System.Drawing.Color.Transparent;
            this.ccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccLabel.ForeColor = System.Drawing.Color.Gray;
            this.ccLabel.Location = new System.Drawing.Point(62, 166);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(116, 15);
            this.ccLabel.TabIndex = 18;
            this.ccLabel.Text = "Credit Card Number";
            // 
            // SignUpConfirm
            // 
            this.SignUpConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.SignUpConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignUpConfirm.FlatAppearance.BorderSize = 0;
            this.SignUpConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.SignUpConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpConfirm.ForeColor = System.Drawing.Color.White;
            this.SignUpConfirm.Location = new System.Drawing.Point(65, 312);
            this.SignUpConfirm.Name = "SignUpConfirm";
            this.SignUpConfirm.Size = new System.Drawing.Size(246, 35);
            this.SignUpConfirm.TabIndex = 7;
            this.SignUpConfirm.Text = "Sign Up";
            this.SignUpConfirm.UseVisualStyleBackColor = false;
            this.SignUpConfirm.Click += new System.EventHandler(this.SignUpConfirm_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Gray;
            this.passwordLabel.Location = new System.Drawing.Point(62, 246);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 15);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.Gray;
            this.addressLabel.Location = new System.Drawing.Point(62, 206);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 15);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Gray;
            this.usernameLabel.Location = new System.Drawing.Point(190, 86);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 15);
            this.usernameLabel.TabIndex = 13;
            this.usernameLabel.Text = "Username";
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLabel.ForeColor = System.Drawing.Color.Gray;
            this.FirstLabel.Location = new System.Drawing.Point(62, 86);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(41, 15);
            this.FirstLabel.TabIndex = 12;
            this.FirstLabel.Text = "Name";
            this.FirstLabel.Click += new System.EventHandler(this.FirstLabel_Click);
            // 
            // CreateAccount
            // 
            this.CreateAccount.AutoSize = true;
            this.CreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount.ForeColor = System.Drawing.Color.White;
            this.CreateAccount.Location = new System.Drawing.Point(99, 64);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(176, 25);
            this.CreateAccount.TabIndex = 11;
            this.CreateAccount.Text = "Sign Up For Free";
            this.CreateAccount.Click += new System.EventHandler(this.Label1_Click);
            // 
            // underSignUp
            // 
            this.underSignUp.Location = new System.Drawing.Point(65, 56);
            this.underSignUp.Name = "underSignUp";
            this.underSignUp.Size = new System.Drawing.Size(118, 3);
            this.underSignUp.TabIndex = 5;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.Transparent;
            this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(193, 22);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(118, 35);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(65, 22);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(118, 35);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(790, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 446);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 446);
            this.panel5.TabIndex = 31;
            // 
            // BetTimer
            // 
            this.BetTimer.Interval = 500;
            this.BetTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SignInPanel
            // 
            this.SignInPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.SignInPanel.Controls.Add(this.incorrectLabel);
            this.SignInPanel.Controls.Add(this.forgotLabel);
            this.SignInPanel.Controls.Add(this.SignInConfirm);
            this.SignInPanel.Controls.Add(this.label3);
            this.SignInPanel.Controls.Add(this.usernameLabel2);
            this.SignInPanel.Controls.Add(this.welcomeBack);
            this.SignInPanel.Controls.Add(this.passwordBox2);
            this.SignInPanel.Controls.Add(this.UserNameBox2);
            this.SignInPanel.Controls.Add(this.underSignIn2);
            this.SignInPanel.Controls.Add(this.panel8);
            this.SignInPanel.Controls.Add(this.button2);
            this.SignInPanel.Controls.Add(this.SignUpButton2);
            this.SignInPanel.Location = new System.Drawing.Point(399, 31);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(376, 352);
            this.SignInPanel.TabIndex = 34;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectLabel.Location = new System.Drawing.Point(39, 257);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(308, 18);
            this.incorrectLabel.TabIndex = 18;
            this.incorrectLabel.Text = "User does not exist or password is incorrect. ";
            this.incorrectLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // forgotLabel
            // 
            this.forgotLabel.AutoSize = true;
            this.forgotLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgotLabel.ForeColor = System.Drawing.Color.Teal;
            this.forgotLabel.Location = new System.Drawing.Point(144, 328);
            this.forgotLabel.Name = "forgotLabel";
            this.forgotLabel.Size = new System.Drawing.Size(86, 13);
            this.forgotLabel.TabIndex = 17;
            this.forgotLabel.Text = "Forgot Password";
            this.forgotLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // SignInConfirm
            // 
            this.SignInConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.SignInConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignInConfirm.FlatAppearance.BorderSize = 0;
            this.SignInConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.SignInConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInConfirm.ForeColor = System.Drawing.Color.White;
            this.SignInConfirm.Location = new System.Drawing.Point(63, 284);
            this.SignInConfirm.Name = "SignInConfirm";
            this.SignInConfirm.Size = new System.Drawing.Size(246, 35);
            this.SignInConfirm.TabIndex = 16;
            this.SignInConfirm.Text = "Sign In";
            this.SignInConfirm.UseVisualStyleBackColor = false;
            this.SignInConfirm.Click += new System.EventHandler(this.SignInConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(60, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel2.ForeColor = System.Drawing.Color.Gray;
            this.usernameLabel2.Location = new System.Drawing.Point(62, 133);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(77, 16);
            this.usernameLabel2.TabIndex = 13;
            this.usernameLabel2.Text = "User Name";
            // 
            // welcomeBack
            // 
            this.welcomeBack.AutoSize = true;
            this.welcomeBack.BackColor = System.Drawing.Color.Transparent;
            this.welcomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBack.ForeColor = System.Drawing.Color.White;
            this.welcomeBack.Location = new System.Drawing.Point(40, 80);
            this.welcomeBack.Name = "welcomeBack";
            this.welcomeBack.Size = new System.Drawing.Size(292, 25);
            this.welcomeBack.TabIndex = 11;
            this.welcomeBack.Text = "Welcome Back! Please Login";
            // 
            // underSignIn2
            // 
            this.underSignIn2.BackColor = System.Drawing.Color.DarkRed;
            this.underSignIn2.Location = new System.Drawing.Point(193, 56);
            this.underSignIn2.Name = "underSignIn2";
            this.underSignIn2.Size = new System.Drawing.Size(118, 3);
            this.underSignIn2.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(65, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 3);
            this.panel8.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(193, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sign In";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SignUpButton2
            // 
            this.SignUpButton2.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignUpButton2.FlatAppearance.BorderSize = 0;
            this.SignUpButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignUpButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton2.ForeColor = System.Drawing.Color.White;
            this.SignUpButton2.Location = new System.Drawing.Point(65, 22);
            this.SignUpButton2.Name = "SignUpButton2";
            this.SignUpButton2.Size = new System.Drawing.Size(118, 35);
            this.SignUpButton2.TabIndex = 2;
            this.SignUpButton2.Text = "Sign Up";
            this.SignUpButton2.UseVisualStyleBackColor = false;
            this.SignUpButton2.Click += new System.EventHandler(this.SignUpButton2_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.CancelSettings);
            this.settingsPanel.Controls.Add(this.passChangebtn);
            this.settingsPanel.Controls.Add(this.label17);
            this.settingsPanel.Controls.Add(this.balChange);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.phoneChange);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.ccChange);
            this.settingsPanel.Controls.Add(this.saveSettings);
            this.settingsPanel.Controls.Add(this.label13);
            this.settingsPanel.Controls.Add(this.label14);
            this.settingsPanel.Controls.Add(this.label6);
            this.settingsPanel.Controls.Add(this.label15);
            this.settingsPanel.Controls.Add(this.label16);
            this.settingsPanel.Controls.Add(this.addChange);
            this.settingsPanel.Controls.Add(this.unsmaeChange);
            this.settingsPanel.Controls.Add(this.passChange);
            this.settingsPanel.Controls.Add(this.nameChange);
            this.settingsPanel.Location = new System.Drawing.Point(808, 378);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(372, 348);
            this.settingsPanel.TabIndex = 34;
            this.settingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(67, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Information does not match a user.";
            // 
            // CancelSettings
            // 
            this.CancelSettings.AutoSize = true;
            this.CancelSettings.BackColor = System.Drawing.Color.Transparent;
            this.CancelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSettings.ForeColor = System.Drawing.Color.Gray;
            this.CancelSettings.Location = new System.Drawing.Point(163, 331);
            this.CancelSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CancelSettings.Name = "CancelSettings";
            this.CancelSettings.Size = new System.Drawing.Size(45, 15);
            this.CancelSettings.TabIndex = 24;
            this.CancelSettings.Text = "Cancel";
            this.CancelSettings.Click += new System.EventHandler(this.label18_Click);
            // 
            // passChangebtn
            // 
            this.passChangebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.passChangebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passChangebtn.FlatAppearance.BorderSize = 0;
            this.passChangebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.passChangebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passChangebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passChangebtn.ForeColor = System.Drawing.Color.White;
            this.passChangebtn.Location = new System.Drawing.Point(204, 250);
            this.passChangebtn.Margin = new System.Windows.Forms.Padding(2);
            this.passChangebtn.Name = "passChangebtn";
            this.passChangebtn.Size = new System.Drawing.Size(92, 25);
            this.passChangebtn.TabIndex = 23;
            this.passChangebtn.Text = "Change";
            this.passChangebtn.UseVisualStyleBackColor = false;
            this.passChangebtn.Click += new System.EventHandler(this.passChangebtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(70, 195);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Balance";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Phone Number";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(70, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Credit Card Number";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.saveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveSettings.FlatAppearance.BorderSize = 0;
            this.saveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(154)))), ((int)(((byte)(122)))));
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettings.ForeColor = System.Drawing.Color.White;
            this.saveSettings.Location = new System.Drawing.Point(73, 299);
            this.saveSettings.Margin = new System.Windows.Forms.Padding(2);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(222, 30);
            this.saveSettings.TabIndex = 16;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = false;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(70, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(70, 153);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Address";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(186, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Username";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(70, 33);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Name";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(54, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = "Update User Information";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // loggedinTag
            // 
            this.loggedinTag.AutoSize = true;
            this.loggedinTag.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedinTag.Location = new System.Drawing.Point(2, 59);
            this.loggedinTag.Name = "loggedinTag";
            this.loggedinTag.Size = new System.Drawing.Size(70, 22);
            this.loggedinTag.TabIndex = 49;
            this.loggedinTag.Text = "lfleck";
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeLabel.Location = new System.Drawing.Point(335, 215);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(80, 22);
            this.outcomeLabel.TabIndex = 50;
            this.outcomeLabel.Text = "YouWin!";
            // 
            // balChange
            // 
            this.balChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.balChange.BorderColor = System.Drawing.Color.Gray;
            this.balChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balChange.ForeColor = System.Drawing.Color.Gray;
            this.balChange.Location = new System.Drawing.Point(73, 210);
            this.balChange.Margin = new System.Windows.Forms.Padding(2);
            this.balChange.Name = "balChange";
            this.balChange.Size = new System.Drawing.Size(222, 24);
            this.balChange.TabIndex = 15;
            this.balChange.TextChanged += new System.EventHandler(this.balChange_TextChanged);
            // 
            // phoneChange
            // 
            this.phoneChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.phoneChange.BorderColor = System.Drawing.Color.Gray;
            this.phoneChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneChange.ForeColor = System.Drawing.Color.Gray;
            this.phoneChange.Location = new System.Drawing.Point(73, 88);
            this.phoneChange.Margin = new System.Windows.Forms.Padding(2);
            this.phoneChange.Name = "phoneChange";
            this.phoneChange.Size = new System.Drawing.Size(222, 24);
            this.phoneChange.TabIndex = 13;
            this.phoneChange.TextChanged += new System.EventHandler(this.phoneChange_TextChanged);
            // 
            // ccChange
            // 
            this.ccChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.ccChange.BorderColor = System.Drawing.Color.Gray;
            this.ccChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ccChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccChange.ForeColor = System.Drawing.Color.Gray;
            this.ccChange.Location = new System.Drawing.Point(73, 129);
            this.ccChange.Margin = new System.Windows.Forms.Padding(2);
            this.ccChange.Name = "ccChange";
            this.ccChange.Size = new System.Drawing.Size(222, 24);
            this.ccChange.TabIndex = 14;
            this.ccChange.TextChanged += new System.EventHandler(this.ccChange_TextChanged);
            // 
            // addChange
            // 
            this.addChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.addChange.BorderColor = System.Drawing.Color.Gray;
            this.addChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addChange.ForeColor = System.Drawing.Color.Gray;
            this.addChange.Location = new System.Drawing.Point(73, 169);
            this.addChange.Margin = new System.Windows.Forms.Padding(2);
            this.addChange.Name = "addChange";
            this.addChange.Size = new System.Drawing.Size(222, 24);
            this.addChange.TabIndex = 15;
            this.addChange.TextChanged += new System.EventHandler(this.addChange_TextChanged);
            // 
            // unsmaeChange
            // 
            this.unsmaeChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.unsmaeChange.BorderColor = System.Drawing.Color.Gray;
            this.unsmaeChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unsmaeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsmaeChange.ForeColor = System.Drawing.Color.Gray;
            this.unsmaeChange.Location = new System.Drawing.Point(190, 48);
            this.unsmaeChange.Margin = new System.Windows.Forms.Padding(2);
            this.unsmaeChange.Name = "unsmaeChange";
            this.unsmaeChange.Size = new System.Drawing.Size(105, 24);
            this.unsmaeChange.TabIndex = 12;
            this.unsmaeChange.TextChanged += new System.EventHandler(this.unsmaeChange_TextChanged);
            // 
            // passChange
            // 
            this.passChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.passChange.BorderColor = System.Drawing.Color.Gray;
            this.passChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passChange.ForeColor = System.Drawing.Color.Gray;
            this.passChange.Location = new System.Drawing.Point(73, 251);
            this.passChange.Margin = new System.Windows.Forms.Padding(2);
            this.passChange.Name = "passChange";
            this.passChange.PasswordChar = '*';
            this.passChange.Size = new System.Drawing.Size(126, 24);
            this.passChange.TabIndex = 16;
            this.passChange.TextChanged += new System.EventHandler(this.passChange_TextChanged);
            // 
            // nameChange
            // 
            this.nameChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.nameChange.BorderColor = System.Drawing.Color.Gray;
            this.nameChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameChange.ForeColor = System.Drawing.Color.Gray;
            this.nameChange.Location = new System.Drawing.Point(73, 48);
            this.nameChange.Margin = new System.Windows.Forms.Padding(2);
            this.nameChange.Name = "nameChange";
            this.nameChange.Size = new System.Drawing.Size(109, 24);
            this.nameChange.TabIndex = 11;
            this.nameChange.TextChanged += new System.EventHandler(this.nameChange_TextChanged);
            // 
            // splitHitButton
            // 
            this.splitHitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitHitButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitHitButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.splitHitButton.FlatAppearance.BorderSize = 0;
            this.splitHitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.splitHitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.splitHitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splitHitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitHitButton.Location = new System.Drawing.Point(443, 212);
            this.splitHitButton.Name = "splitHitButton";
            this.splitHitButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitHitButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitHitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.splitHitButton.Size = new System.Drawing.Size(79, 36);
            this.splitHitButton.TabIndex = 48;
            this.splitHitButton.Text = "Hit";
            this.splitHitButton.TextColor = System.Drawing.Color.Black;
            this.splitHitButton.UseVisualStyleBackColor = true;
            this.splitHitButton.Visible = false;
            this.splitHitButton.Click += new System.EventHandler(this.splitHitButton_Click);
            // 
            // splitStandButton
            // 
            this.splitStandButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitStandButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitStandButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.splitStandButton.FlatAppearance.BorderSize = 0;
            this.splitStandButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.splitStandButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.splitStandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splitStandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitStandButton.Location = new System.Drawing.Point(206, 211);
            this.splitStandButton.Name = "splitStandButton";
            this.splitStandButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitStandButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitStandButton.OnHoverTextColor = System.Drawing.Color.White;
            this.splitStandButton.Size = new System.Drawing.Size(86, 36);
            this.splitStandButton.TabIndex = 47;
            this.splitStandButton.Text = "Stand";
            this.splitStandButton.TextColor = System.Drawing.Color.Black;
            this.splitStandButton.UseVisualStyleBackColor = true;
            this.splitStandButton.Visible = false;
            this.splitStandButton.Click += new System.EventHandler(this.splitStandButton_Click);
            // 
            // insuranceButton
            // 
            this.insuranceButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.insuranceButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.insuranceButton.FlatAppearance.BorderSize = 0;
            this.insuranceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.insuranceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.insuranceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insuranceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceButton.Location = new System.Drawing.Point(37, 211);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceButton.OnHoverTextColor = System.Drawing.Color.White;
            this.insuranceButton.Size = new System.Drawing.Size(91, 41);
            this.insuranceButton.TabIndex = 38;
            this.insuranceButton.Text = "Insurance";
            this.insuranceButton.TextColor = System.Drawing.Color.Black;
            this.insuranceButton.UseVisualStyleBackColor = true;
            this.insuranceButton.Visible = false;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // splitButton
            // 
            this.splitButton.BackColor = System.Drawing.Color.Transparent;
            this.splitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitButton.FlatAppearance.BorderSize = 0;
            this.splitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.splitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.splitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton.Location = new System.Drawing.Point(335, 240);
            this.splitButton.Name = "splitButton";
            this.splitButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.splitButton.Size = new System.Drawing.Size(74, 35);
            this.splitButton.TabIndex = 46;
            this.splitButton.Text = "Split";
            this.splitButton.TextColor = System.Drawing.Color.Black;
            this.splitButton.UseVisualStyleBackColor = false;
            this.splitButton.Visible = false;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // insuranceDecBet
            // 
            this.insuranceDecBet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceDecBet.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.insuranceDecBet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.insuranceDecBet.FlatAppearance.BorderSize = 0;
            this.insuranceDecBet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.insuranceDecBet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.insuranceDecBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insuranceDecBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceDecBet.Location = new System.Drawing.Point(52, 113);
            this.insuranceDecBet.Name = "insuranceDecBet";
            this.insuranceDecBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceDecBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceDecBet.OnHoverTextColor = System.Drawing.Color.White;
            this.insuranceDecBet.Size = new System.Drawing.Size(51, 30);
            this.insuranceDecBet.TabIndex = 31;
            this.insuranceDecBet.Text = "-";
            this.insuranceDecBet.TextColor = System.Drawing.Color.Black;
            this.insuranceDecBet.UseVisualStyleBackColor = true;
            this.insuranceDecBet.Visible = false;
            this.insuranceDecBet.Click += new System.EventHandler(this.insuranceDecBet_Click);
            // 
            // insuranceIncBet
            // 
            this.insuranceIncBet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceIncBet.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.insuranceIncBet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.insuranceIncBet.FlatAppearance.BorderSize = 0;
            this.insuranceIncBet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.insuranceIncBet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.insuranceIncBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insuranceIncBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceIncBet.Location = new System.Drawing.Point(52, 22);
            this.insuranceIncBet.Name = "insuranceIncBet";
            this.insuranceIncBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceIncBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceIncBet.OnHoverTextColor = System.Drawing.Color.White;
            this.insuranceIncBet.Size = new System.Drawing.Size(51, 31);
            this.insuranceIncBet.TabIndex = 30;
            this.insuranceIncBet.Text = "+";
            this.insuranceIncBet.TextColor = System.Drawing.Color.Black;
            this.insuranceIncBet.UseVisualStyleBackColor = true;
            this.insuranceIncBet.Visible = false;
            this.insuranceIncBet.Click += new System.EventHandler(this.insuranceIncBet_Click);
            // 
            // decBet
            // 
            this.decBet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.decBet.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.decBet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.decBet.FlatAppearance.BorderSize = 0;
            this.decBet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.decBet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.decBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBet.Location = new System.Drawing.Point(52, 113);
            this.decBet.Name = "decBet";
            this.decBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.decBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.decBet.OnHoverTextColor = System.Drawing.Color.White;
            this.decBet.Size = new System.Drawing.Size(51, 30);
            this.decBet.TabIndex = 29;
            this.decBet.Text = "-";
            this.decBet.TextColor = System.Drawing.Color.Black;
            this.decBet.UseVisualStyleBackColor = true;
            this.decBet.Click += new System.EventHandler(this.decBet_Click);
            // 
            // incBet
            // 
            this.incBet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.incBet.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.incBet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.incBet.FlatAppearance.BorderSize = 0;
            this.incBet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.incBet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.incBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incBet.Location = new System.Drawing.Point(52, 22);
            this.incBet.Name = "incBet";
            this.incBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.incBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.incBet.OnHoverTextColor = System.Drawing.Color.White;
            this.incBet.Size = new System.Drawing.Size(51, 31);
            this.incBet.TabIndex = 28;
            this.incBet.Text = "+";
            this.incBet.TextColor = System.Drawing.Color.Black;
            this.incBet.UseVisualStyleBackColor = true;
            this.incBet.Click += new System.EventHandler(this.incBet_Click);
            // 
            // hitButton
            // 
            this.hitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hitButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.hitButton.FlatAppearance.BorderSize = 0;
            this.hitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.hitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(443, 212);
            this.hitButton.Name = "hitButton";
            this.hitButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hitButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.hitButton.Size = new System.Drawing.Size(79, 36);
            this.hitButton.TabIndex = 27;
            this.hitButton.Text = "Hit";
            this.hitButton.TextColor = System.Drawing.Color.Black;
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.standButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.standButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.standButton.FlatAppearance.BorderSize = 0;
            this.standButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.standButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.Location = new System.Drawing.Point(206, 211);
            this.standButton.Name = "standButton";
            this.standButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.standButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.standButton.OnHoverTextColor = System.Drawing.Color.White;
            this.standButton.Size = new System.Drawing.Size(86, 36);
            this.standButton.TabIndex = 26;
            this.standButton.Text = "Stand";
            this.standButton.TextColor = System.Drawing.Color.Black;
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dealButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dealButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.dealButton.FlatAppearance.BorderSize = 0;
            this.dealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.dealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(292, 154);
            this.dealButton.Name = "dealButton";
            this.dealButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dealButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dealButton.OnHoverTextColor = System.Drawing.Color.White;
            this.dealButton.Size = new System.Drawing.Size(161, 58);
            this.dealButton.TabIndex = 25;
            this.dealButton.Text = "Deal Hand";
            this.dealButton.TextColor = System.Drawing.Color.Black;
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.Color.Turquoise;
            this.phoneBox.BorderColor = System.Drawing.Color.Gray;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.Gray;
            this.phoneBox.Location = new System.Drawing.Point(65, 143);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(246, 24);
            this.phoneBox.TabIndex = 3;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // creditCardBox
            // 
            this.creditCardBox.BackColor = System.Drawing.Color.Turquoise;
            this.creditCardBox.BorderColor = System.Drawing.Color.Gray;
            this.creditCardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditCardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardBox.ForeColor = System.Drawing.Color.Gray;
            this.creditCardBox.Location = new System.Drawing.Point(65, 181);
            this.creditCardBox.Name = "creditCardBox";
            this.creditCardBox.Size = new System.Drawing.Size(246, 24);
            this.creditCardBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Turquoise;
            this.passwordBox.BorderColor = System.Drawing.Color.Gray;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordBox.Location = new System.Drawing.Point(65, 261);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(246, 24);
            this.passwordBox.TabIndex = 6;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.Turquoise;
            this.addressBox.BorderColor = System.Drawing.Color.Gray;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.Gray;
            this.addressBox.Location = new System.Drawing.Point(65, 221);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(246, 24);
            this.addressBox.TabIndex = 5;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.Turquoise;
            this.usernameBox.BorderColor = System.Drawing.Color.Gray;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.Color.Gray;
            this.usernameBox.Location = new System.Drawing.Point(193, 101);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(118, 24);
            this.usernameBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Turquoise;
            this.nameBox.BorderColor = System.Drawing.Color.Gray;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Gray;
            this.nameBox.Location = new System.Drawing.Point(65, 101);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(118, 24);
            this.nameBox.TabIndex = 1;
            // 
            // confirmPasswordTextField
            // 
            this.confirmPasswordTextField.BackColor = System.Drawing.Color.Turquoise;
            this.confirmPasswordTextField.BorderColor = System.Drawing.Color.Gray;
            this.confirmPasswordTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextField.ForeColor = System.Drawing.Color.Gray;
            this.confirmPasswordTextField.Location = new System.Drawing.Point(63, 222);
            this.confirmPasswordTextField.Name = "confirmPasswordTextField";
            this.confirmPasswordTextField.PasswordChar = '*';
            this.confirmPasswordTextField.Size = new System.Drawing.Size(246, 24);
            this.confirmPasswordTextField.TabIndex = 10;
            this.confirmPasswordTextField.TextChanged += new System.EventHandler(this.MyTextBox3_TextChanged);
            // 
            // newPasswordTextField
            // 
            this.newPasswordTextField.BackColor = System.Drawing.Color.Turquoise;
            this.newPasswordTextField.BorderColor = System.Drawing.Color.Gray;
            this.newPasswordTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextField.ForeColor = System.Drawing.Color.Gray;
            this.newPasswordTextField.Location = new System.Drawing.Point(63, 151);
            this.newPasswordTextField.Name = "newPasswordTextField";
            this.newPasswordTextField.PasswordChar = '*';
            this.newPasswordTextField.Size = new System.Drawing.Size(246, 24);
            this.newPasswordTextField.TabIndex = 9;
            // 
            // verifyPhoneNum
            // 
            this.verifyPhoneNum.BackColor = System.Drawing.Color.Turquoise;
            this.verifyPhoneNum.BorderColor = System.Drawing.Color.Gray;
            this.verifyPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verifyPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyPhoneNum.ForeColor = System.Drawing.Color.Gray;
            this.verifyPhoneNum.Location = new System.Drawing.Point(63, 222);
            this.verifyPhoneNum.Name = "verifyPhoneNum";
            this.verifyPhoneNum.Size = new System.Drawing.Size(246, 24);
            this.verifyPhoneNum.TabIndex = 18;
            // 
            // verifyUsername
            // 
            this.verifyUsername.BackColor = System.Drawing.Color.Turquoise;
            this.verifyUsername.BorderColor = System.Drawing.Color.Gray;
            this.verifyUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verifyUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyUsername.ForeColor = System.Drawing.Color.Gray;
            this.verifyUsername.Location = new System.Drawing.Point(63, 151);
            this.verifyUsername.Name = "verifyUsername";
            this.verifyUsername.Size = new System.Drawing.Size(244, 24);
            this.verifyUsername.TabIndex = 17;
            // 
            // passwordBox2
            // 
            this.passwordBox2.BackColor = System.Drawing.Color.Turquoise;
            this.passwordBox2.BorderColor = System.Drawing.Color.Gray;
            this.passwordBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox2.ForeColor = System.Drawing.Color.Gray;
            this.passwordBox2.Location = new System.Drawing.Point(63, 230);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.PasswordChar = '*';
            this.passwordBox2.Size = new System.Drawing.Size(246, 24);
            this.passwordBox2.TabIndex = 8;
            // 
            // UserNameBox2
            // 
            this.UserNameBox2.BackColor = System.Drawing.Color.Turquoise;
            this.UserNameBox2.BorderColor = System.Drawing.Color.Gray;
            this.UserNameBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox2.ForeColor = System.Drawing.Color.Gray;
            this.UserNameBox2.Location = new System.Drawing.Point(63, 151);
            this.UserNameBox2.Name = "UserNameBox2";
            this.UserNameBox2.Size = new System.Drawing.Size(246, 24);
            this.UserNameBox2.TabIndex = 7;
            this.UserNameBox2.TextChanged += new System.EventHandler(this.UserNameBox2_TextChanged);
            // 
            // testButton
            // 
            this.testButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.testButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.testButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.testButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Location = new System.Drawing.Point(696, 466);
            this.testButton.Margin = new System.Windows.Forms.Padding(2);
            this.testButton.Name = "testButton";
            this.testButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.testButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.testButton.OnHoverTextColor = System.Drawing.Color.White;
            this.testButton.Size = new System.Drawing.Size(79, 33);
            this.testButton.TabIndex = 44;
            this.testButton.Text = "Test";
            this.testButton.TextColor = System.Drawing.Color.Black;
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.newPassPanel);
            this.Controls.Add(this.forgotPanel);
            this.Controls.Add(this.SignInPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand1)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand6)).EndInit();
            this.blinkPanel.ResumeLayout(false);
            this.newPassPanel.ResumeLayout(false);
            this.newPassPanel.PerformLayout();
            this.forgotPanel.ResumeLayout(false);
            this.forgotPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dealerHand1;
        private System.Windows.Forms.PictureBox dealerHand2;
        private System.Windows.Forms.PictureBox myHand1;
        private System.Windows.Forms.PictureBox myHand2;
        private System.Windows.Forms.PictureBox deckCard;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label moneyBal;
        private System.Windows.Forms.Label myTotalLabel;
        private System.Windows.Forms.Label myTotalVal;
        private System.Windows.Forms.Label dealerTotalLabel;
        private System.Windows.Forms.Label dealerTotalVal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.PictureBox myHand3;
        private System.Windows.Forms.PictureBox myHand4;
        private System.Windows.Forms.PictureBox myHand5;
        private System.Windows.Forms.PictureBox dealerHand3;
        private System.Windows.Forms.PictureBox dealerHand4;
        private System.Windows.Forms.PictureBox dealerHand5;
        private System.Windows.Forms.PictureBox closeButton;
        private ePOSOne.btnProduct.Button_WOC dealButton;
        private ePOSOne.btnProduct.Button_WOC standButton;
        private ePOSOne.btnProduct.Button_WOC hitButton;
        private ePOSOne.btnProduct.Button_WOC incBet;
        private ePOSOne.btnProduct.Button_WOC decBet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer BetTimer;
        private System.Windows.Forms.Panel blinkPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel underSignUp;
        private ePOSOne.btnProduct.MyTextBox nameBox;
        private ePOSOne.btnProduct.MyTextBox usernameBox;
        private ePOSOne.btnProduct.MyTextBox passwordBox;
        private ePOSOne.btnProduct.MyTextBox addressBox;
        private System.Windows.Forms.Label CreateAccount;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Button SignUpConfirm;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private ePOSOne.btnProduct.MyTextBox phoneBox;
        private System.Windows.Forms.Label ccLabel;
        private ePOSOne.btnProduct.MyTextBox creditCardBox;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.Button SignInConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernameLabel2;
        private System.Windows.Forms.Label welcomeBack;
        private ePOSOne.btnProduct.MyTextBox passwordBox2;
        private ePOSOne.btnProduct.MyTextBox UserNameBox2;
        private System.Windows.Forms.Panel underSignIn2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SignUpButton2;
        private System.Windows.Forms.Label forgotLabel;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Panel forgotPanel;
        private System.Windows.Forms.Label noUserLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label verifyUserLabel1;
        private System.Windows.Forms.Label UsernameLabelVerify;
        private System.Windows.Forms.Label label7;
        private ePOSOne.btnProduct.MyTextBox verifyPhoneNum;
        private ePOSOne.btnProduct.MyTextBox verifyUsername;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel newPassPanel;
        private System.Windows.Forms.Label passDontMatchLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button setPassword;
        private System.Windows.Forms.Label confirmNewPassword;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.Label label12;
        private ePOSOne.btnProduct.MyTextBox confirmPasswordTextField;
        private ePOSOne.btnProduct.MyTextBox newPasswordTextField;
        private System.Windows.Forms.Panel panel10;
        private ePOSOne.btnProduct.Button_WOC splitButton;
        private ePOSOne.btnProduct.Button_WOC insuranceButton;
        private Label insuranceLabel;
        private ePOSOne.btnProduct.Button_WOC insuranceDecBet;
        private ePOSOne.btnProduct.Button_WOC insuranceIncBet;
        private PictureBox myHand10;
        private PictureBox myHand9;
        private PictureBox myHand8;
        private PictureBox myHand7;
        private PictureBox myHand6;
        private Label myTotalVal2;
        private Label myTotalLabel2;
        private ePOSOne.btnProduct.Button_WOC testButton;
        private Panel settingsPanel;
        private Label label1;
        private ePOSOne.btnProduct.MyTextBox phoneChange;
        private Label label5;
        private ePOSOne.btnProduct.MyTextBox ccChange;
        private Button saveSettings;
        private Label label6;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ePOSOne.btnProduct.MyTextBox passChange;
        private ePOSOne.btnProduct.MyTextBox addChange;
        private ePOSOne.btnProduct.MyTextBox unsmaeChange;
        private ePOSOne.btnProduct.MyTextBox nameChange;
        private Button passChangebtn;
        private Label label17;
        private ePOSOne.btnProduct.MyTextBox balChange;
        private PictureBox SettingsButton;
        private Label CancelSettings;
        private Label signUpError;
        private Label label8;
        private ePOSOne.btnProduct.Button_WOC splitStandButton;
        private ePOSOne.btnProduct.Button_WOC splitHitButton;
        private Label loggedinTag;
        private Label outcomeLabel;
    }
}

