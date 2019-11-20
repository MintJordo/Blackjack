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
            this.insuranceDecBet = new ePOSOne.btnProduct.Button_WOC();
            this.insuranceIncBet = new ePOSOne.btnProduct.Button_WOC();
            this.decBet = new ePOSOne.btnProduct.Button_WOC();
            this.incBet = new ePOSOne.btnProduct.Button_WOC();
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
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.insuranceButton = new ePOSOne.btnProduct.Button_WOC();
            this.splitButton = new ePOSOne.btnProduct.Button_WOC();
            this.blinkPanel = new System.Windows.Forms.Panel();
            this.hitButton = new ePOSOne.btnProduct.Button_WOC();
            this.standButton = new ePOSOne.btnProduct.Button_WOC();
            this.dealButton = new ePOSOne.btnProduct.Button_WOC();
            this.newPassPanel = new System.Windows.Forms.Panel();
            this.passDontMatchLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.setPassword = new System.Windows.Forms.Button();
            this.confirmNewPassword = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.confirmPasswordTextField = new ePOSOne.btnProduct.MyTextBox();
            this.newPasswordTextField = new ePOSOne.btnProduct.MyTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.forgotPanel = new System.Windows.Forms.Panel();
            this.noUserLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.verifyUserLabel1 = new System.Windows.Forms.Label();
            this.UsernameLabelVerify = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.verifyPhoneNum = new ePOSOne.btnProduct.MyTextBox();
            this.verifyUsername = new ePOSOne.btnProduct.MyTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneBox = new ePOSOne.btnProduct.MyTextBox();
            this.ccLabel = new System.Windows.Forms.Label();
            this.creditCardBox = new ePOSOne.btnProduct.MyTextBox();
            this.SignUpConfirm = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Label();
            this.passwordBox = new ePOSOne.btnProduct.MyTextBox();
            this.addressBox = new ePOSOne.btnProduct.MyTextBox();
            this.usernameBox = new ePOSOne.btnProduct.MyTextBox();
            this.nameBox = new ePOSOne.btnProduct.MyTextBox();
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
            this.passwordBox2 = new ePOSOne.btnProduct.MyTextBox();
            this.UserNameBox2 = new ePOSOne.btnProduct.MyTextBox();
            this.underSignIn2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SignUpButton2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.blinkPanel.SuspendLayout();
            this.newPassPanel.SuspendLayout();
            this.forgotPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(10, 9);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(158, 48);
            this.moneyLabel.TabIndex = 7;
            this.moneyLabel.Text = "Money:";
            this.moneyLabel.Click += new System.EventHandler(this.moneyLabel_Click);
            // 
            // moneyBal
            // 
            this.moneyBal.AutoSize = true;
            this.moneyBal.Enabled = false;
            this.moneyBal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBal.Location = new System.Drawing.Point(158, 14);
            this.moneyBal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyBal.Name = "moneyBal";
            this.moneyBal.Size = new System.Drawing.Size(112, 48);
            this.moneyBal.TabIndex = 8;
            this.moneyBal.Text = "$100";
            this.moneyBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyBal.Click += new System.EventHandler(this.moneyBal_Click);
            // 
            // myTotalLabel
            // 
            this.myTotalLabel.AutoSize = true;
            this.myTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalLabel.Location = new System.Drawing.Point(460, 426);
            this.myTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myTotalLabel.Name = "myTotalLabel";
            this.myTotalLabel.Size = new System.Drawing.Size(158, 48);
            this.myTotalLabel.TabIndex = 9;
            this.myTotalLabel.Text = "Total:";
            this.myTotalLabel.Click += new System.EventHandler(this.myTotal_Click);
            // 
            // myTotalVal
            // 
            this.myTotalVal.AutoSize = true;
            this.myTotalVal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalVal.Location = new System.Drawing.Point(609, 426);
            this.myTotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myTotalVal.Name = "myTotalVal";
            this.myTotalVal.Size = new System.Drawing.Size(43, 48);
            this.myTotalVal.TabIndex = 10;
            this.myTotalVal.Text = "0";
            this.myTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myTotalVal.Click += new System.EventHandler(this.myTotalVal_Click);
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalLabel.Location = new System.Drawing.Point(460, 188);
            this.dealerTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(158, 48);
            this.dealerTotalLabel.TabIndex = 11;
            this.dealerTotalLabel.Text = "Total:";
            this.dealerTotalLabel.Click += new System.EventHandler(this.dealerTotalLabel_Click);
            // 
            // dealerTotalVal
            // 
            this.dealerTotalVal.AutoSize = true;
            this.dealerTotalVal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalVal.Location = new System.Drawing.Point(609, 188);
            this.dealerTotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerTotalVal.Name = "dealerTotalVal";
            this.dealerTotalVal.Size = new System.Drawing.Size(43, 48);
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
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 246);
            this.panel1.TabIndex = 16;
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
            this.insuranceDecBet.Location = new System.Drawing.Point(75, 162);
            this.insuranceDecBet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insuranceDecBet.Name = "insuranceDecBet";
            this.insuranceDecBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceDecBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceDecBet.OnHoverTextColor = System.Drawing.Color.White;
            this.insuranceDecBet.Size = new System.Drawing.Size(81, 49);
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
            this.insuranceIncBet.Location = new System.Drawing.Point(74, 43);
            this.insuranceIncBet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insuranceIncBet.Name = "insuranceIncBet";
            this.insuranceIncBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceIncBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceIncBet.OnHoverTextColor = System.Drawing.Color.White;
            this.insuranceIncBet.Size = new System.Drawing.Size(81, 49);
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
            this.decBet.Location = new System.Drawing.Point(75, 162);
            this.decBet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decBet.Name = "decBet";
            this.decBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.decBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.decBet.OnHoverTextColor = System.Drawing.Color.White;
            this.decBet.Size = new System.Drawing.Size(81, 49);
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
            this.incBet.Location = new System.Drawing.Point(74, 43);
            this.incBet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incBet.Name = "incBet";
            this.incBet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.incBet.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.incBet.OnHoverTextColor = System.Drawing.Color.White;
            this.incBet.Size = new System.Drawing.Size(81, 49);
            this.incBet.TabIndex = 28;
            this.incBet.Text = "+";
            this.incBet.TextColor = System.Drawing.Color.Black;
            this.incBet.UseVisualStyleBackColor = true;
            this.incBet.Click += new System.EventHandler(this.incBet_Click);
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(26, 102);
            this.betLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(181, 48);
            this.betLabel.TabIndex = 16;
            this.betLabel.Text = "Bet: $0";
            this.betLabel.Click += new System.EventHandler(this.betLabel_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::BlackJack.Properties.Resources.x;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(1150, 18);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 31);
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
            this.dealerHand5.Location = new System.Drawing.Point(627, 8);
            this.dealerHand5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealerHand5.Name = "dealerHand5";
            this.dealerHand5.Size = new System.Drawing.Size(110, 168);
            this.dealerHand5.TabIndex = 22;
            this.dealerHand5.TabStop = false;
            this.dealerHand5.Click += new System.EventHandler(this.DealerHand5_Click);
            // 
            // dealerHand4
            // 
            this.dealerHand4.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand4.BackgroundImage = global::BlackJack.Properties.Resources._9H;
            this.dealerHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand4.Location = new System.Drawing.Point(598, 8);
            this.dealerHand4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealerHand4.Name = "dealerHand4";
            this.dealerHand4.Size = new System.Drawing.Size(110, 168);
            this.dealerHand4.TabIndex = 21;
            this.dealerHand4.TabStop = false;
            // 
            // dealerHand3
            // 
            this.dealerHand3.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.dealerHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand3.Location = new System.Drawing.Point(567, 8);
            this.dealerHand3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealerHand3.Name = "dealerHand3";
            this.dealerHand3.Size = new System.Drawing.Size(110, 168);
            this.dealerHand3.TabIndex = 20;
            this.dealerHand3.TabStop = false;
            // 
            // myHand5
            // 
            this.myHand5.BackColor = System.Drawing.Color.Transparent;
            this.myHand5.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand5.Location = new System.Drawing.Point(753, 475);
            this.myHand5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myHand5.Name = "myHand5";
            this.myHand5.Size = new System.Drawing.Size(110, 168);
            this.myHand5.TabIndex = 19;
            this.myHand5.TabStop = false;
            this.myHand5.Click += new System.EventHandler(this.MyCard5_Click);
            // 
            // myHand4
            // 
            this.myHand4.BackColor = System.Drawing.Color.Transparent;
            this.myHand4.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand4.Location = new System.Drawing.Point(724, 475);
            this.myHand4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myHand4.Name = "myHand4";
            this.myHand4.Size = new System.Drawing.Size(110, 168);
            this.myHand4.TabIndex = 18;
            this.myHand4.TabStop = false;
            // 
            // myHand3
            // 
            this.myHand3.BackColor = System.Drawing.Color.Transparent;
            this.myHand3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand3.Location = new System.Drawing.Point(693, 475);
            this.myHand3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myHand3.Name = "myHand3";
            this.myHand3.Size = new System.Drawing.Size(110, 168);
            this.myHand3.TabIndex = 17;
            this.myHand3.TabStop = false;
            // 
            // deckCard
            // 
            this.deckCard.BackgroundImage = global::BlackJack.Properties.Resources.red_back;
            this.deckCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deckCard.Location = new System.Drawing.Point(786, 2);
            this.deckCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deckCard.Name = "deckCard";
            this.deckCard.Size = new System.Drawing.Size(110, 168);
            this.deckCard.TabIndex = 6;
            this.deckCard.TabStop = false;
            this.deckCard.Click += new System.EventHandler(this.deckCard_Click);
            // 
            // myHand2
            // 
            this.myHand2.BackColor = System.Drawing.Color.Transparent;
            this.myHand2.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand2.Location = new System.Drawing.Point(664, 475);
            this.myHand2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myHand2.Name = "myHand2";
            this.myHand2.Size = new System.Drawing.Size(110, 168);
            this.myHand2.TabIndex = 5;
            this.myHand2.TabStop = false;
            this.myHand2.Click += new System.EventHandler(this.myHand2_Click);
            // 
            // myHand1
            // 
            this.myHand1.BackColor = System.Drawing.Color.Transparent;
            this.myHand1.BackgroundImage = global::BlackJack.Properties.Resources._10C;
            this.myHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand1.Location = new System.Drawing.Point(634, 475);
            this.myHand1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myHand1.Name = "myHand1";
            this.myHand1.Size = new System.Drawing.Size(110, 168);
            this.myHand1.TabIndex = 4;
            this.myHand1.TabStop = false;
            this.myHand1.Click += new System.EventHandler(this.myHand1_Click);
            // 
            // dealerHand2
            // 
            this.dealerHand2.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand2.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.dealerHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand2.Location = new System.Drawing.Point(538, 8);
            this.dealerHand2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealerHand2.Name = "dealerHand2";
            this.dealerHand2.Size = new System.Drawing.Size(110, 168);
            this.dealerHand2.TabIndex = 3;
            this.dealerHand2.TabStop = false;
            this.dealerHand2.Click += new System.EventHandler(this.dealerHand2_Click);
            // 
            // dealerHand1
            // 
            this.dealerHand1.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand1.BackgroundImage = global::BlackJack.Properties.Resources._9H;
            this.dealerHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand1.Location = new System.Drawing.Point(508, 8);
            this.dealerHand1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealerHand1.Name = "dealerHand1";
            this.dealerHand1.Size = new System.Drawing.Size(110, 168);
            this.dealerHand1.TabIndex = 2;
            this.dealerHand1.TabStop = false;
            this.dealerHand1.Click += new System.EventHandler(this.dealerHand1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(-8, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 15);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(-8, 677);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1212, 15);
            this.panel3.TabIndex = 29;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Green;
            this.GamePanel.Controls.Add(this.insuranceLabel);
            this.GamePanel.Controls.Add(this.pictureBox1);
            this.GamePanel.Controls.Add(this.pictureBox2);
            this.GamePanel.Controls.Add(this.pictureBox3);
            this.GamePanel.Controls.Add(this.pictureBox4);
            this.GamePanel.Controls.Add(this.pictureBox5);
            this.GamePanel.Controls.Add(this.insuranceButton);
            this.GamePanel.Controls.Add(this.splitButton);
            this.GamePanel.Controls.Add(this.blinkPanel);
            this.GamePanel.Controls.Add(this.hitButton);
            this.GamePanel.Controls.Add(this.standButton);
            this.GamePanel.Controls.Add(this.dealButton);
            this.GamePanel.Controls.Add(this.dealerHand5);
            this.GamePanel.Controls.Add(this.dealerHand4);
            this.GamePanel.Controls.Add(this.moneyBal);
            this.GamePanel.Controls.Add(this.dealerHand3);
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
            this.GamePanel.Controls.Add(this.dealerHand2);
            this.GamePanel.Controls.Add(this.dealerHand1);
            this.GamePanel.Location = new System.Drawing.Point(46, 612);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(1130, 652);
            this.GamePanel.TabIndex = 32;
            this.GamePanel.Visible = false;
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.AutoSize = true;
            this.insuranceLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceLabel.Location = new System.Drawing.Point(12, 266);
            this.insuranceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(319, 48);
            this.insuranceLabel.TabIndex = 39;
            this.insuranceLabel.Text = "Insurance: $0";
            this.insuranceLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(480, 475);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 168);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(452, 475);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 168);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(420, 475);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 168);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(392, 475);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 168);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::BlackJack.Properties.Resources._10C;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(362, 475);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 168);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
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
            this.insuranceButton.Location = new System.Drawing.Point(56, 325);
            this.insuranceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.insuranceButton.OnHoverTextColor = System.Drawing.Color.White;
            this.insuranceButton.Size = new System.Drawing.Size(136, 63);
            this.insuranceButton.TabIndex = 38;
            this.insuranceButton.Text = "Insurance";
            this.insuranceButton.TextColor = System.Drawing.Color.Black;
            this.insuranceButton.UseVisualStyleBackColor = true;
            this.insuranceButton.Visible = false;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // splitButton
            // 
            this.splitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.splitButton.FlatAppearance.BorderSize = 0;
            this.splitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.splitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.splitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton.Location = new System.Drawing.Point(501, 372);
            this.splitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitButton.Name = "splitButton";
            this.splitButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.splitButton.Size = new System.Drawing.Size(123, 49);
            this.splitButton.TabIndex = 37;
            this.splitButton.Text = "Split";
            this.splitButton.TextColor = System.Drawing.Color.Black;
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Visible = false;
            // 
            // blinkPanel
            // 
            this.blinkPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.blinkPanel.Controls.Add(this.panel1);
            this.blinkPanel.Location = new System.Drawing.Point(3, 392);
            this.blinkPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blinkPanel.Name = "blinkPanel";
            this.blinkPanel.Size = new System.Drawing.Size(249, 255);
            this.blinkPanel.TabIndex = 30;
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
            this.hitButton.Location = new System.Drawing.Point(700, 392);
            this.hitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hitButton.Name = "hitButton";
            this.hitButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hitButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.hitButton.Size = new System.Drawing.Size(123, 49);
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
            this.standButton.Location = new System.Drawing.Point(296, 392);
            this.standButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.standButton.Name = "standButton";
            this.standButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.standButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.standButton.OnHoverTextColor = System.Drawing.Color.White;
            this.standButton.Size = new System.Drawing.Size(123, 49);
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
            this.dealButton.Location = new System.Drawing.Point(410, 262);
            this.dealButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealButton.Name = "dealButton";
            this.dealButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dealButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dealButton.OnHoverTextColor = System.Drawing.Color.White;
            this.dealButton.Size = new System.Drawing.Size(308, 95);
            this.dealButton.TabIndex = 25;
            this.dealButton.Text = "Deal Hand";
            this.dealButton.TextColor = System.Drawing.Color.Black;
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButton_Click);
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
            this.newPassPanel.Location = new System.Drawing.Point(1420, 591);
            this.newPassPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPassPanel.Name = "newPassPanel";
            this.newPassPanel.Size = new System.Drawing.Size(564, 542);
            this.newPassPanel.TabIndex = 36;
            this.newPassPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.newPassPanel_Paint);
            // 
            // passDontMatchLabel
            // 
            this.passDontMatchLabel.AutoSize = true;
            this.passDontMatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.passDontMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passDontMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passDontMatchLabel.Location = new System.Drawing.Point(153, 394);
            this.passDontMatchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passDontMatchLabel.Name = "passDontMatchLabel";
            this.passDontMatchLabel.Size = new System.Drawing.Size(275, 29);
            this.passDontMatchLabel.TabIndex = 18;
            this.passDontMatchLabel.Text = "Passwords do not match";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(242, 508);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cancel";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // setPassword
            // 
            this.setPassword.BackColor = System.Drawing.Color.Black;
            this.setPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setPassword.FlatAppearance.BorderSize = 0;
            this.setPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPassword.ForeColor = System.Drawing.Color.White;
            this.setPassword.Location = new System.Drawing.Point(94, 437);
            this.setPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setPassword.Name = "setPassword";
            this.setPassword.Size = new System.Drawing.Size(369, 54);
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
            this.confirmNewPassword.Location = new System.Drawing.Point(90, 309);
            this.confirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmNewPassword.Name = "confirmNewPassword";
            this.confirmNewPassword.Size = new System.Drawing.Size(215, 25);
            this.confirmNewPassword.TabIndex = 15;
            this.confirmNewPassword.Text = "Confirm New Password";
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.BackColor = System.Drawing.Color.Transparent;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.Color.Gray;
            this.newPassword.Location = new System.Drawing.Point(93, 203);
            this.newPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(142, 25);
            this.newPassword.TabIndex = 13;
            this.newPassword.Text = "New Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(417, 37);
            this.label12.TabIndex = 11;
            this.label12.Text = "Please enter new password.";
            // 
            // confirmPasswordTextField
            // 
            this.confirmPasswordTextField.BackColor = System.Drawing.Color.Turquoise;
            this.confirmPasswordTextField.BorderColor = System.Drawing.Color.Gray;
            this.confirmPasswordTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextField.ForeColor = System.Drawing.Color.Gray;
            this.confirmPasswordTextField.Location = new System.Drawing.Point(94, 342);
            this.confirmPasswordTextField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswordTextField.Name = "confirmPasswordTextField";
            this.confirmPasswordTextField.PasswordChar = '*';
            this.confirmPasswordTextField.Size = new System.Drawing.Size(368, 33);
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
            this.newPasswordTextField.Location = new System.Drawing.Point(94, 232);
            this.newPasswordTextField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPasswordTextField.Name = "newPasswordTextField";
            this.newPasswordTextField.PasswordChar = '*';
            this.newPasswordTextField.Size = new System.Drawing.Size(368, 33);
            this.newPasswordTextField.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(98, 86);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(177, 5);
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
            this.forgotPanel.Location = new System.Drawing.Point(1420, 40);
            this.forgotPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forgotPanel.Name = "forgotPanel";
            this.forgotPanel.Size = new System.Drawing.Size(564, 542);
            this.forgotPanel.TabIndex = 35;
            // 
            // noUserLabel
            // 
            this.noUserLabel.AutoSize = true;
            this.noUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.noUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noUserLabel.ForeColor = System.Drawing.Color.Red;
            this.noUserLabel.Location = new System.Drawing.Point(104, 392);
            this.noUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noUserLabel.Name = "noUserLabel";
            this.noUserLabel.Size = new System.Drawing.Size(379, 29);
            this.noUserLabel.TabIndex = 18;
            this.noUserLabel.Text = "Information does not match a user.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(242, 508);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cancel";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // verifyButton
            // 
            this.verifyButton.BackColor = System.Drawing.Color.Black;
            this.verifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verifyButton.FlatAppearance.BorderSize = 0;
            this.verifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.verifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.White;
            this.verifyButton.Location = new System.Drawing.Point(94, 437);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(369, 54);
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
            this.verifyUserLabel1.Location = new System.Drawing.Point(90, 309);
            this.verifyUserLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verifyUserLabel1.Name = "verifyUserLabel1";
            this.verifyUserLabel1.Size = new System.Drawing.Size(143, 25);
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
            this.UsernameLabelVerify.Location = new System.Drawing.Point(93, 203);
            this.UsernameLabelVerify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabelVerify.Name = "UsernameLabelVerify";
            this.UsernameLabelVerify.Size = new System.Drawing.Size(110, 25);
            this.UsernameLabelVerify.TabIndex = 13;
            this.UsernameLabelVerify.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(60, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(436, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Please verify user information";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // verifyPhoneNum
            // 
            this.verifyPhoneNum.BackColor = System.Drawing.Color.Turquoise;
            this.verifyPhoneNum.BorderColor = System.Drawing.Color.Gray;
            this.verifyPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verifyPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyPhoneNum.ForeColor = System.Drawing.Color.Gray;
            this.verifyPhoneNum.Location = new System.Drawing.Point(94, 342);
            this.verifyPhoneNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verifyPhoneNum.Name = "verifyPhoneNum";
            this.verifyPhoneNum.PasswordChar = '*';
            this.verifyPhoneNum.Size = new System.Drawing.Size(368, 33);
            this.verifyPhoneNum.TabIndex = 10;
            // 
            // verifyUsername
            // 
            this.verifyUsername.BackColor = System.Drawing.Color.Turquoise;
            this.verifyUsername.BorderColor = System.Drawing.Color.Gray;
            this.verifyUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verifyUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyUsername.ForeColor = System.Drawing.Color.Gray;
            this.verifyUsername.Location = new System.Drawing.Point(94, 232);
            this.verifyUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verifyUsername.Name = "verifyUsername";
            this.verifyUsername.Size = new System.Drawing.Size(368, 33);
            this.verifyUsername.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(98, 86);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(177, 5);
            this.panel9.TabIndex = 5;
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
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
            this.SignUpPanel.Location = new System.Drawing.Point(26, 48);
            this.SignUpPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(564, 542);
            this.SignUpPanel.TabIndex = 33;
            this.SignUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUpPanel_Paint);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Gray;
            this.phoneLabel.Location = new System.Drawing.Point(93, 225);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(130, 22);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone Number";
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.Color.Turquoise;
            this.phoneBox.BorderColor = System.Drawing.Color.Gray;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.Gray;
            this.phoneBox.Location = new System.Drawing.Point(98, 248);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(368, 33);
            this.phoneBox.TabIndex = 19;
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.BackColor = System.Drawing.Color.Transparent;
            this.ccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccLabel.ForeColor = System.Drawing.Color.Gray;
            this.ccLabel.Location = new System.Drawing.Point(93, 288);
            this.ccLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(170, 22);
            this.ccLabel.TabIndex = 18;
            this.ccLabel.Text = "Credit Card Number";
            // 
            // creditCardBox
            // 
            this.creditCardBox.BackColor = System.Drawing.Color.Turquoise;
            this.creditCardBox.BorderColor = System.Drawing.Color.Gray;
            this.creditCardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditCardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardBox.ForeColor = System.Drawing.Color.Gray;
            this.creditCardBox.Location = new System.Drawing.Point(98, 311);
            this.creditCardBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.creditCardBox.Name = "creditCardBox";
            this.creditCardBox.Size = new System.Drawing.Size(368, 33);
            this.creditCardBox.TabIndex = 17;
            // 
            // SignUpConfirm
            // 
            this.SignUpConfirm.BackColor = System.Drawing.Color.Black;
            this.SignUpConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignUpConfirm.FlatAppearance.BorderSize = 0;
            this.SignUpConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SignUpConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpConfirm.ForeColor = System.Drawing.Color.White;
            this.SignUpConfirm.Location = new System.Drawing.Point(98, 480);
            this.SignUpConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUpConfirm.Name = "SignUpConfirm";
            this.SignUpConfirm.Size = new System.Drawing.Size(369, 54);
            this.SignUpConfirm.TabIndex = 16;
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
            this.passwordLabel.Location = new System.Drawing.Point(93, 411);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(89, 22);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.Gray;
            this.addressLabel.Location = new System.Drawing.Point(93, 349);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(76, 22);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Gray;
            this.usernameLabel.Location = new System.Drawing.Point(285, 165);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 22);
            this.usernameLabel.TabIndex = 13;
            this.usernameLabel.Text = "Username";
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLabel.ForeColor = System.Drawing.Color.Gray;
            this.FirstLabel.Location = new System.Drawing.Point(93, 165);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(57, 22);
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
            this.CreateAccount.Location = new System.Drawing.Point(148, 115);
            this.CreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(263, 37);
            this.CreateAccount.TabIndex = 11;
            this.CreateAccount.Text = "Sign Up For Free";
            this.CreateAccount.Click += new System.EventHandler(this.Label1_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Turquoise;
            this.passwordBox.BorderColor = System.Drawing.Color.Gray;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordBox.Location = new System.Drawing.Point(98, 434);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(368, 33);
            this.passwordBox.TabIndex = 10;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.Turquoise;
            this.addressBox.BorderColor = System.Drawing.Color.Gray;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.Gray;
            this.addressBox.Location = new System.Drawing.Point(98, 372);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(368, 33);
            this.addressBox.TabIndex = 9;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.Turquoise;
            this.usernameBox.BorderColor = System.Drawing.Color.Gray;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.Color.Gray;
            this.usernameBox.Location = new System.Drawing.Point(290, 188);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(176, 33);
            this.usernameBox.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Turquoise;
            this.nameBox.BorderColor = System.Drawing.Color.Gray;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Gray;
            this.nameBox.Location = new System.Drawing.Point(98, 188);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(176, 33);
            this.nameBox.TabIndex = 7;
            // 
            // underSignUp
            // 
            this.underSignUp.Location = new System.Drawing.Point(98, 86);
            this.underSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.underSignUp.Name = "underSignUp";
            this.underSignUp.Size = new System.Drawing.Size(177, 5);
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
            this.SignInButton.Location = new System.Drawing.Point(290, 34);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(177, 54);
            this.SignInButton.TabIndex = 4;
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
            this.signUpButton.Location = new System.Drawing.Point(98, 34);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(177, 54);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(1185, -2);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 686);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 12);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 686);
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
            this.SignInPanel.Location = new System.Drawing.Point(598, 48);
            this.SignInPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(564, 542);
            this.SignInPanel.TabIndex = 34;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectLabel.Location = new System.Drawing.Point(58, 395);
            this.incorrectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(492, 29);
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
            this.forgotLabel.Location = new System.Drawing.Point(216, 505);
            this.forgotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotLabel.Name = "forgotLabel";
            this.forgotLabel.Size = new System.Drawing.Size(129, 20);
            this.forgotLabel.TabIndex = 17;
            this.forgotLabel.Text = "Forgot Password";
            this.forgotLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // SignInConfirm
            // 
            this.SignInConfirm.BackColor = System.Drawing.Color.Black;
            this.SignInConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignInConfirm.FlatAppearance.BorderSize = 0;
            this.SignInConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SignInConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInConfirm.ForeColor = System.Drawing.Color.White;
            this.SignInConfirm.Location = new System.Drawing.Point(94, 437);
            this.SignInConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignInConfirm.Name = "SignInConfirm";
            this.SignInConfirm.Size = new System.Drawing.Size(369, 54);
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
            this.label3.Location = new System.Drawing.Point(90, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel2.ForeColor = System.Drawing.Color.Gray;
            this.usernameLabel2.Location = new System.Drawing.Point(93, 203);
            this.usernameLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(110, 25);
            this.usernameLabel2.TabIndex = 13;
            this.usernameLabel2.Text = "User Name";
            // 
            // welcomeBack
            // 
            this.welcomeBack.AutoSize = true;
            this.welcomeBack.BackColor = System.Drawing.Color.Transparent;
            this.welcomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBack.ForeColor = System.Drawing.Color.White;
            this.welcomeBack.Location = new System.Drawing.Point(60, 123);
            this.welcomeBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeBack.Name = "welcomeBack";
            this.welcomeBack.Size = new System.Drawing.Size(432, 37);
            this.welcomeBack.TabIndex = 11;
            this.welcomeBack.Text = "Welcome Back! Please Login";
            // 
            // passwordBox2
            // 
            this.passwordBox2.BackColor = System.Drawing.Color.Turquoise;
            this.passwordBox2.BorderColor = System.Drawing.Color.Gray;
            this.passwordBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox2.ForeColor = System.Drawing.Color.Gray;
            this.passwordBox2.Location = new System.Drawing.Point(94, 348);
            this.passwordBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.PasswordChar = '*';
            this.passwordBox2.Size = new System.Drawing.Size(368, 33);
            this.passwordBox2.TabIndex = 10;
            // 
            // UserNameBox2
            // 
            this.UserNameBox2.BackColor = System.Drawing.Color.Turquoise;
            this.UserNameBox2.BorderColor = System.Drawing.Color.Gray;
            this.UserNameBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox2.ForeColor = System.Drawing.Color.Gray;
            this.UserNameBox2.Location = new System.Drawing.Point(94, 232);
            this.UserNameBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserNameBox2.Name = "UserNameBox2";
            this.UserNameBox2.Size = new System.Drawing.Size(368, 33);
            this.UserNameBox2.TabIndex = 8;
            this.UserNameBox2.TextChanged += new System.EventHandler(this.UserNameBox2_TextChanged);
            // 
            // underSignIn2
            // 
            this.underSignIn2.BackColor = System.Drawing.Color.DarkRed;
            this.underSignIn2.Location = new System.Drawing.Point(290, 86);
            this.underSignIn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.underSignIn2.Name = "underSignIn2";
            this.underSignIn2.Size = new System.Drawing.Size(177, 5);
            this.underSignIn2.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(98, 86);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 5);
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
            this.button2.Location = new System.Drawing.Point(290, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 54);
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
            this.SignUpButton2.Location = new System.Drawing.Point(98, 34);
            this.SignUpButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUpButton2.Name = "SignUpButton2";
            this.SignUpButton2.Size = new System.Drawing.Size(177, 54);
            this.SignUpButton2.TabIndex = 2;
            this.SignUpButton2.Text = "Sign Up";
            this.SignUpButton2.UseVisualStyleBackColor = false;
            this.SignUpButton2.Click += new System.EventHandler(this.SignUpButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.newPassPanel);
            this.Controls.Add(this.forgotPanel);
            this.Controls.Add(this.SignInPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.blinkPanel.ResumeLayout(false);
            this.newPassPanel.ResumeLayout(false);
            this.newPassPanel.PerformLayout();
            this.forgotPanel.ResumeLayout(false);
            this.forgotPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}

