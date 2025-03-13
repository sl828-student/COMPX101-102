namespace Traffic_Lights
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
            this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonDrawLights = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDrawing
            // 
            this.pictureBoxDrawing.Location = new System.Drawing.Point(24, 21);
            this.pictureBoxDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDrawing.Name = "pictureBoxDrawing";
            this.pictureBoxDrawing.Size = new System.Drawing.Size(584, 341);
            this.pictureBoxDrawing.TabIndex = 0;
            this.pictureBoxDrawing.TabStop = false;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(288, 374);
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(52, 20);
            this.textBoxSize.TabIndex = 1;
            // 
            // buttonDrawLights
            // 
            this.buttonDrawLights.Location = new System.Drawing.Point(68, 433);
            this.buttonDrawLights.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDrawLights.Name = "buttonDrawLights";
            this.buttonDrawLights.Size = new System.Drawing.Size(134, 39);
            this.buttonDrawLights.TabIndex = 2;
            this.buttonDrawLights.Text = "Draw Traffic Lights";
            this.buttonDrawLights.UseVisualStyleBackColor = true;
            this.buttonDrawLights.Click += new System.EventHandler(this.buttonDrawLights_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(250, 433);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(134, 39);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(432, 433);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 39);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(217, 377);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(69, 13);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Size of lights:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 552);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDrawLights);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.pictureBoxDrawing);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDrawing;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonDrawLights;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSize;
    }
}

