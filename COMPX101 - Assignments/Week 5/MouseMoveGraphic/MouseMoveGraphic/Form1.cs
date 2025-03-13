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
            

            int size = random.Next(1,50);
            int colourRandom1 = random.Next(1, 255);
            int colourRandom2 = random.Next(1, 255);
            int colourRandom3 = random.Next(1, 255);

            brush.Color = Color.FromArgb(colourRandom1, colourRandom2, colourRandom3);

            //If the button pressed is the left button THEN Draw the line
            if (e.Button == MouseButtons.Left)
            {
                //So lines can be drawn
                // paper.DrawLine(penBlack, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2, e.X, e.Y);

                //paper.DrawLine(penBlack, random.Next(pictureBoxDisplay.Width+1), random.Next(pictureBoxDisplay.Height+1), e.X, e.Y)

                int randomCircles = random.Next(1, 11);
                int counter = 1;
                int xPos = 0;
                int yPos = 0;

                while (counter <= randomCircles)
                {
                    size = random.Next(2, 11);
                    xPos = e.X + random.Next(-10, 11);
                    yPos = e.Y + random.Next(-10, 11);

                    paper.FillEllipse(brush, xPos, yPos, size, size);
                    paper.DrawEllipse(penBlack, xPos, yPos, size, size);
                    counter ++;
                }
                

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
