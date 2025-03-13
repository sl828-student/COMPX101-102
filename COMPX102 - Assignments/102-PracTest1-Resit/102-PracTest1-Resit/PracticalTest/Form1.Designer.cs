namespace PracticalTest
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.displayAllMedallistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByCountryAndMedalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAverageFinalMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBestMedallistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMedallistCountByCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMedal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 16;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 27);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(735, 468);
            this.listBoxDisplay.TabIndex = 1;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.Location = new System.Drawing.Point(757, 55);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(204, 29);
            this.textBoxCountry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Country:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testingToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.displayAllMedallistsToolStripMenuItem,
            this.filterByCountryToolStripMenuItem,
            this.filterByCountryAndMedalToolStripMenuItem,
            this.displayAverageFinalMarkToolStripMenuItem,
            this.displayBestMedallistToolStripMenuItem,
            this.displayMedallistCountByCountryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.testingToolStripMenuItem.Text = "Testing";
            this.testingToolStripMenuItem.Click += new System.EventHandler(this.testingToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 6);
            // 
            // displayAllMedallistsToolStripMenuItem
            // 
            this.displayAllMedallistsToolStripMenuItem.Name = "displayAllMedallistsToolStripMenuItem";
            this.displayAllMedallistsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.displayAllMedallistsToolStripMenuItem.Text = "Display All Medallists";
            this.displayAllMedallistsToolStripMenuItem.Click += new System.EventHandler(this.displayAllMedallistsToolStripMenuItem_Click);
            // 
            // filterByCountryToolStripMenuItem
            // 
            this.filterByCountryToolStripMenuItem.Name = "filterByCountryToolStripMenuItem";
            this.filterByCountryToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.filterByCountryToolStripMenuItem.Text = "Filter by Country";
            this.filterByCountryToolStripMenuItem.Click += new System.EventHandler(this.filterByCountryToolStripMenuItem_Click);
            // 
            // filterByCountryAndMedalToolStripMenuItem
            // 
            this.filterByCountryAndMedalToolStripMenuItem.Name = "filterByCountryAndMedalToolStripMenuItem";
            this.filterByCountryAndMedalToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.filterByCountryAndMedalToolStripMenuItem.Text = "Filter by Country and Medal";
            this.filterByCountryAndMedalToolStripMenuItem.Click += new System.EventHandler(this.filterByCountryAndMedalToolStripMenuItem_Click);
            // 
            // displayAverageFinalMarkToolStripMenuItem
            // 
            this.displayAverageFinalMarkToolStripMenuItem.Name = "displayAverageFinalMarkToolStripMenuItem";
            this.displayAverageFinalMarkToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.displayAverageFinalMarkToolStripMenuItem.Text = "Display Average Medal Count";
            this.displayAverageFinalMarkToolStripMenuItem.Click += new System.EventHandler(this.displayAverageMedalCountToolStripMenuItem_Click);
            // 
            // displayBestMedallistToolStripMenuItem
            // 
            this.displayBestMedallistToolStripMenuItem.Name = "displayBestMedallistToolStripMenuItem";
            this.displayBestMedallistToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.displayBestMedallistToolStripMenuItem.Text = "Display Best Medallist";
            this.displayBestMedallistToolStripMenuItem.Click += new System.EventHandler(this.displayBestMedallistToolStripMenuItem_Click);
            // 
            // displayMedallistCountByCountryToolStripMenuItem
            // 
            this.displayMedallistCountByCountryToolStripMenuItem.Name = "displayMedallistCountByCountryToolStripMenuItem";
            this.displayMedallistCountByCountryToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.displayMedallistCountByCountryToolStripMenuItem.Text = "Display Medallist Count by Country";
            this.displayMedallistCountByCountryToolStripMenuItem.Click += new System.EventHandler(this.displayMedallistCountByCountryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Medal:";
            // 
            // textBoxMedal
            // 
            this.textBoxMedal.Location = new System.Drawing.Point(757, 128);
            this.textBoxMedal.Name = "textBoxMedal";
            this.textBoxMedal.Size = new System.Drawing.Size(204, 20);
            this.textBoxMedal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(874, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Please enter country and medal type spelt correctly and with appropriate capitliz" +
    "ation. For example \"New Zealand\" and \"Gold\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMedal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practical Test 1 Resit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByCountryToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem displayAllMedallistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByCountryAndMedalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBestMedallistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAverageFinalMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayMedallistCountByCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TextBox textBoxMedal;
        private System.Windows.Forms.Label label2;
    }
}

