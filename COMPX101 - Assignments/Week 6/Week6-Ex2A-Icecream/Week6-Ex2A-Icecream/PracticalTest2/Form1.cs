using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTest2
{
    public partial class Form1 : Form
    {
        //Name: 
        //Id: 

        //The number of rows of ice cream tubs
        const int NUM_ROWS = 8;
        //The size of a 2L tub of icecream, i.e. the width and height of a tub
        const int TUB_SIZE = 40;
        //The gap between the rows and columns of icecream tubs
        const int GAP = 5;
        //The minimum number of columns 
        const int MINCOLUMNS = 4;
        //The Maximum number of columns 
        const int MAXCOLUMNS = 11;



        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clears textbox and picturebox when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void clearTextBoxes()
        {
            textBoxColumns.Clear();
            textBoxColumns.Focus();
            pictureBoxDisplay.Refresh();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
        /// <summary>
        /// Quits the application when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Draws tubs of icecream according to user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawTubs_Click(object sender, EventArgs e)
        {
            try
            {
                int columns = 0;
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Green);
                Pen pen1 = new Pen(Color.Black);

                //converts user input to integer
                columns = int.Parse(textBoxColumns.Text);

                //checks to make sure user input is within the parameters 
                if (columns < MINCOLUMNS || columns > MAXCOLUMNS)
                {
                    MessageBox.Show("Please enter a valid number of columns. The minimum number of columns is 4 and the maximum is 11.");
                    textBoxColumns.Clear();
                    textBoxColumns.Focus();
                }
                //if user input is valid the outputs will be drawn 
                else
                {
                    for (int col = 0; col < columns; col++)
                    {
                        for (int row = 0; row < NUM_ROWS; row++)
                        {
                            int x = col * (TUB_SIZE + GAP);
                            int y = row * (TUB_SIZE + GAP);

                            if (row < 4)
                            {
                                brush.Color = Color.Orange;
                            }
                            else
                            {
                                brush.Color = Color.LightBlue;
                            }
                            paper.FillRectangle(brush, x, y, TUB_SIZE, TUB_SIZE);
                            paper.DrawRectangle(pen1, x, y, TUB_SIZE, TUB_SIZE);
                        }

                    }
                }
            }
            //handles any errors 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clearTextBoxes();
            }

        }
    }
}
