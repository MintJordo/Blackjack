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
            this.myCard5 = new System.Windows.Forms.PictureBox();
            this.myCard4 = new System.Windows.Forms.PictureBox();
            this.myCard3 = new System.Windows.Forms.PictureBox();
            this.deckCard = new System.Windows.Forms.PictureBox();
            this.myHand2 = new System.Windows.Forms.PictureBox();
            this.myHand1 = new System.Windows.Forms.PictureBox();
            this.dealerHand2 = new System.Windows.Forms.PictureBox();
            this.dealerHand1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand1)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(12, 12);
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
            this.moneyBal.Location = new System.Drawing.Point(111, 12);
            this.moneyBal.Name = "moneyBal";
            this.moneyBal.Size = new System.Drawing.Size(75, 32);
            this.moneyBal.TabIndex = 8;
            this.moneyBal.Text = "$100";
            this.moneyBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyBal.Click += new System.EventHandler(this.moneyBal_Click);
            // 
            // myTotalLabel
            // 
            this.myTotalLabel.AutoSize = true;
            this.myTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTotalLabel.Location = new System.Drawing.Point(321, 294);
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
            this.myTotalVal.Location = new System.Drawing.Point(420, 294);
            this.myTotalVal.Name = "myTotalVal";
            this.myTotalVal.Size = new System.Drawing.Size(45, 32);
            this.myTotalVal.TabIndex = 10;
            this.myTotalVal.Text = "12";
            this.myTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myTotalVal.Click += new System.EventHandler(this.myTotalVal_Click);
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalLabel.Location = new System.Drawing.Point(321, 133);
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
            this.dealerTotalVal.Location = new System.Drawing.Point(420, 133);
            this.dealerTotalVal.Name = "dealerTotalVal";
            this.dealerTotalVal.Size = new System.Drawing.Size(45, 32);
            this.dealerTotalVal.TabIndex = 12;
            this.dealerTotalVal.Text = "11";
            this.dealerTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dealerTotalVal.Click += new System.EventHandler(this.dealerTotalVal_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(489, 278);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 13;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(221, 278);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
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
            this.panel1.Location = new System.Drawing.Point(18, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 160);
            this.panel1.TabIndex = 16;
            // 
            // incBet
            // 
            this.incBet.BackColor = System.Drawing.Color.DarkGreen;
            this.incBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.incBet.Location = new System.Drawing.Point(61, 22);
            this.incBet.Name = "incBet";
            this.incBet.Padding = new System.Windows.Forms.Padding(1);
            this.incBet.Size = new System.Drawing.Size(50, 32);
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
            this.decBet.Location = new System.Drawing.Point(61, 110);
            this.decBet.Name = "decBet";
            this.decBet.Padding = new System.Windows.Forms.Padding(1);
            this.decBet.Size = new System.Drawing.Size(50, 32);
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
            this.betLabel.Location = new System.Drawing.Point(26, 66);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(120, 32);
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
            this.dealerHand5.Location = new System.Drawing.Point(432, 12);
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
            this.dealerHand4.Location = new System.Drawing.Point(413, 12);
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
            this.dealerHand3.Location = new System.Drawing.Point(392, 12);
            this.dealerHand3.Name = "dealerHand3";
            this.dealerHand3.Size = new System.Drawing.Size(73, 109);
            this.dealerHand3.TabIndex = 20;
            this.dealerHand3.TabStop = false;
            // 
            // myCard5
            // 
            this.myCard5.BackColor = System.Drawing.Color.Transparent;
            this.myCard5.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myCard5.Location = new System.Drawing.Point(432, 329);
            this.myCard5.Name = "myCard5";
            this.myCard5.Size = new System.Drawing.Size(73, 109);
            this.myCard5.TabIndex = 19;
            this.myCard5.TabStop = false;
            // 
            // myCard4
            // 
            this.myCard4.BackColor = System.Drawing.Color.Transparent;
            this.myCard4.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myCard4.Location = new System.Drawing.Point(413, 329);
            this.myCard4.Name = "myCard4";
            this.myCard4.Size = new System.Drawing.Size(73, 109);
            this.myCard4.TabIndex = 18;
            this.myCard4.TabStop = false;
            // 
            // myCard3
            // 
            this.myCard3.BackColor = System.Drawing.Color.Transparent;
            this.myCard3.BackgroundImage = global::BlackJack.Properties.Resources._2C;
            this.myCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myCard3.Location = new System.Drawing.Point(392, 329);
            this.myCard3.Name = "myCard3";
            this.myCard3.Size = new System.Drawing.Size(73, 109);
            this.myCard3.TabIndex = 17;
            this.myCard3.TabStop = false;
            // 
            // deckCard
            // 
            this.deckCard.BackgroundImage = global::BlackJack.Properties.Resources.red_back;
            this.deckCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deckCard.Location = new System.Drawing.Point(538, 12);
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
            this.myHand2.Location = new System.Drawing.Point(373, 329);
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
            this.myHand1.Location = new System.Drawing.Point(353, 329);
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
            this.dealerHand2.Location = new System.Drawing.Point(373, 12);
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
            this.dealerHand1.Location = new System.Drawing.Point(353, 12);
            this.dealerHand1.Name = "dealerHand1";
            this.dealerHand1.Size = new System.Drawing.Size(73, 109);
            this.dealerHand1.TabIndex = 2;
            this.dealerHand1.TabStop = false;
            this.dealerHand1.Click += new System.EventHandler(this.dealerHand1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dealerHand5);
            this.Controls.Add(this.dealerHand4);
            this.Controls.Add(this.dealerHand3);
            this.Controls.Add(this.myCard5);
            this.Controls.Add(this.myCard4);
            this.Controls.Add(this.myCard3);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand1)).EndInit();
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
        private System.Windows.Forms.PictureBox myCard3;
        private System.Windows.Forms.PictureBox myCard4;
        private System.Windows.Forms.PictureBox myCard5;
        private System.Windows.Forms.PictureBox dealerHand3;
        private System.Windows.Forms.PictureBox dealerHand4;
        private System.Windows.Forms.PictureBox dealerHand5;
    }
}

