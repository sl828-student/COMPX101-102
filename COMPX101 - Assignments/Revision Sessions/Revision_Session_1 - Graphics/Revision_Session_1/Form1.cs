using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision_Session_1
{
    public partial class Form1 : Form
    {

        //Class scope constants 
        const int WIDTH = 40;
        const int HEIGHT = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();

            Pen Pen1 = new Pen(Color.Black, 2);

            SolidBrush brOrange = new SolidBrush(Color.Orange);
            SolidBrush brRed = new SolidBrush(Color.Red);
            SolidBrush brGreen = new SolidBrush(Color.Green);

            int width = 200;

            Point corner1 = new Point(20, 20);
            Point corner2 = new Point(120, 20);
            Point corner3 = new Point(120, 120);
            Point corner4 = new Point(20, 120);

            
            paper.DrawLine(Pen1, 10, 30 , 100, 200);

            paper.FillEllipse(brOrange, 100, 50, 50, 100);
            paper.DrawEllipse(Pen1, 100, 50, 50, 100);
            
            
            paper.DrawRectangle(Pen1, 100, 200, 50, 100);

            paper.FillRectangle(brRed, 300, 400, 100, 100);
            paper.DrawRectangle(Pen1, 300, 400, 100, 100);

            paper.FillEllipse(brGreen, 100, 400, 50, 50);
            paper.DrawEllipse(Pen1, 100, 400, 50, 50);
            

            paper.FillRectangle(brOrange, 30, 30, 50, 50);

            paper.FillRectangle(brOrange, 100, 30, 50, 50);

            
            paper.FillEllipse(brRed, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2, 200, 200);
            paper.DrawEllipse(Pen1, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2, 200, 200);
            
            

            paper.FillEllipse(brGreen, pictureBoxDisplay.Width / 2 - width / 2, pictureBoxDisplay.Height / 2 - width / 2, 200, 200);
            paper.DrawEllipse(Pen1, pictureBoxDisplay.Width / 2 - width / 2, pictureBoxDisplay.Height / 2 - width /2, 200, 200);
            


            paper.DrawLine(Pen1, corner1, corner2);
            Pen1.Color = Color.Tomato;
            paper.DrawLine(Pen1, corner2, corner3);
            Pen1.Color = Color.YellowGreen;
            paper.DrawLine(Pen1, corner3, corner4);
            Pen1.Color = Color.Blue;
            paper.DrawLine(Pen1, corner4, corner1);

           



        }

        private void buttonDrawPattern_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();

            Pen Pen1 = new Pen(Color.Black, 2);

            int x = 10;
            int y = 10;

            paper.DrawRectangle(Pen1, x, y, WIDTH, HEIGHT);
            paper.DrawRectangle(Pen1, x + WIDTH/2, y + HEIGHT, WIDTH, HEIGHT);
            paper.DrawRectangle(Pen1, x + WIDTH, y + HEIGHT*2, WIDTH, HEIGHT);

            x += WIDTH + WIDTH / 2;
            y += HEIGHT * 3;

            paper.DrawRectangle(Pen1, x, y, WIDTH, HEIGHT);

            x += WIDTH / 2;
            y += HEIGHT;

            paper.DrawRectangle(Pen1, x, y, WIDTH, HEIGHT);



        }
    }
}
