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
        private List<Tree> trees = new List<Tree>();
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 5;
            timer1.Enabled = true;
            pictureBox1.MouseClick += pictureBox1_Click;
            pictureBox1.Paint += PictureBox1_Paint;
            timer1.Tick += Timer1_Tick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int ofsetX = pictureBox1.Location.X + this.Location.X;
            int ofsetY = pictureBox1.Location.Y + this.Location.Y;
            

            

            int foliageSize;
            if (int.TryParse(textBoxFoliageSize.Text, out foliageSize))
            {
                trees.Add(new Tree(MousePosition.X - ofsetX, MousePosition.Y - ofsetY - 25, foliageSize));
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.LightGray);
            foreach (var tree in trees)
            {
                tree.DrawTree(e.Graphics);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
