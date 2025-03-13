using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMoveGraphic
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
           //Create paper for drawing
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            //Create pens
            Pen penBlack = new Pen(colorDialog1.Color, 2);

            SolidBrush brush= new SolidBrush(Color.DarkRed);

            //If the button pressed is the left button THEN Draw the line
            if (e.Button == MouseButtons.Left)
            {
                //So lines can be drawn
                // paper.DrawLine(penBlack, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2, e.X, e.Y);

                //paper.DrawLine(penBlack, random.Next(pictureBoxDisplay.Width+1), random.Next(pictureBoxDisplay.Height+1), e.X, e.Y);

                paper.FillEllipse(brush, e.X, e.Y, 50, 50);
                paper.DrawEllipse(penBlack, e.X, e.Y, 50, 50);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
