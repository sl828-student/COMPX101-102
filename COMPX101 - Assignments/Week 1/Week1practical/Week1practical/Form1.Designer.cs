namespace Week1practical
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHello = new System.Windows.Forms.Button();
            this.buttonChangeColour = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "My first application";
            // 
            // buttonHello
            // 
            this.buttonHello.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHello.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHello.Location = new System.Drawing.Point(267, 133);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(248, 55);
            this.buttonHello.TabIndex = 1;
            this.buttonHello.Text = "Hello";
            this.buttonHello.UseVisualStyleBackColor = false;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonChangeColour
            // 
            this.buttonChangeColour.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonChangeColour.Enabled = false;
            this.buttonChangeColour.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeColour.Location = new System.Drawing.Point(267, 238);
            this.buttonChangeColour.Name = "buttonChangeColour";
            this.buttonChangeColour.Size = new System.Drawing.Size(248, 55);
            this.buttonChangeColour.TabIndex = 2;
            this.buttonChangeColour.Text = "Change Colour";
            this.buttonChangeColour.UseVisualStyleBackColor = false;
            this.buttonChangeColour.Click += new System.EventHandler(this.buttonChangeColour_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonExit.Location = new System.Drawing.Point(354, 343);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChangeColour);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Button buttonChangeColour;
        private System.Windows.Forms.Button buttonExit;
    }
}

