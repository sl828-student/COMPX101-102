namespace Bio_Fuel_Pump_Simulator
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
            this.textBoxRemainingFuel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFillAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFillVehicle = new System.Windows.Forms.Button();
            this.buttonFillPump = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRemainingFuel
            // 
            this.textBoxRemainingFuel.Location = new System.Drawing.Point(211, 123);
            this.textBoxRemainingFuel.Name = "textBoxRemainingFuel";
            this.textBoxRemainingFuel.ReadOnly = true;
            this.textBoxRemainingFuel.Size = new System.Drawing.Size(100, 31);
            this.textBoxRemainingFuel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remaining Fuel:";
            // 
            // textBoxFillAmount
            // 
            this.textBoxFillAmount.Location = new System.Drawing.Point(211, 86);
            this.textBoxFillAmount.Name = "textBoxFillAmount";
            this.textBoxFillAmount.Size = new System.Drawing.Size(100, 31);
            this.textBoxFillAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fill Cost:";
            // 
            // buttonFillVehicle
            // 
            this.buttonFillVehicle.Location = new System.Drawing.Point(143, 174);
            this.buttonFillVehicle.Name = "buttonFillVehicle";
            this.buttonFillVehicle.Size = new System.Drawing.Size(145, 61);
            this.buttonFillVehicle.TabIndex = 4;
            this.buttonFillVehicle.Text = "Fill Vehicle";
            this.buttonFillVehicle.UseVisualStyleBackColor = true;
            this.buttonFillVehicle.Click += new System.EventHandler(this.buttonFillVehicle_Click);
            // 
            // buttonFillPump
            // 
            this.buttonFillPump.Location = new System.Drawing.Point(143, 241);
            this.buttonFillPump.Name = "buttonFillPump";
            this.buttonFillPump.Size = new System.Drawing.Size(145, 61);
            this.buttonFillPump.TabIndex = 5;
            this.buttonFillPump.Text = "Fill Pump";
            this.buttonFillPump.UseVisualStyleBackColor = true;
            this.buttonFillPump.Click += new System.EventHandler(this.buttonFillPump_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(325, 241);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 61);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bio Fuel Simulator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFillPump);
            this.Controls.Add(this.buttonFillVehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFillAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRemainingFuel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRemainingFuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFillAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFillVehicle;
        private System.Windows.Forms.Button buttonFillPump;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label3;
    }
}

