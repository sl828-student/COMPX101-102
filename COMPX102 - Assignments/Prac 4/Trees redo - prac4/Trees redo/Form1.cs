using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trees_redo
{
    public partial class Form1 : Form
    {
        //List<Tree> treeList = new List<Tree>();
        Forest forest = new Forest();

        const string FILTER = "CSV files (*.csv)|*.csv";

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 5;
            timer1.Enabled = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightPink);
            //foreach (Tree tree in treeList)
            //{
            //    tree.DrawTree(e.Graphics);
            //}
            forest.DrawForest(e.Graphics);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            forest.GrowForest(2);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int size = int.Parse(textBox1.Text);

                //treeList.Add(new Tree(e.X, e.Y, size)); 
                forest.AddTree(e.X, e.Y, size);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }   


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = FILTER;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                forest.LoadForest(ofd.FileName);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = FILTER;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                forest.SaveForest(sfd.FileName);
            }
        }
    }
}
