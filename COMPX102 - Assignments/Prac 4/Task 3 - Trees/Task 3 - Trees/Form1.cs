using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            timer1.Enabled = true;
        }



        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //int size = int.Parse(foliagesize.Text);
            //int x = e.X;
            //int y = e.Y;
            //tree = new Tree(x, y, size);
            //trees.Add(tree);
            try
            {
                int size = int.Parse(textBoxFoliageSize.Text);
                forest.AddTree(e.X, e.Y, size);
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightGray);
            //foreach(Tree t in trees)
            //{
            //    t.DrawTree(e.Graphics);
            //}
            forest.DrawForest(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            forest.GrowForest(2);
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

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = FILTER;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                forest.loadForest(openFileDialog.FileName);
            }
        }
    }
}