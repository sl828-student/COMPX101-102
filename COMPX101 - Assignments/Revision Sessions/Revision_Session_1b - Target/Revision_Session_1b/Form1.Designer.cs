namespace Revision_Session_1b
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
            this.pictureBoxBullseye = new System.Windows.Forms.PictureBox();
            this.buttonCreateTarget = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullseye)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBullseye
            // 
            this.pictureBoxBullseye.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBoxBullseye.Location = new System.Drawing.Point(319, 104);
            this.pictureBoxBullseye.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxBullseye.MaximumSize = new System.Drawing.Size(400, 346);
            this.pictureBoxBullseye.Name = "pictureBoxBullseye";
            this.pictureBoxBullseye.Size = new System.Drawing.Size(400, 346);
            this.pictureBoxBullseye.TabIndex = 0;
            this.pictureBoxBullseye.TabStop = false;
            // 
            // buttonCreateTarget
            // 
            this.buttonCreateTarget.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTarget.Location = new System.Drawing.Point(396, 503);
            this.buttonCreateTarget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateTarget.Name = "buttonCreateTarget";
            this.buttonCreateTarget.Size = new System.Drawing.Size(245, 73);
            this.buttonCreateTarget.TabIndex = 1;
            this.buttonCreateTarget.Text = "Create Target!";
            this.buttonCreateTarget.UseVisualStyleBackColor = true;
            this.buttonCreateTarget.Click += new System.EventHandler(this.buttonCreateTarget_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1032, 712);
            this.Controls.Add(this.buttonCreateTarget);
            this.Controls.Add(this.pictureBoxBullseye);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullseye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBullseye;
        private System.Windows.Forms.Button buttonCreateTarget;
    }
}

