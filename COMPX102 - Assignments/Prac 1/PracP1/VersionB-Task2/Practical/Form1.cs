using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        //An array that stores rain fall values in mm
        int[] rainfallArray = new int[] { 10, 5, 30, 50, 0, 2, 0, 0, 8, 25, 15, 6, 0, 0, 22 };
        //The width of a bar in the graph
        const int BAR_WIDTH = 40;
        //The maximum amount of rainfall
        const int MAX_RAINFALL = 100;
        //The gap between the bars on the graph
        const int GAP = 5;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the barheight for a rainfall value.
        /// </summary>
        /// <param name="value">The rainfall value to calculate the bar height for</param>
        /// <returns>The height of a bar in the graph for the rainfall value</returns>
        private int CalcBarHeight(int value)
        {
            int height = pictureBoxDisplay.Height * value / MAX_RAINFALL;
            return height;
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clears the picturebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }

        /// <summary>
        /// Calculates and displays the number of 0 rainfall days
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i <rainfallArray.Length; i++)
            {
                if (rainfallArray[i] == 0)
                {
                    x += 1;
                }
            }
            textBoxDisplay.Text = x.ToString();
        }

        /// <summary>
        /// Draws the rainfall values as graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawGraph_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen PenBlack = new Pen(Color.Black, 3);
            Brush brush= new SolidBrush(Color.Green);
            int x = 0;

            for (int i = 0; i < rainfallArray.Length; i++)
            {
                int y = 0;
                int barHeight = CalcBarHeight(rainfallArray[i]);

                paper.FillRectangle(brush, x + GAP, pictureBoxDisplay.Bottom - barHeight, BAR_WIDTH, barHeight);
                paper.DrawRectangle(PenBlack, x + GAP, pictureBoxDisplay.Bottom - barHeight, BAR_WIDTH, barHeight);
                x += BAR_WIDTH + GAP;
            }
            
        }
    }
}
