namespace Circuits
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOrGate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNotGate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSource = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEvaluate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartCompound = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEndCompound = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAnd,
            this.toolStripButtonOrGate,
            this.toolStripButtonNotGate,
            this.toolStripButtonSource,
            this.toolStripButton2,
            this.toolStripButtonEvaluate,
            this.toolStripButtonCopy,
            this.toolStripButtonStartCompound,
            this.toolStripButtonEndCompound});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAnd
            // 
            this.toolStripButtonAnd.Image = global::Circuits.Properties.Resources.AndIcon;
            this.toolStripButtonAnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnd.Name = "toolStripButtonAnd";
            this.toolStripButtonAnd.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonAnd.Text = "And Gate";
            this.toolStripButtonAnd.Click += new System.EventHandler(this.toolStripButtonAnd_Click);
            // 
            // toolStripButtonOrGate
            // 
            this.toolStripButtonOrGate.Image = global::Circuits.Properties.Resources.OrGate;
            this.toolStripButtonOrGate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOrGate.Name = "toolStripButtonOrGate";
            this.toolStripButtonOrGate.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonOrGate.Text = "Or Gate";
            this.toolStripButtonOrGate.Click += new System.EventHandler(this.toolStripButtonOrGate_Click);
            // 
            // toolStripButtonNotGate
            // 
            this.toolStripButtonNotGate.Image = global::Circuits.Properties.Resources.NotIcon;
            this.toolStripButtonNotGate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNotGate.Name = "toolStripButtonNotGate";
            this.toolStripButtonNotGate.Size = new System.Drawing.Size(74, 22);
            this.toolStripButtonNotGate.Text = "Not Gate";
            this.toolStripButtonNotGate.Click += new System.EventHandler(this.toolStripButtonNotGate_Click);
            // 
            // toolStripButtonSource
            // 
            this.toolStripButtonSource.Image = global::Circuits.Properties.Resources.InputIcon;
            this.toolStripButtonSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSource.Name = "toolStripButtonSource";
            this.toolStripButtonSource.Size = new System.Drawing.Size(99, 22);
            this.toolStripButtonSource.Text = "Power Source";
            this.toolStripButtonSource.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Circuits.Properties.Resources.OutputIcon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton2.Text = "Bulb";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonEvaluate
            // 
            this.toolStripButtonEvaluate.Image = global::Circuits.Properties.Resources.EvaluateIcon;
            this.toolStripButtonEvaluate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEvaluate.Name = "toolStripButtonEvaluate";
            this.toolStripButtonEvaluate.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonEvaluate.Text = "Evaluate";
            this.toolStripButtonEvaluate.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.Image = global::Circuits.Properties.Resources.CopyIcon;
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonCopy.Text = "Copy";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripButtonStartCompound
            // 
            this.toolStripButtonStartCompound.Image = global::Circuits.Properties.Resources.StartCompoundIcon;
            this.toolStripButtonStartCompound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartCompound.Name = "toolStripButtonStartCompound";
            this.toolStripButtonStartCompound.Size = new System.Drawing.Size(115, 22);
            this.toolStripButtonStartCompound.Text = "Start Compound";
            this.toolStripButtonStartCompound.Click += new System.EventHandler(this.toolStripButton3_Click_2);
            // 
            // toolStripButtonEndCompound
            // 
            this.toolStripButtonEndCompound.Image = global::Circuits.Properties.Resources.EndCompoundIcon;
            this.toolStripButtonEndCompound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEndCompound.Name = "toolStripButtonEndCompound";
            this.toolStripButtonEndCompound.Size = new System.Drawing.Size(111, 22);
            this.toolStripButtonEndCompound.Text = "End Compound";
            this.toolStripButtonEndCompound.Click += new System.EventHandler(this.toolStripButtonEndCompound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuits 2023";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnd;
        private System.Windows.Forms.ToolStripButton toolStripButtonOrGate;
        private System.Windows.Forms.ToolStripButton toolStripButtonNotGate;
        private System.Windows.Forms.ToolStripButton toolStripButtonSource;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEvaluate;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartCompound;
        private System.Windows.Forms.ToolStripButton toolStripButtonEndCompound;
    }
}

