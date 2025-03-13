using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Click event to draw line
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            //Create the graphics and pen objects
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);

            //Draw a line using the coordinates given
            paper.DrawLine(pen1, 10, 10, 100, 100);


        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen2 = new Pen(Color.Black, 5);

            paper.DrawLine(pen2, 50, 50, 150, 50);
            paper.DrawLine(pen2, 150, 50, 150, 150);
            paper.DrawLine(pen2, 150, 150, 50, 150);
            paper.DrawLine(pen2, 50, 150, 50, 50);

        }
    }
}
