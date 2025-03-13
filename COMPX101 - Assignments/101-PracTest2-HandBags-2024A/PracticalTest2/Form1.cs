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

        //Name: Shokei Leger-Yoshihara
        //ID: 1656804

        //Width of a hand bag
        const int BAG_WIDTH = 50;
        //Height of a hand bag
        const int BAG_HEIGHT = 50;
        //The number of columns of hand bags to draw
        const int NUM_COLUMNS = 10;
        //The gap between rows and columns
        const int GAP = 10;
        //The minimum number of row
        const int MIN_ROWS = 2;
        //The max number of rows
        const int MAX_ROWS = 10;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method calls the clearTextBox method to clear the textbox and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        /// <summary>
        /// This method clears the texbox, focuses it and clears the picturebox
        /// </summary>
        private void clearTextBox()
        {
            textBoxRows.Clear();
            textBoxRows.Focus();
            pictureBoxDisplay.Refresh();

            }

        /// <summary>
        /// This method will exit the application when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// this method when clicked will draw the handbags as they should be displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                //Declared variables 
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Red);
                Pen pen1 = new Pen(Color.Black, 2);
                int x = 0;
                int y = 0;

                //Converts the input into textbox into integer type
                int rows = int.Parse(textBoxRows.Text);

                //Checks to see if user input for number of rows is valid
                if (rows < MIN_ROWS || rows > MAX_ROWS )
                {
                    MessageBox.Show("Please enter a valid number of rows. The minimum number of rows is 2 and the maximum is 10.");
                    clearTextBox();
                }
                else
                {
                    for (int i = 1; i <= NUM_COLUMNS; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            

                            //Checks what color the bad will be
                            if(i % 3 == 0)
                            {
                                brush.Color = Color.Purple;
                            }
                            else
                            { 
                                brush.Color = Color.Red; 
                            }
                            //Draws the bags
                            paper.FillRectangle(brush, x, y, BAG_WIDTH, BAG_HEIGHT);
                            paper.DrawRectangle(pen1, x, y, BAG_WIDTH, BAG_HEIGHT);
                            y += BAG_HEIGHT + GAP;
                            
                        }
                        x += BAG_WIDTH + GAP;
                        y = 0;
                        
                    } 
                    

                }
            }
            //Handles any errors
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                clearTextBox();
            }
        }
    }
}
