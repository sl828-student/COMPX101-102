namespace Assignment_2___Zombie_Dice
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
            System.Windows.Forms.ToolStripMenuItem gameModeSelectToolStripMenuItem;
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxRollResults = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.buttonRollDice = new System.Windows.Forms.Button();
            this.labelCurrentTurn = new System.Windows.Forms.Label();
            this.buttonEndTurn = new System.Windows.Forms.Button();
            this.labelPlayer1Current = new System.Windows.Forms.Label();
            this.labelPlayer1Brains = new System.Windows.Forms.Label();
            this.labelPlayer2Brains = new System.Windows.Forms.Label();
            this.labelPlayer1Shotguns = new System.Windows.Forms.Label();
            this.labelPlayer2Shotguns = new System.Windows.Forms.Label();
            this.labelQuote = new System.Windows.Forms.Label();
            gameModeSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(43, 43);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(337, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Zombie Dice";
            // 
            // listBoxRollResults
            // 
            this.listBoxRollResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRollResults.FormattingEnabled = true;
            this.listBoxRollResults.ItemHeight = 14;
            this.listBoxRollResults.Location = new System.Drawing.Point(23, 260);
            this.listBoxRollResults.Name = "listBoxRollResults";
            this.listBoxRollResults.Size = new System.Drawing.Size(233, 88);
            this.listBoxRollResults.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            gameModeSelectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameModeSelectToolStripMenuItem
            // 
            gameModeSelectToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            gameModeSelectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsComputerToolStripMenuItem});
            gameModeSelectToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gameModeSelectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            gameModeSelectToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Peru;
            gameModeSelectToolStripMenuItem.Name = "gameModeSelectToolStripMenuItem";
            gameModeSelectToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            gameModeSelectToolStripMenuItem.Text = "Click To Select Game Mode...";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.playerVsPlayerToolStripMenuItem.Text = "Player Vs. Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.playerVsPlayerToolStripMenuItem_Click);
            // 
            // playerVsComputerToolStripMenuItem
            // 
            this.playerVsComputerToolStripMenuItem.Name = "playerVsComputerToolStripMenuItem";
            this.playerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.playerVsComputerToolStripMenuItem.Text = "Player Vs. Computer";
            this.playerVsComputerToolStripMenuItem.Click += new System.EventHandler(this.playerVsComputerToolStripMenuItem_Click);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.Location = new System.Drawing.Point(74, 184);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(79, 19);
            this.labelPlayer1.TabIndex = 4;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.Location = new System.Drawing.Point(242, 184);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(79, 19);
            this.labelPlayer2.TabIndex = 5;
            this.labelPlayer2.Text = "Player 2:";
            // 
            // buttonRollDice
            // 
            this.buttonRollDice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRollDice.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollDice.Location = new System.Drawing.Point(262, 260);
            this.buttonRollDice.Name = "buttonRollDice";
            this.buttonRollDice.Size = new System.Drawing.Size(133, 66);
            this.buttonRollDice.TabIndex = 7;
            this.buttonRollDice.Text = "Roll Dice!";
            this.buttonRollDice.UseVisualStyleBackColor = false;
            this.buttonRollDice.Click += new System.EventHandler(this.buttonRollDice_Click);
            // 
            // labelCurrentTurn
            // 
            this.labelCurrentTurn.AutoSize = true;
            this.labelCurrentTurn.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTurn.ForeColor = System.Drawing.Color.Blue;
            this.labelCurrentTurn.Location = new System.Drawing.Point(120, 154);
            this.labelCurrentTurn.Name = "labelCurrentTurn";
            this.labelCurrentTurn.Size = new System.Drawing.Size(163, 16);
            this.labelCurrentTurn.TabIndex = 8;
            this.labelCurrentTurn.Text = "Player 1\'s Turn, Roll On!";
            // 
            // buttonEndTurn
            // 
            this.buttonEndTurn.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonEndTurn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndTurn.Location = new System.Drawing.Point(262, 332);
            this.buttonEndTurn.Name = "buttonEndTurn";
            this.buttonEndTurn.Size = new System.Drawing.Size(133, 23);
            this.buttonEndTurn.TabIndex = 9;
            this.buttonEndTurn.Text = "End Turn!";
            this.buttonEndTurn.UseVisualStyleBackColor = false;
            this.buttonEndTurn.Click += new System.EventHandler(this.buttonEndTurn_Click);
            // 
            // labelPlayer1Current
            // 
            this.labelPlayer1Current.AutoSize = true;
            this.labelPlayer1Current.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Current.Location = new System.Drawing.Point(20, 244);
            this.labelPlayer1Current.Name = "labelPlayer1Current";
            this.labelPlayer1Current.Size = new System.Drawing.Size(85, 14);
            this.labelPlayer1Current.TabIndex = 10;
            this.labelPlayer1Current.Text = "Current Roll:";
            // 
            // labelPlayer1Brains
            // 
            this.labelPlayer1Brains.AutoSize = true;
            this.labelPlayer1Brains.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Brains.Location = new System.Drawing.Point(89, 211);
            this.labelPlayer1Brains.Name = "labelPlayer1Brains";
            this.labelPlayer1Brains.Size = new System.Drawing.Size(62, 14);
            this.labelPlayer1Brains.TabIndex = 12;
            this.labelPlayer1Brains.Text = "Brains: 0";
            // 
            // labelPlayer2Brains
            // 
            this.labelPlayer2Brains.AutoSize = true;
            this.labelPlayer2Brains.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Brains.Location = new System.Drawing.Point(257, 210);
            this.labelPlayer2Brains.Name = "labelPlayer2Brains";
            this.labelPlayer2Brains.Size = new System.Drawing.Size(62, 14);
            this.labelPlayer2Brains.TabIndex = 13;
            this.labelPlayer2Brains.Text = "Brains: 0";
            // 
            // labelPlayer1Shotguns
            // 
            this.labelPlayer1Shotguns.AutoSize = true;
            this.labelPlayer1Shotguns.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Shotguns.Location = new System.Drawing.Point(89, 229);
            this.labelPlayer1Shotguns.Name = "labelPlayer1Shotguns";
            this.labelPlayer1Shotguns.Size = new System.Drawing.Size(80, 14);
            this.labelPlayer1Shotguns.TabIndex = 14;
            this.labelPlayer1Shotguns.Text = "Shotguns: 0";
            // 
            // labelPlayer2Shotguns
            // 
            this.labelPlayer2Shotguns.AutoSize = true;
            this.labelPlayer2Shotguns.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Shotguns.Location = new System.Drawing.Point(257, 229);
            this.labelPlayer2Shotguns.Name = "labelPlayer2Shotguns";
            this.labelPlayer2Shotguns.Size = new System.Drawing.Size(80, 14);
            this.labelPlayer2Shotguns.TabIndex = 15;
            this.labelPlayer2Shotguns.Text = "Shotguns: 0";
            // 
            // labelQuote
            // 
            this.labelQuote.AutoSize = true;
            this.labelQuote.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuote.Location = new System.Drawing.Point(12, 115);
            this.labelQuote.Name = "labelQuote";
            this.labelQuote.Size = new System.Drawing.Size(402, 30);
            this.labelQuote.TabIndex = 18;
            this.labelQuote.Text = "“Eat brains. Don\'t get shotgunned.”";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(416, 367);
            this.Controls.Add(this.labelQuote);
            this.Controls.Add(this.labelPlayer2Shotguns);
            this.Controls.Add(this.labelPlayer1Shotguns);
            this.Controls.Add(this.labelPlayer2Brains);
            this.Controls.Add(this.labelPlayer1Brains);
            this.Controls.Add(this.labelPlayer1Current);
            this.Controls.Add(this.buttonEndTurn);
            this.Controls.Add(this.labelCurrentTurn);
            this.Controls.Add(this.buttonRollDice);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.listBoxRollResults);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxRollResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerToolStripMenuItem;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Button buttonRollDice;
        private System.Windows.Forms.Label labelCurrentTurn;
        private System.Windows.Forms.Button buttonEndTurn;
        private System.Windows.Forms.Label labelPlayer1Current;
        private System.Windows.Forms.Label labelPlayer1Brains;
        private System.Windows.Forms.Label labelPlayer2Brains;
        private System.Windows.Forms.Label labelPlayer1Shotguns;
        private System.Windows.Forms.Label labelPlayer2Shotguns;
        private System.Windows.Forms.Label labelQuote;
    }
}

