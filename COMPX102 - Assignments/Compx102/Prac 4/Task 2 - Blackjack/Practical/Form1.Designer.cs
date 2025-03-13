namespace Practical
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
            this.buttonQuit_ = new System.Windows.Forms.Button();
            this.labelDealerTotal_ = new System.Windows.Forms.Label();
            this.labelPLayerTotal_ = new System.Windows.Forms.Label();
            this.textBoxDealerTotal_ = new System.Windows.Forms.TextBox();
            this.textBoxPlayerTotal_ = new System.Windows.Forms.TextBox();
            this.labelMoneyLeft_ = new System.Windows.Forms.Label();
            this.textBoxMoneyLeft_ = new System.Windows.Forms.TextBox();
            this.labelMoneyToBet_ = new System.Windows.Forms.Label();
            this.labelDealerCard1_ = new System.Windows.Forms.Label();
            this.textBoxBet_ = new System.Windows.Forms.TextBox();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.listBoxPlayer = new System.Windows.Forms.ListBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.listBoxDealer = new System.Windows.Forms.ListBox();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuit_
            // 
            this.buttonQuit_.Location = new System.Drawing.Point(260, 307);
            this.buttonQuit_.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuit_.Name = "buttonQuit_";
            this.buttonQuit_.Size = new System.Drawing.Size(154, 28);
            this.buttonQuit_.TabIndex = 56;
            this.buttonQuit_.Text = "Quit";
            this.buttonQuit_.UseVisualStyleBackColor = true;
            this.buttonQuit_.Click += new System.EventHandler(this.buttonQuit__Click);
            // 
            // labelDealerTotal_
            // 
            this.labelDealerTotal_.AutoSize = true;
            this.labelDealerTotal_.Location = new System.Drawing.Point(266, 161);
            this.labelDealerTotal_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDealerTotal_.Name = "labelDealerTotal_";
            this.labelDealerTotal_.Size = new System.Drawing.Size(68, 13);
            this.labelDealerTotal_.TabIndex = 55;
            this.labelDealerTotal_.Text = "Dealer\'s total";
            // 
            // labelPLayerTotal_
            // 
            this.labelPLayerTotal_.AutoSize = true;
            this.labelPLayerTotal_.Location = new System.Drawing.Point(44, 162);
            this.labelPLayerTotal_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPLayerTotal_.Name = "labelPLayerTotal_";
            this.labelPLayerTotal_.Size = new System.Drawing.Size(66, 13);
            this.labelPLayerTotal_.TabIndex = 54;
            this.labelPLayerTotal_.Text = "Player\'s total";
            // 
            // textBoxDealerTotal_
            // 
            this.textBoxDealerTotal_.Location = new System.Drawing.Point(260, 182);
            this.textBoxDealerTotal_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDealerTotal_.Name = "textBoxDealerTotal_";
            this.textBoxDealerTotal_.ReadOnly = true;
            this.textBoxDealerTotal_.Size = new System.Drawing.Size(133, 20);
            this.textBoxDealerTotal_.TabIndex = 53;
            // 
            // textBoxPlayerTotal_
            // 
            this.textBoxPlayerTotal_.Location = new System.Drawing.Point(39, 182);
            this.textBoxPlayerTotal_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlayerTotal_.Name = "textBoxPlayerTotal_";
            this.textBoxPlayerTotal_.ReadOnly = true;
            this.textBoxPlayerTotal_.Size = new System.Drawing.Size(128, 20);
            this.textBoxPlayerTotal_.TabIndex = 52;
            // 
            // labelMoneyLeft_
            // 
            this.labelMoneyLeft_.AutoSize = true;
            this.labelMoneyLeft_.Location = new System.Drawing.Point(28, 248);
            this.labelMoneyLeft_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyLeft_.Name = "labelMoneyLeft_";
            this.labelMoneyLeft_.Size = new System.Drawing.Size(56, 13);
            this.labelMoneyLeft_.TabIndex = 50;
            this.labelMoneyLeft_.Text = "Money left";
            // 
            // textBoxMoneyLeft_
            // 
            this.textBoxMoneyLeft_.Location = new System.Drawing.Point(99, 246);
            this.textBoxMoneyLeft_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMoneyLeft_.Name = "textBoxMoneyLeft_";
            this.textBoxMoneyLeft_.ReadOnly = true;
            this.textBoxMoneyLeft_.Size = new System.Drawing.Size(114, 20);
            this.textBoxMoneyLeft_.TabIndex = 49;
            // 
            // labelMoneyToBet_
            // 
            this.labelMoneyToBet_.AutoSize = true;
            this.labelMoneyToBet_.Location = new System.Drawing.Point(28, 281);
            this.labelMoneyToBet_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyToBet_.Name = "labelMoneyToBet_";
            this.labelMoneyToBet_.Size = new System.Drawing.Size(69, 13);
            this.labelMoneyToBet_.TabIndex = 48;
            this.labelMoneyToBet_.Text = "Money to bet";
            // 
            // labelDealerCard1_
            // 
            this.labelDealerCard1_.AutoSize = true;
            this.labelDealerCard1_.Location = new System.Drawing.Point(241, 8);
            this.labelDealerCard1_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDealerCard1_.Name = "labelDealerCard1_";
            this.labelDealerCard1_.Size = new System.Drawing.Size(41, 13);
            this.labelDealerCard1_.TabIndex = 46;
            this.labelDealerCard1_.Text = "Dealer:";
            // 
            // textBoxBet_
            // 
            this.textBoxBet_.Location = new System.Drawing.Point(99, 278);
            this.textBoxBet_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBet_.Name = "textBoxBet_";
            this.textBoxBet_.Size = new System.Drawing.Size(114, 20);
            this.textBoxBet_.TabIndex = 43;
            // 
            // buttonDeal
            // 
            this.buttonDeal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonDeal.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDeal.Location = new System.Drawing.Point(269, 219);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(133, 79);
            this.buttonDeal.TabIndex = 57;
            this.buttonDeal.Text = "Deal";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // listBoxPlayer
            // 
            this.listBoxPlayer.FormattingEnabled = true;
            this.listBoxPlayer.Location = new System.Drawing.Point(24, 27);
            this.listBoxPlayer.Name = "listBoxPlayer";
            this.listBoxPlayer.Size = new System.Drawing.Size(170, 121);
            this.listBoxPlayer.TabIndex = 58;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(24, 8);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(39, 13);
            this.labelPlayer.TabIndex = 59;
            this.labelPlayer.Text = "Player:";
            // 
            // listBoxDealer
            // 
            this.listBoxDealer.FormattingEnabled = true;
            this.listBoxDealer.Location = new System.Drawing.Point(244, 27);
            this.listBoxDealer.Name = "listBoxDealer";
            this.listBoxDealer.Size = new System.Drawing.Size(170, 121);
            this.listBoxDealer.TabIndex = 60;
            // 
            // buttonReplay
            // 
            this.buttonReplay.Location = new System.Drawing.Point(92, 310);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(121, 23);
            this.buttonReplay.TabIndex = 61;
            this.buttonReplay.Text = "Replay";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 356);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.listBoxDealer);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.listBoxPlayer);
            this.Controls.Add(this.buttonDeal);
            this.Controls.Add(this.buttonQuit_);
            this.Controls.Add(this.labelDealerTotal_);
            this.Controls.Add(this.labelPLayerTotal_);
            this.Controls.Add(this.textBoxDealerTotal_);
            this.Controls.Add(this.textBoxPlayerTotal_);
            this.Controls.Add(this.labelMoneyLeft_);
            this.Controls.Add(this.textBoxMoneyLeft_);
            this.Controls.Add(this.labelMoneyToBet_);
            this.Controls.Add(this.labelDealerCard1_);
            this.Controls.Add(this.textBoxBet_);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit_;
        private System.Windows.Forms.Label labelDealerTotal_;
        private System.Windows.Forms.Label labelPLayerTotal_;
        private System.Windows.Forms.TextBox textBoxDealerTotal_;
        private System.Windows.Forms.TextBox textBoxPlayerTotal_;
        private System.Windows.Forms.Label labelMoneyLeft_;
        private System.Windows.Forms.TextBox textBoxMoneyLeft_;
        private System.Windows.Forms.Label labelMoneyToBet_;
        private System.Windows.Forms.Label labelDealerCard1_;
        private System.Windows.Forms.TextBox textBoxBet_;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.ListBox listBoxPlayer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.ListBox listBoxDealer;
        private System.Windows.Forms.Button buttonReplay;
    }
}

