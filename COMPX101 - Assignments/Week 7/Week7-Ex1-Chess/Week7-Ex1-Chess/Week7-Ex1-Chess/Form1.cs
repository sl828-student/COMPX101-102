using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Ex1_Chess
{
    public partial class Form1 : Form
    {
        //The minimum size of the board
        const int MIN_BOARD_SIZE = 2;
        //The maximum size of the board
        const int MAX_BOARD_SIZE = 10;
        //The width of a square
        const int SQUARE_WIDTH = 50;
        //The height of a square
        const int SQUARE_HEIGHT = 50;

        //the colour of a Dark square (a variable since Color cannot be a const)
        Color DarkBrown = Color.SaddleBrown;

        //the colour of a Light square (a variable since Color cannot be a const)
        Color LightBrown = Color.SandyBrown;

        public Form1()
        {
            InitializeComponent();
        }
        private void drawSquare(Graphics g, int x, int y)
        {
            
            SolidBrush brush1 = new SolidBrush(LightBrown);
            Pen pen1 = new Pen(Color.Black, 2);

            g.FillRectangle(brush1, x, y, SQUARE_WIDTH, SQUARE_HEIGHT);
            g.DrawRectangle(pen1, x, y, SQUARE_WIDTH, SQUARE_HEIGHT);
        }

        private void drawRow(Graphics g, int boardSize, int rowNum, int yPos)
        {
            SolidBrush brush1 = new SolidBrush(LightBrown);
            Pen pen1 = new Pen(Color.Black, 2);
            int x = 0;
            for (int col = 1; col <= boardSize; col++)
            {
                if ((col + rowNum) % 2 == 0)
                {
                    brush1.Color = LightBrown;
                    g.FillRectangle(brush1, x, yPos, SQUARE_WIDTH, SQUARE_HEIGHT);
                    g.DrawRectangle(pen1, x, yPos, SQUARE_WIDTH, SQUARE_HEIGHT);

                }
                else
                {
                    brush1.Color = DarkBrown;
                    g.FillRectangle(brush1, x, yPos, SQUARE_WIDTH, SQUARE_HEIGHT);
                    g.DrawRectangle(pen1, x, yPos, SQUARE_WIDTH, SQUARE_HEIGHT);
                }
                x += SQUARE_WIDTH;
            }
            

        }
        /// <summary>
        /// Exits the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Clears textBoxes and the picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBoardSize.Clear();
            pictureBoxDisplay.Refresh();
            textBoxBoardSize.Focus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawBoard_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            int yPos = 0;
           
            try
            { 
                int boardsize = int.Parse(textBoxBoardSize.Text);
                if (boardsize > 0 && boardsize < 11)
                    for (int row = 0; row < boardsize; row++) 
                    {
                        drawRow(paper, boardsize, row, yPos);
                        yPos += SQUARE_HEIGHT;

                    }
                else
                {
                    MessageBox.Show("Please enter a boardsize between 1-10");
                    textBoxBoardSize.Clear();
                    pictureBoxDisplay.Refresh();
                    textBoxBoardSize.Focus();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxBoardSize.Clear();
                pictureBoxDisplay.Refresh();
                textBoxBoardSize.Focus();

            }

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
