using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Lights
{
    public partial class Form1 : Form
    {
       /// <summary>
       /// Shokei Leger-Yoshihara 
       /// ID: 1656804
       /// </summary>
        
        public const int Gapvalue = 20;
        public Form1()
        {
            InitializeComponent();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ///Exits Application
            Application.Exit();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ///Click Clears picturebox and textbox
            textBoxSize.Clear();
            pictureBoxDrawing.Refresh();


        }

        private void buttonDrawLights_Click(object sender, EventArgs e)
        {
           ///Creates graphics paper
            Graphics paper = pictureBoxDrawing.CreateGraphics();

            ///Creates pen
            Pen PenBlack = new Pen(Color.Black, 3);

            ///Creates Brushes
            SolidBrush brushYellow = new SolidBrush(Color.Yellow);
            SolidBrush brushGreen = new SolidBrush(Color.Green);
            SolidBrush brushRed = new SolidBrush(Color.Red);

            int x=0, y=0;

            ///Draws ellipses

            try
            {
                paper.DrawEllipse(PenBlack, x + Gapvalue, y + Gapvalue, Convert.ToInt32(textBoxSize.Text), Convert.ToInt32(textBoxSize.Text));
                paper.FillEllipse(brushRed, x + Gapvalue, y + Gapvalue, Convert.ToInt32(textBoxSize.Text), Convert.ToInt32(textBoxSize.Text));

                paper.DrawEllipse(PenBlack, x + Gapvalue, y + Convert.ToInt32(textBoxSize.Text) + Gapvalue * 2, Convert.ToInt32(textBoxSize.Text), Convert.ToInt32(textBoxSize.Text));
                paper.FillEllipse(brushYellow, x + Gapvalue, y + Convert.ToInt32(textBoxSize.Text) + Gapvalue * 2, Convert.ToInt32(textBoxSize.Text), Convert.ToInt32(textBoxSize.Text));

                paper.DrawEllipse(PenBlack, x + Gapvalue, y + Convert.ToInt32(textBoxSize.Text) * 2 + Gapvalue * 3, Convert.ToInt32(textBoxSize.Text), Convert.ToInt32(textBoxSize.Text));
                paper.FillEllipse(brushGreen, x + Gapvalue, y + Convert.ToInt32(textBoxSize.Text) * 2 + Gapvalue * 3, Convert.ToInt32(textBoxSize.Text), Convert.ToInt32(textBoxSize.Text));
            }
            catch
            {
                MessageBox.Show("Invalid input.");
                textBoxSize.Clear();
                textBoxSize.Focus();

            }

        }


    }
}
