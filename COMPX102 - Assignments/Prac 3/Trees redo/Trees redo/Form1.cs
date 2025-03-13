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
        List<Tree> treeList = new List<Tree>();

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 5;
            timer1.Enabled = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightPink);
            foreach (Tree tree in treeList)
            {
                tree.DrawTree(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int size = int.Parse(textBox1.Text);
            
            treeList.Add(new Tree(e.X, e.Y, size)); 


        }
    }
}
