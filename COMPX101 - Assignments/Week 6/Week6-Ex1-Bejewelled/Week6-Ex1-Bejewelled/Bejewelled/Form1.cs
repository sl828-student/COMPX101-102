using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bejewelled
{
    public partial class Form1 : Form
    {
        //the width of a jewel
        const int JEWEL_WIDTH = 50;

        //the height of a jewel
        const int JEWEL_HEIGHT = 50;

        //the number of colours that a jewel can be
        //colours in order from 0 to 6 are: red, orange, yellow, green, blue, indigo and violet
        const int NUMBER_OF_COLOURS = 7;

        //Creating and seeding the Random object for generating random numbers
        //Hint: use randomGenerator.Next(10) to generate a number from 0 to 9
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears display, textboxes and sets focus
            pictureBoxDisplay.Refresh();
            textBoxRows.Text = "";
            textBoxColumns.Text = "";
            textBoxRows.Focus();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

            int numRows = int.Parse(textBoxRows.Text);
            int numColumns = int.Parse(textBoxColumns.Text);

            //Error message and return if values input for rows and columns do not fit the display
            if (numColumns * JEWEL_WIDTH > pictureBoxDisplay.Width || numRows * JEWEL_HEIGHT > pictureBoxDisplay.Height)
            {
                MessageBox.Show("Number of columns and rows will not fit the display");
                textBoxRows.Focus(); 
                return;
                
            }

            Graphics drawBox = pictureBoxDisplay.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);

            for(int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numColumns; col++)
                {
                    int colourRandom = rand.Next(1, 8);
                    if (colourRandom == 1)
                    { 
                        brush.Color = Color.Red; 
                    }
                    else if (colourRandom == 2)
                    {
                        brush.Color = Color.Orange;
                    }
                    else if (colourRandom == 3)
                    {
                        brush.Color = Color.Yellow;
                    }
                    else if (colourRandom == 4)
                    {
                        brush.Color = Color.Green;
                    }
                    else if (colourRandom == 5)
                    {
                        brush.Color = Color.Blue;
                    }
                    else if (colourRandom == 6)
                    {
                        brush.Color = Color.Indigo;
                    }
                    else if (colourRandom == 7)
                    {
                        brush.Color = Color.Violet;
                    }

                    drawBox.FillEllipse(brush, col * JEWEL_WIDTH, row * JEWEL_HEIGHT, JEWEL_WIDTH, JEWEL_HEIGHT);
                }
            }
            




        }

        private void textBoxRows_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
