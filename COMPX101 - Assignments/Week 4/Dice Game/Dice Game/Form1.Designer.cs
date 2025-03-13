namespace Dice_Game
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
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxBetAmount = new System.Windows.Forms.TextBox();
            this.labelBetAmount = new System.Windows.Forms.Label();
            this.textBoxComputerDiceOne = new System.Windows.Forms.TextBox();
            this.textBoxComputerDiceTwo = new System.Windows.Forms.TextBox();
            this.labelComputerDiceOne = new System.Windows.Forms.Label();
            this.labelComputerDiceTwo = new System.Windows.Forms.Label();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPlayerDiceOne = new System.Windows.Forms.TextBox();
            this.textBoxPlayerDiceTwo = new System.Windows.Forms.TextBox();
            this.labelPlayerDiceOne = new System.Windows.Forms.Label();
            this.labelPlayerDiceTwo = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.Location = new System.Drawing.Point(152, 211);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 31);
            this.textBoxBalance.TabIndex = 0;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(2, 218);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(144, 20);
            this.labelBalance.TabIndex = 1;
            this.labelBalance.Text = "Current Balance:";
            // 
            // textBoxBetAmount
            // 
            this.textBoxBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBetAmount.Location = new System.Drawing.Point(152, 252);
            this.textBoxBetAmount.Name = "textBoxBetAmount";
            this.textBoxBetAmount.Size = new System.Drawing.Size(100, 31);
            this.textBoxBetAmount.TabIndex = 2;
            // 
            // labelBetAmount
            // 
            this.labelBetAmount.AutoSize = true;
            this.labelBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetAmount.Location = new System.Drawing.Point(37, 259);
            this.labelBetAmount.Name = "labelBetAmount";
            this.labelBetAmount.Size = new System.Drawing.Size(109, 20);
            this.labelBetAmount.TabIndex = 3;
            this.labelBetAmount.Text = "Bet Amount:";
            // 
            // textBoxComputerDiceOne
            // 
            this.textBoxComputerDiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerDiceOne.Location = new System.Drawing.Point(415, 94);
            this.textBoxComputerDiceOne.Name = "textBoxComputerDiceOne";
            this.textBoxComputerDiceOne.Size = new System.Drawing.Size(40, 40);
            this.textBoxComputerDiceOne.TabIndex = 4;
            // 
            // textBoxComputerDiceTwo
            // 
            this.textBoxComputerDiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerDiceTwo.Location = new System.Drawing.Point(415, 143);
            this.textBoxComputerDiceTwo.Name = "textBoxComputerDiceTwo";
            this.textBoxComputerDiceTwo.Size = new System.Drawing.Size(40, 40);
            this.textBoxComputerDiceTwo.TabIndex = 5;
            // 
            // labelComputerDiceOne
            // 
            this.labelComputerDiceOne.AutoSize = true;
            this.labelComputerDiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerDiceOne.Location = new System.Drawing.Point(258, 108);
            this.labelComputerDiceOne.Name = "labelComputerDiceOne";
            this.labelComputerDiceOne.Size = new System.Drawing.Size(153, 20);
            this.labelComputerDiceOne.TabIndex = 6;
            this.labelComputerDiceOne.Text = "Computer Dice One:";
            this.labelComputerDiceOne.Click += new System.EventHandler(this.labelDiceOne_Click);
            // 
            // labelComputerDiceTwo
            // 
            this.labelComputerDiceTwo.AutoSize = true;
            this.labelComputerDiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerDiceTwo.Location = new System.Drawing.Point(261, 157);
            this.labelComputerDiceTwo.Name = "labelComputerDiceTwo";
            this.labelComputerDiceTwo.Size = new System.Drawing.Size(152, 20);
            this.labelComputerDiceTwo.TabIndex = 7;
            this.labelComputerDiceTwo.Text = "Computer Dice Two:";
            // 
            // buttonRoll
            // 
            this.buttonRoll.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoll.Location = new System.Drawing.Point(311, 200);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(179, 46);
            this.buttonRoll.TabIndex = 8;
            this.buttonRoll.Text = "Roll Dice!";
            this.buttonRoll.UseVisualStyleBackColor = false;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonExit.Location = new System.Drawing.Point(415, 276);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPlayerDiceOne
            // 
            this.textBoxPlayerDiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerDiceOne.Location = new System.Drawing.Point(152, 97);
            this.textBoxPlayerDiceOne.Name = "textBoxPlayerDiceOne";
            this.textBoxPlayerDiceOne.Size = new System.Drawing.Size(40, 40);
            this.textBoxPlayerDiceOne.TabIndex = 12;
            // 
            // textBoxPlayerDiceTwo
            // 
            this.textBoxPlayerDiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerDiceTwo.Location = new System.Drawing.Point(152, 143);
            this.textBoxPlayerDiceTwo.Name = "textBoxPlayerDiceTwo";
            this.textBoxPlayerDiceTwo.Size = new System.Drawing.Size(40, 40);
            this.textBoxPlayerDiceTwo.TabIndex = 13;
            // 
            // labelPlayerDiceOne
            // 
            this.labelPlayerDiceOne.AutoSize = true;
            this.labelPlayerDiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerDiceOne.Location = new System.Drawing.Point(20, 108);
            this.labelPlayerDiceOne.Name = "labelPlayerDiceOne";
            this.labelPlayerDiceOne.Size = new System.Drawing.Size(126, 20);
            this.labelPlayerDiceOne.TabIndex = 14;
            this.labelPlayerDiceOne.Text = "Player Dice One:";
            // 
            // labelPlayerDiceTwo
            // 
            this.labelPlayerDiceTwo.AutoSize = true;
            this.labelPlayerDiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerDiceTwo.Location = new System.Drawing.Point(21, 157);
            this.labelPlayerDiceTwo.Name = "labelPlayerDiceTwo";
            this.labelPlayerDiceTwo.Size = new System.Drawing.Size(125, 20);
            this.labelPlayerDiceTwo.TabIndex = 15;
            this.labelPlayerDiceTwo.Text = "Player Dice Two:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(12, 9);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(484, 57);
            this.labelBrand.TabIndex = 16;
            this.labelBrand.Text = "Roll Dice Lose Money Game!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 312);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelPlayerDiceTwo);
            this.Controls.Add(this.labelPlayerDiceOne);
            this.Controls.Add(this.textBoxPlayerDiceTwo);
            this.Controls.Add(this.textBoxPlayerDiceOne);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.labelComputerDiceTwo);
            this.Controls.Add(this.labelComputerDiceOne);
            this.Controls.Add(this.textBoxComputerDiceTwo);
            this.Controls.Add(this.textBoxComputerDiceOne);
            this.Controls.Add(this.labelBetAmount);
            this.Controls.Add(this.textBoxBetAmount);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxBalance);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxBetAmount;
        private System.Windows.Forms.Label labelBetAmount;
        private System.Windows.Forms.TextBox textBoxComputerDiceOne;
        private System.Windows.Forms.TextBox textBoxComputerDiceTwo;
        private System.Windows.Forms.Label labelComputerDiceOne;
        private System.Windows.Forms.Label labelComputerDiceTwo;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPlayerDiceOne;
        private System.Windows.Forms.TextBox textBoxPlayerDiceTwo;
        private System.Windows.Forms.Label labelPlayerDiceOne;
        private System.Windows.Forms.Label labelPlayerDiceTwo;
        private System.Windows.Forms.Label labelBrand;
    }
}

