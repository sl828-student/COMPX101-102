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
            this.buttonRollDice = new System.Windows.Forms.Button();
            this.labelBrains = new System.Windows.Forms.Label();
            this.labelFootprints = new System.Windows.Forms.Label();
            this.labelShotgun = new System.Windows.Forms.Label();
            this.buttonReRoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRollDice
            // 
            this.buttonRollDice.Location = new System.Drawing.Point(249, 289);
            this.buttonRollDice.Name = "buttonRollDice";
            this.buttonRollDice.Size = new System.Drawing.Size(324, 23);
            this.buttonRollDice.TabIndex = 0;
            this.buttonRollDice.Text = "Roll Dice!";
            this.buttonRollDice.UseVisualStyleBackColor = true;
            this.buttonRollDice.Click += new System.EventHandler(this.buttonRollDice_Click);
            // 
            // labelBrains
            // 
            this.labelBrains.AutoSize = true;
            this.labelBrains.Location = new System.Drawing.Point(100, 133);
            this.labelBrains.Name = "labelBrains";
            this.labelBrains.Size = new System.Drawing.Size(48, 13);
            this.labelBrains.TabIndex = 1;
            this.labelBrains.Text = "Brains: 0";
            // 
            // labelFootprints
            // 
            this.labelFootprints.AutoSize = true;
            this.labelFootprints.Location = new System.Drawing.Point(355, 133);
            this.labelFootprints.Name = "labelFootprints";
            this.labelFootprints.Size = new System.Drawing.Size(65, 13);
            this.labelFootprints.TabIndex = 2;
            this.labelFootprints.Text = "Footprints: 0";
            // 
            // labelShotgun
            // 
            this.labelShotgun.AutoSize = true;
            this.labelShotgun.Location = new System.Drawing.Point(648, 133);
            this.labelShotgun.Name = "labelShotgun";
            this.labelShotgun.Size = new System.Drawing.Size(64, 13);
            this.labelShotgun.TabIndex = 3;
            this.labelShotgun.Text = "Shotguns: 0";
            // 
            // buttonReRoll
            // 
            this.buttonReRoll.Location = new System.Drawing.Point(358, 164);
            this.buttonReRoll.Name = "buttonReRoll";
            this.buttonReRoll.Size = new System.Drawing.Size(75, 23);
            this.buttonReRoll.TabIndex = 4;
            this.buttonReRoll.Text = "Re-Roll!";
            this.buttonReRoll.UseVisualStyleBackColor = true;
            this.buttonReRoll.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReRoll);
            this.Controls.Add(this.labelShotgun);
            this.Controls.Add(this.labelFootprints);
            this.Controls.Add(this.labelBrains);
            this.Controls.Add(this.buttonRollDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRollDice;
        private System.Windows.Forms.Label labelBrains;
        private System.Windows.Forms.Label labelFootprints;
        private System.Windows.Forms.Label labelShotgun;
        private System.Windows.Forms.Button buttonReRoll;
    }
}

