namespace Revision_session_2
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
            this.labelBranding = new System.Windows.Forms.Label();
            this.textBoxBags = new System.Windows.Forms.TextBox();
            this.labelBags = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSizeOfBags = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxBeanAmount = new System.Windows.Forms.TextBox();
            this.textBoxExtraSpilled = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBranding
            // 
            this.labelBranding.AutoSize = true;
            this.labelBranding.BackColor = System.Drawing.Color.White;
            this.labelBranding.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranding.ForeColor = System.Drawing.Color.Black;
            this.labelBranding.Location = new System.Drawing.Point(17, 28);
            this.labelBranding.Name = "labelBranding";
            this.labelBranding.Size = new System.Drawing.Size(306, 36);
            this.labelBranding.TabIndex = 0;
            this.labelBranding.Text = "Magic Beans Calculator";
            // 
            // textBoxBags
            // 
            this.textBoxBags.Location = new System.Drawing.Point(181, 80);
            this.textBoxBags.Name = "textBoxBags";
            this.textBoxBags.Size = new System.Drawing.Size(100, 20);
            this.textBoxBags.TabIndex = 1;
            // 
            // labelBags
            // 
            this.labelBags.AutoSize = true;
            this.labelBags.Location = new System.Drawing.Point(89, 87);
            this.labelBags.Name = "labelBags";
            this.labelBags.Size = new System.Drawing.Size(86, 13);
            this.labelBags.TabIndex = 2;
            this.labelBags.Text = "Number of Bags;";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(181, 106);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 3;
            // 
            // labelSizeOfBags
            // 
            this.labelSizeOfBags.AutoSize = true;
            this.labelSizeOfBags.Location = new System.Drawing.Point(105, 113);
            this.labelSizeOfBags.Name = "labelSizeOfBags";
            this.labelSizeOfBags.Size = new System.Drawing.Size(69, 13);
            this.labelSizeOfBags.TabIndex = 4;
            this.labelSizeOfBags.Text = "Size of Bags:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(41, 143);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(240, 38);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate Values";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxBeanAmount
            // 
            this.textBoxBeanAmount.Location = new System.Drawing.Point(181, 197);
            this.textBoxBeanAmount.Name = "textBoxBeanAmount";
            this.textBoxBeanAmount.ReadOnly = true;
            this.textBoxBeanAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeanAmount.TabIndex = 6;
            // 
            // textBoxExtraSpilled
            // 
            this.textBoxExtraSpilled.Location = new System.Drawing.Point(181, 223);
            this.textBoxExtraSpilled.Name = "textBoxExtraSpilled";
            this.textBoxExtraSpilled.ReadOnly = true;
            this.textBoxExtraSpilled.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtraSpilled.TabIndex = 7;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(181, 249);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalAmount.TabIndex = 8;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(38, 204);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(137, 13);
            this.labelAmount.TabIndex = 9;
            this.labelAmount.Text = "Amount of Beans Required:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Extra Beans Spilled:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(11, 256);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(164, 13);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total Amount of Beans Required:";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(128, 311);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 38);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(248, 345);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 38);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(181, 275);
            this.textBoxTotalCost.Multiline = true;
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.ReadOnly = true;
            this.textBoxTotalCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalCost.TabIndex = 14;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(116, 282);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(58, 13);
            this.labelTotalCost.TabIndex = 15;
            this.labelTotalCost.Text = "Total Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 400);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.textBoxExtraSpilled);
            this.Controls.Add(this.textBoxBeanAmount);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelSizeOfBags);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelBags);
            this.Controls.Add(this.textBoxBags);
            this.Controls.Add(this.labelBranding);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBranding;
        private System.Windows.Forms.TextBox textBoxBags;
        private System.Windows.Forms.Label labelBags;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSizeOfBags;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxBeanAmount;
        private System.Windows.Forms.TextBox textBoxExtraSpilled;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label labelTotalCost;
    }
}

