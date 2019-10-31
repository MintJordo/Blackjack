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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyBal = new System.Windows.Forms.Label();
            this.myTotalLabel = new System.Windows.Forms.Label();
            this.myTotalVal = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.dealerTotalVal = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incBet = new System.Windows.Forms.Button();
            this.decBet = new System.Windows.Forms.Button();
            this.betLabel = new System.Windows.Forms.Label();
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
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(16, 15);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(131, 40);
            this.moneyLabel.TabIndex = 7;
            this.moneyLabel.Text = "Money:";
            this.moneyLabel.Click += new System.EventHandler(this.moneyLabel_Click);
            // 
            // moneyBal
            // 
            this.moneyBal.AutoSize = true;
            this.moneyBal.Enabled = false;
            this.moneyBal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBal.Location = new System.Drawing.Point(148, 15);
            this.moneyBal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyBal.Name = "moneyBal";
            this.moneyBal.Size = new System.Drawing.Size(93, 40);
            this.moneyBal.TabIndex = 8;
            this.moneyBal.Text = "$100";
            this.moneyBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyBal.Click += new System.EventHandler(this.moneyBal_Click);
            // 
            // myTotalLabel
            // 
            this.myTotalLabel.AutoSize = true;
            this.myTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalLabel.Location = new System.Drawing.Point(428, 362);
            this.myTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myTotalLabel.Name = "myTotalLabel";
            this.myTotalLabel.Size = new System.Drawing.Size(131, 40);
            this.myTotalLabel.TabIndex = 9;
            this.myTotalLabel.Text = "Total:";
            this.myTotalLabel.Click += new System.EventHandler(this.myTotal_Click);
            // 
            // myTotalVal
            // 
            this.myTotalVal.AutoSize = true;
            this.myTotalVal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalVal.Location = new System.Drawing.Point(560, 362);
            this.myTotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myTotalVal.Name = "myTotalVal";
            this.myTotalVal.Size = new System.Drawing.Size(36, 40);
            this.myTotalVal.TabIndex = 10;
            this.myTotalVal.Text = "0";
            this.myTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myTotalVal.Click += new System.EventHandler(this.myTotalVal_Click);
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalLabel.Location = new System.Drawing.Point(428, 164);
            this.dealerTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(131, 40);
            this.dealerTotalLabel.TabIndex = 11;
            this.dealerTotalLabel.Text = "Total:";
            this.dealerTotalLabel.Click += new System.EventHandler(this.dealerTotalLabel_Click);
            // 
            // dealerTotalVal
            // 
            this.dealerTotalVal.AutoSize = true;
            this.dealerTotalVal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalVal.Location = new System.Drawing.Point(560, 164);
            this.dealerTotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerTotalVal.Name = "dealerTotalVal";
            this.dealerTotalVal.Size = new System.Drawing.Size(36, 40);
            this.dealerTotalVal.TabIndex = 12;
            this.dealerTotalVal.Text = "?";
            this.dealerTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dealerTotalVal.Click += new System.EventHandler(this.dealerTotalVal_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(652, 342);
            this.hitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(100, 28);
            this.hitButton.TabIndex = 13;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(295, 342);
            this.standButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(100, 28);
            this.standButton.TabIndex = 14;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.incBet);
            this.panel1.Controls.Add(this.decBet);
            this.panel1.Controls.Add(this.betLabel);
            this.panel1.Location = new System.Drawing.Point(24, 342);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 197);
            this.panel1.TabIndex = 16;
            // 
            // incBet
            // 
            this.incBet.BackColor = System.Drawing.Color.DarkGreen;
            this.incBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.incBet.Location = new System.Drawing.Point(81, 27);
            this.incBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incBet.Name = "incBet";
            this.incBet.Padding = new System.Windows.Forms.Padding(1);
            this.incBet.Size = new System.Drawing.Size(67, 39);
            this.incBet.TabIndex = 20;
            this.incBet.Text = "+";
            this.incBet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.incBet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incBet.UseVisualStyleBackColor = false;
            this.incBet.Click += new System.EventHandler(this.incBet_Click);
            // 
            // decBet
            // 
            this.decBet.BackColor = System.Drawing.Color.DarkGreen;
            this.decBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decBet.Location = new System.Drawing.Point(81, 135);
            this.decBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decBet.Name = "decBet";
            this.decBet.Padding = new System.Windows.Forms.Padding(1);
            this.decBet.Size = new System.Drawing.Size(67, 39);
            this.decBet.TabIndex = 19;
            this.decBet.Text = "-";
            this.decBet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.decBet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.decBet.UseVisualStyleBackColor = false;
            this.decBet.Click += new System.EventHandler(this.decBet_Click);
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(35, 81);
            this.betLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(150, 40);
            this.betLabel.TabIndex = 16;
            this.betLabel.Text = "Bet: $0";
            this.betLabel.Click += new System.EventHandler(this.betLabel_Click);
            // 
            // dealerHand5
            // 
            this.dealerHand5.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand5.BackgroundImage = global::BlackJack.Properties.Resources._10C;
            this.dealerHand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand5.Enabled = false;
            this.dealerHand5.Image = global::BlackJack.Properties.Resources.transparent;
            this.dealerHand5.Location = new System.Drawing.Point(576, 15);
            this.dealerHand5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealerHand5.Name = "dealerHand5";
            this.dealerHand5.Size = new System.Drawing.Size(97, 134);
            this.dealerHand5.TabIndex = 22;
            this.dealerHand5.TabStop = false;
            this.dealerHand5.Click += new System.EventHandler(this.DealerHand5_Click);
            // 
            // dealerHand4
            // 
            this.dealerHand4.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand4.BackgroundImage = global::BlackJack.Properties.Resources._9H;
            this.dealerHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand4.Location = new System.Drawing.Point(551, 15);
            this.dealerHand4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealerHand4.Name = "dealerHand4";
            this.dealerHand4.Size = new System.Drawing.Size(97, 134);
            this.dealerHand4.TabIndex = 21;
            this.dealerHand4.TabStop = false;
            // 
            // dealerHand3
            // 
            this.dealerHand3.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.dealerHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand3.Location = new System.Drawing.Point(523, 15);
            this.dealerHand3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealerHand3.Name = "dealerHand3";
            this.dealerHand3.Size = new System.Drawing.Size(97, 134);
            this.dealerHand3.TabIndex = 20;
            this.dealerHand3.TabStop = false;
            // 
            // myHand5
            // 
            this.myHand5.BackColor = System.Drawing.Color.Transparent;
            this.myHand5.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand5.Location = new System.Drawing.Point(576, 405);
            this.myHand5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myHand5.Name = "myHand5";
            this.myHand5.Size = new System.Drawing.Size(97, 134);
            this.myHand5.TabIndex = 19;
            this.myHand5.TabStop = false;
            this.myHand5.Click += new System.EventHandler(this.MyCard5_Click);
            // 
            // myHand4
            // 
            this.myHand4.BackColor = System.Drawing.Color.Transparent;
            this.myHand4.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand4.Location = new System.Drawing.Point(551, 405);
            this.myHand4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myHand4.Name = "myHand4";
            this.myHand4.Size = new System.Drawing.Size(97, 134);
            this.myHand4.TabIndex = 18;
            this.myHand4.TabStop = false;
            // 
            // myHand3
            // 
            this.myHand3.BackColor = System.Drawing.Color.Transparent;
            this.myHand3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand3.Location = new System.Drawing.Point(523, 405);
            this.myHand3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myHand3.Name = "myHand3";
            this.myHand3.Size = new System.Drawing.Size(97, 134);
            this.myHand3.TabIndex = 17;
            this.myHand3.TabStop = false;
            // 
            // deckCard
            // 
            this.deckCard.BackgroundImage = global::BlackJack.Properties.Resources.red_back;
            this.deckCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deckCard.Location = new System.Drawing.Point(717, 15);
            this.deckCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deckCard.Name = "deckCard";
            this.deckCard.Size = new System.Drawing.Size(97, 134);
            this.deckCard.TabIndex = 6;
            this.deckCard.TabStop = false;
            this.deckCard.Click += new System.EventHandler(this.deckCard_Click);
            // 
            // myHand2
            // 
            this.myHand2.BackColor = System.Drawing.Color.Transparent;
            this.myHand2.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand2.Location = new System.Drawing.Point(497, 405);
            this.myHand2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myHand2.Name = "myHand2";
            this.myHand2.Size = new System.Drawing.Size(97, 134);
            this.myHand2.TabIndex = 5;
            this.myHand2.TabStop = false;
            this.myHand2.Click += new System.EventHandler(this.myHand2_Click);
            // 
            // myHand1
            // 
            this.myHand1.BackColor = System.Drawing.Color.Transparent;
            this.myHand1.BackgroundImage = global::BlackJack.Properties.Resources._10C;
            this.myHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myHand1.Location = new System.Drawing.Point(471, 405);
            this.myHand1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myHand1.Name = "myHand1";
            this.myHand1.Size = new System.Drawing.Size(97, 134);
            this.myHand1.TabIndex = 4;
            this.myHand1.TabStop = false;
            this.myHand1.Click += new System.EventHandler(this.myHand1_Click);
            // 
            // dealerHand2
            // 
            this.dealerHand2.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand2.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.dealerHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand2.Location = new System.Drawing.Point(497, 15);
            this.dealerHand2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealerHand2.Name = "dealerHand2";
            this.dealerHand2.Size = new System.Drawing.Size(97, 134);
            this.dealerHand2.TabIndex = 3;
            this.dealerHand2.TabStop = false;
            this.dealerHand2.Click += new System.EventHandler(this.dealerHand2_Click);
            // 
            // dealerHand1
            // 
            this.dealerHand1.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand1.BackgroundImage = global::BlackJack.Properties.Resources._9H;
            this.dealerHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand1.Location = new System.Drawing.Point(471, 15);
            this.dealerHand1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealerHand1.Name = "dealerHand1";
            this.dealerHand1.Size = new System.Drawing.Size(97, 134);
            this.dealerHand1.TabIndex = 2;
            this.dealerHand1.TabStop = false;
            this.dealerHand1.Click += new System.EventHandler(this.dealerHand1_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::BlackJack.Properties.Resources.x;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(1028, 7);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 23;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(425, 250);
            this.dealButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(199, 60);
            this.dealButton.TabIndex = 24;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dealerHand5);
            this.Controls.Add(this.dealerHand4);
            this.Controls.Add(this.dealerHand3);
            this.Controls.Add(this.myHand5);
            this.Controls.Add(this.myHand4);
            this.Controls.Add(this.myHand3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealerTotalVal);
            this.Controls.Add(this.dealerTotalLabel);
            this.Controls.Add(this.myTotalVal);
            this.Controls.Add(this.myTotalLabel);
            this.Controls.Add(this.moneyBal);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.deckCard);
            this.Controls.Add(this.myHand2);
            this.Controls.Add(this.myHand1);
            this.Controls.Add(this.dealerHand2);
            this.Controls.Add(this.dealerHand1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Button incBet;
        private System.Windows.Forms.Button decBet;
        private System.Windows.Forms.PictureBox myHand3;
        private System.Windows.Forms.PictureBox myHand4;
        private System.Windows.Forms.PictureBox myHand5;
        private System.Windows.Forms.PictureBox dealerHand3;
        private System.Windows.Forms.PictureBox dealerHand4;
        private System.Windows.Forms.PictureBox dealerHand5;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button dealButton;
    }
}

