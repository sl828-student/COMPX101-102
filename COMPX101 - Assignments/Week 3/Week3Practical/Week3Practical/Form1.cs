using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3Practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics drawSpace = pictureBoxDisplay.CreateGraphics();
            Pen penBlack = new Pen(Color.Black, 5);

            int xVariable = 50;
            int yVariable = 80;

            drawSpace.DrawRectangle(penBlack, xVariable, yVariable, 100, 50);
           // Point cornerSquare1 = new Point(xVariable, yVariable);
          //  Point cornerSquare2 = new Point(xVariable * 8, yVariable * 5);
           // Point cornerSquare3 = new Point(300, 50);
           // Point cornerSquare4 = new Point(300, 50);
            



        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Graphics drawSpace = pictureBoxDisplay.CreateGraphics();
            Pen penBlack = new Pen(Color.Black, 5);

            Point corner1 = new Point(50, 50);
            Point corner2 = new Point(300, 300);
            Point corner3 = new Point(300, 50);

            drawSpace.DrawLine(penBlack, corner1, corner2);
            drawSpace.DrawLine(penBlack, corner2, corner3);
            drawSpace.DrawLine(penBlack, corner3, corner1);



        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
    }
}
