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
            this.textBoxPaperCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByQualificationAndPaperCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAverageFinalMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBestStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStudentCountByQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
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
            // textBoxPaperCode
            // 
            this.textBoxPaperCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaperCode.Location = new System.Drawing.Point(757, 55);
            this.textBoxPaperCode.Name = "textBoxPaperCode";
            this.textBoxPaperCode.Size = new System.Drawing.Size(204, 29);
            this.textBoxPaperCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paper Code:";
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
            this.displayAllStudentsToolStripMenuItem,
            this.filterByQualificationToolStripMenuItem,
            this.filterByQualificationAndPaperCodeToolStripMenuItem,
            this.displayAverageFinalMarkToolStripMenuItem,
            this.displayBestStudentToolStripMenuItem,
            this.displayStudentCountByQualificationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // displayAllStudentsToolStripMenuItem
            // 
            this.displayAllStudentsToolStripMenuItem.Name = "displayAllStudentsToolStripMenuItem";
            this.displayAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.displayAllStudentsToolStripMenuItem.Text = "Display All Students";
            this.displayAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.displayAllStudentsToolStripMenuItem_Click);
            // 
            // filterByQualificationToolStripMenuItem
            // 
            this.filterByQualificationToolStripMenuItem.Name = "filterByQualificationToolStripMenuItem";
            this.filterByQualificationToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.filterByQualificationToolStripMenuItem.Text = "Filter by Qualification";
            this.filterByQualificationToolStripMenuItem.Click += new System.EventHandler(this.filterByQualificationToolStripMenuItem_Click);
            // 
            // filterByQualificationAndPaperCodeToolStripMenuItem
            // 
            this.filterByQualificationAndPaperCodeToolStripMenuItem.Name = "filterByQualificationAndPaperCodeToolStripMenuItem";
            this.filterByQualificationAndPaperCodeToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.filterByQualificationAndPaperCodeToolStripMenuItem.Text = "Filter by Qualification and Paper Code";
            this.filterByQualificationAndPaperCodeToolStripMenuItem.Click += new System.EventHandler(this.filterByQualificationAndPaperCodeToolStripMenuItem_Click);
            // 
            // displayAverageFinalMarkToolStripMenuItem
            // 
            this.displayAverageFinalMarkToolStripMenuItem.Name = "displayAverageFinalMarkToolStripMenuItem";
            this.displayAverageFinalMarkToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.displayAverageFinalMarkToolStripMenuItem.Text = "Display Average Final Mark";
            this.displayAverageFinalMarkToolStripMenuItem.Click += new System.EventHandler(this.displayAverageFinalMarkToolStripMenuItem_Click);
            // 
            // displayBestStudentToolStripMenuItem
            // 
            this.displayBestStudentToolStripMenuItem.Name = "displayBestStudentToolStripMenuItem";
            this.displayBestStudentToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.displayBestStudentToolStripMenuItem.Text = "Display Best Student";
            this.displayBestStudentToolStripMenuItem.Click += new System.EventHandler(this.displayBestStudentToolStripMenuItem_Click);
            // 
            // displayStudentCountByQualificationToolStripMenuItem
            // 
            this.displayStudentCountByQualificationToolStripMenuItem.Name = "displayStudentCountByQualificationToolStripMenuItem";
            this.displayStudentCountByQualificationToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.displayStudentCountByQualificationToolStripMenuItem.Text = "Display Student Count by Qualification";
            this.displayStudentCountByQualificationToolStripMenuItem.Click += new System.EventHandler(this.displayStudentCountByQualificationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(276, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qualification";
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQualification.Location = new System.Drawing.Point(757, 127);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.Size = new System.Drawing.Size(204, 29);
            this.textBoxQualification.TabIndex = 9;
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.testingToolStripMenuItem.Text = "Testing";
            this.testingToolStripMenuItem.Click += new System.EventHandler(this.testingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(276, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQualification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPaperCode);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practical Test 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.TextBox textBoxPaperCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByQualificationToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.ToolStripMenuItem displayAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByQualificationAndPaperCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBestStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAverageFinalMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStudentCountByQualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

