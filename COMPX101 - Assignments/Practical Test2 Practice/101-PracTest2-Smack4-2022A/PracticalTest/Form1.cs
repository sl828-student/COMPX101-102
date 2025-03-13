using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTest
{
    public partial class Form1 : Form
    {
        //The width and height of each square
        const int SQUARE_SIZE = 50;

        //Constants for the maximum and minimum values 
        const int MAX_SIZE = 20;
        const int MIN_SIZE = 6;


        public Form1()
        {
            InitializeComponent();

            //Focuses on input textbox
            textBoxInput.Focus();
        }

        /// <summary>
        /// Exits the form when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        /// <summary>
        /// Clears the picutreBox and textbox when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
            textBoxInput.Clear();
            textBoxInput.Focus();
        }
        /// <summary>
        /// this method will draw the smack board based on the input value from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Green);
                Pen pen1 = new Pen(Color.Black);

                int boardSize = int.Parse(textBoxInput.Text);

                int x = 0;
                int y = 0;

                // Check if board size is within limits and even
                if (boardSize < MIN_SIZE || boardSize > MAX_SIZE && boardSize % 2 == 0)
                {
                    MessageBox.Show("Please enter a valid even number between 6 and 20 for the board size.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                }
                //If user inputs Valid number the board will be drawn
                else
                {
                    for(int col =0; col <= boardSize; col++)
                    {
                        for(int row =0; row <= boardSize; row++)
                        {
     
                            if (row == col || row + col == boardSize)
                            {
                                // Changes brsuh colour for Diagonal line of light pink squares
                                brush.Color = Color.LightPink;
                            }
                            else
                            {
                                //Light Blue brush colour
                                brush.Color = Color.LightBlue;
                            }
                            //Fill and Draw square
                            paper.FillRectangle(brush, x, y, SQUARE_SIZE, SQUARE_SIZE);
                            paper.DrawRectangle(pen1, x, y, SQUARE_SIZE, SQUARE_SIZE);
                            //Shift x accross by square size
                            x += SQUARE_SIZE;
                            
                            
                        }
                        //reset x co-ordinate
                        x = 0;

                        //Shift y co-ordinate down by square size
                        y+= SQUARE_SIZE;
                    }
                }
            }
            //Checks for errors, displays error message if triggered
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
