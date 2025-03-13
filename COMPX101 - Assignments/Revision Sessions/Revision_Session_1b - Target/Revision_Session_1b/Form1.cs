using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision_Session_1b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateTarget_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxBullseye.CreateGraphics();
            
            Pen PenWhite = new Pen(Color.White , 2);
            Pen PenBlack = new Pen (Color.Black , 2);

            SolidBrush brushRed = new SolidBrush(Color.Red);
            SolidBrush brushBlack= new SolidBrush(Color.Black);
            SolidBrush  brushWhite = new SolidBrush(Color.White);

            int radius = 300;
            
            paper.FillEllipse(brushBlack, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            paper.DrawEllipse(PenWhite, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            radius -= 50;
            
            paper.FillEllipse(brushRed, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            paper.DrawEllipse(PenWhite, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            radius -= 50;

            paper.FillEllipse(brushBlack, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            paper.DrawEllipse(PenWhite, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            radius -= 50;

            paper.FillEllipse(brushRed, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            paper.DrawEllipse(PenWhite, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            radius -= 50;

            paper.FillEllipse(brushBlack, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            paper.DrawEllipse(PenWhite, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            radius -= 50;

            paper.FillEllipse(brushRed, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            paper.DrawEllipse(PenWhite, pictureBoxBullseye.Width / 2 - radius / 2, pictureBoxBullseye.Height / 2 - radius / 2, radius, radius);
            radius -= 50;

            paper.DrawLine(PenBlack, pictureBoxBullseye.Width / 2, 0, pictureBoxBullseye.Width / 2, pictureBoxBullseye.Height);
            paper.DrawLine(PenBlack, 0, pictureBoxBullseye.Height/2, pictureBoxBullseye.Width, pictureBoxBullseye.Height / 2);

        }
    }
}
