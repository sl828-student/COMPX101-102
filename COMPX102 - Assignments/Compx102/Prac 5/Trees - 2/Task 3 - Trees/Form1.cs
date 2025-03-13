using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3___Trees
{
    public partial class Form1 : Form
    {
        List<Tree> trees = new List<Tree>();

        Forest forest = new Forest();

        const string FILTER = "CSV files (*.csv)|*.csv";

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 5;
            timer1.Enabled = true;
            pictureBox1.MouseClick += pictureBox1_Click;
            pictureBox1.Paint += PictureBox1_Paint;
            timer1.Tick += Timer1_Tick;
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            try
            {
                int size = int.Parse(textBoxFoliageSize.Text);
                if (e.Button == MouseButtons.Left)
                {
                    forest.AddTree(e.X, e.Y, size);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    forest.AddShrub(e.X, e.Y, size);
                }
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightGray);
            //foreach(Tree t in trees)
            //{
            //    t.DrawTree(e.Graphics);
            //}
            forest.DrawForest(e.Graphics);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            forest.GrowForest(2);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = FILTER;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                forest.loadForest(openFileDialog.FileName);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FILTER;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                forest.SaveForest(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                forest.GenerateReport(saveFileDialog.FileName);
            }
        }
    }
}
