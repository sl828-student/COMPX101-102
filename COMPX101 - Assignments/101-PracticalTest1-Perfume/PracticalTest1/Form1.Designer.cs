namespace PracticalTest1
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxSmall = new System.Windows.Forms.TextBox();
            this.textBoxLarge = new System.Windows.Forms.TextBox();
            this.textBoxSmallAmount = new System.Windows.Forms.TextBox();
            this.textBoxLargeAmount = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.labelSmall = new System.Windows.Forms.Label();
            this.labelLarge = new System.Windows.Forms.Label();
            this.labelSmallAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelLargeAmount = new System.Windows.Forms.Label();
            this.labelLitres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDrums = new System.Windows.Forms.Label();
            this.textBoxDrums = new System.Windows.Forms.TextBox();
            this.textBoxDrumsCost = new System.Windows.Forms.TextBox();
            this.labelDrumsCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(364, 250);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(364, 524);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(627, 565);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(289, 110);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(249, 25);
            this.labelBrand.TabIndex = 3;
            this.labelBrand.Text = "\"Perfumery\" Calculator";
            // 
            // textBoxSmall
            // 
            this.textBoxSmall.Location = new System.Drawing.Point(250, 203);
            this.textBoxSmall.Name = "textBoxSmall";
            this.textBoxSmall.Size = new System.Drawing.Size(100, 20);
            this.textBoxSmall.TabIndex = 4;
            // 
            // textBoxLarge
            // 
            this.textBoxLarge.Location = new System.Drawing.Point(565, 203);
            this.textBoxLarge.Name = "textBoxLarge";
            this.textBoxLarge.Size = new System.Drawing.Size(100, 20);
            this.textBoxLarge.TabIndex = 5;
            // 
            // textBoxSmallAmount
            // 
            this.textBoxSmallAmount.Location = new System.Drawing.Point(418, 307);
            this.textBoxSmallAmount.Name = "textBoxSmallAmount";
            this.textBoxSmallAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxSmallAmount.TabIndex = 6;
            // 
            // textBoxLargeAmount
            // 
            this.textBoxLargeAmount.Location = new System.Drawing.Point(418, 333);
            this.textBoxLargeAmount.Name = "textBoxLargeAmount";
            this.textBoxLargeAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxLargeAmount.TabIndex = 7;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(418, 361);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalAmount.TabIndex = 8;
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(565, 419);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalCost.TabIndex = 9;
            // 
            // labelSmall
            // 
            this.labelSmall.AutoSize = true;
            this.labelSmall.Location = new System.Drawing.Point(82, 210);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(162, 13);
            this.labelSmall.TabIndex = 10;
            this.labelSmall.Text = "Number Of Small Bottles Ordered";
            // 
            // labelLarge
            // 
            this.labelLarge.AutoSize = true;
            this.labelLarge.Location = new System.Drawing.Point(388, 210);
            this.labelLarge.Name = "labelLarge";
            this.labelLarge.Size = new System.Drawing.Size(164, 13);
            this.labelLarge.TabIndex = 11;
            this.labelLarge.Text = "Number Of Large Bottles Ordered";
            // 
            // labelSmallAmount
            // 
            this.labelSmallAmount.AutoSize = true;
            this.labelSmallAmount.Location = new System.Drawing.Point(247, 314);
            this.labelSmallAmount.Name = "labelSmallAmount";
            this.labelSmallAmount.Size = new System.Drawing.Size(170, 13);
            this.labelSmallAmount.TabIndex = 12;
            this.labelSmallAmount.Text = "Amount Required For Small Bottles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(299, 368);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(116, 13);
            this.labelTotalAmount.TabIndex = 14;
            this.labelTotalAmount.Text = "Total Amount Required";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(438, 426);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(111, 13);
            this.labelTotalCost.TabIndex = 15;
            this.labelTotalCost.Text = "Total Cost Of Perfume";
            // 
            // labelLargeAmount
            // 
            this.labelLargeAmount.AutoSize = true;
            this.labelLargeAmount.Location = new System.Drawing.Point(243, 340);
            this.labelLargeAmount.Name = "labelLargeAmount";
            this.labelLargeAmount.Size = new System.Drawing.Size(172, 13);
            this.labelLargeAmount.TabIndex = 16;
            this.labelLargeAmount.Text = "Amount Required For Large Bottles";
            // 
            // labelLitres
            // 
            this.labelLitres.AutoSize = true;
            this.labelLitres.Location = new System.Drawing.Point(524, 314);
            this.labelLitres.Name = "labelLitres";
            this.labelLitres.Size = new System.Drawing.Size(28, 13);
            this.labelLitres.TabIndex = 17;
            this.labelLitres.Text = "litres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "litres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "litres";
            // 
            // labelDrums
            // 
            this.labelDrums.AutoSize = true;
            this.labelDrums.Location = new System.Drawing.Point(412, 452);
            this.labelDrums.Name = "labelDrums";
            this.labelDrums.Size = new System.Drawing.Size(137, 13);
            this.labelDrums.TabIndex = 20;
            this.labelDrums.Text = "Number Of Drums Required";
            // 
            // textBoxDrums
            // 
            this.textBoxDrums.Location = new System.Drawing.Point(565, 445);
            this.textBoxDrums.Name = "textBoxDrums";
            this.textBoxDrums.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrums.TabIndex = 21;
            // 
            // textBoxDrumsCost
            // 
            this.textBoxDrumsCost.Location = new System.Drawing.Point(565, 471);
            this.textBoxDrumsCost.Name = "textBoxDrumsCost";
            this.textBoxDrumsCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrumsCost.TabIndex = 22;
            // 
            // labelDrumsCost
            // 
            this.labelDrumsCost.AutoSize = true;
            this.labelDrumsCost.Location = new System.Drawing.Point(476, 478);
            this.labelDrumsCost.Name = "labelDrumsCost";
            this.labelDrumsCost.Size = new System.Drawing.Size(73, 13);
            this.labelDrumsCost.TabIndex = 23;
            this.labelDrumsCost.Text = "Cost of Drums";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 622);
            this.Controls.Add(this.labelDrumsCost);
            this.Controls.Add(this.textBoxDrumsCost);
            this.Controls.Add(this.textBoxDrums);
            this.Controls.Add(this.labelDrums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLitres);
            this.Controls.Add(this.labelLargeAmount);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSmallAmount);
            this.Controls.Add(this.labelLarge);
            this.Controls.Add(this.labelSmall);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.textBoxLargeAmount);
            this.Controls.Add(this.textBoxSmallAmount);
            this.Controls.Add(this.textBoxLarge);
            this.Controls.Add(this.textBoxSmall);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "101 Practical Test 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxSmall;
        private System.Windows.Forms.TextBox textBoxLarge;
        private System.Windows.Forms.TextBox textBoxSmallAmount;
        private System.Windows.Forms.TextBox textBoxLargeAmount;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label labelSmall;
        private System.Windows.Forms.Label labelLarge;
        private System.Windows.Forms.Label labelSmallAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelLargeAmount;
        private System.Windows.Forms.Label labelLitres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDrums;
        private System.Windows.Forms.TextBox textBoxDrums;
        private System.Windows.Forms.TextBox textBoxDrumsCost;
        private System.Windows.Forms.Label labelDrumsCost;
    }
}

