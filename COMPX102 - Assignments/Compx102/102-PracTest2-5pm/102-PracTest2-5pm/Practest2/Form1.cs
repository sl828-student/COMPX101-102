using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Practest2
{
    public partial class Form1 : Form
    {
        const string CSVFILTER = "CSV files|*.csv|All files|*.*";

        public const int WALL_HEIGHT = 400; 

        Wall wall; //the current gallery wall being designed

        Artworks currentSelect; //the currently selected painting in the wall

        public Form1()
        {
            InitializeComponent();
            pictureBoxWall.Height = WALL_HEIGHT;
        }
        /// <summary>
        /// creates new wall, draws empty wall
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wall = new Wall();
            pictureBoxWall.Invalidate();  //draw empty wall

        }
        /// <summary>
        /// Loads a file to the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wall = new Wall();
            try
            {
                openFileDialog1.Filter = CSVFILTER;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader infile = new StreamReader(openFileDialog1.FileName);

                    // read list of paintings
                    while (!infile.EndOfStream)
                    {
                        //data is "x,y,w,h"
                        string line = infile.ReadLine();
                        string[] data = line.Split(',');

                        //checks if the data is for a painting
                        if (data.Length == 4)
                        {
                            int x = int.Parse(data[0]); //first data is x value
                            int y = int.Parse(data[1]); //second data is y
                            int w = int.Parse(data[2]); //third data is width
                            int h = int.Parse(data[3]); //fourth data is height
                            Painting artwork = new Painting(x, y, w, h);
                            wall.AddPainting(artwork);
                        }
                        //checks if data is for a pedestal 
                        else if (data.Length == 5)
                        {
                            int x = int.Parse(data[0]); //first data is x value
                            int y = int.Parse(data[1]); //second data is y
                            int w = int.Parse(data[2]); //third data is width
                            int h = int.Parse(data[3]); //fourth data is height
                            string c = data[4]; //fifth is colour
                            Pedestal pedestal = new Pedestal(x, y, w, h, c);
                            wall.AddArtwork(pedestal);
                        }
                        else //incorrect length for a painting
                        {
                            MessageBox.Show("Invalid data on line:" + line);
                        }

                    }
                    infile.Close(); //be a tidy kiwi
                    pictureBoxWall.Invalidate();  //cause picturebox to be painted with gallery wall
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        /// <summary>
        /// Outputs a file based on what artworks have been created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = CSVFILTER;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter outfile = new StreamWriter(saveFileDialog1.FileName);

                    // write list of artworks, both paintings and pedestals 
                    foreach (Artworks p in wall.artworks)
                    {
                        outfile.WriteLine(p.ToString());  //ToString method gives CSV format
                    }
                    outfile.Close(); //be a tidy kiwi
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    /// <summary>
    /// exits
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// changes the background colour of the picturebox
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                InitialiseWall(); //in case they did not create a new wall first
                wall.BackgroundColour = colorDialog1.Color;
                pictureBoxWall.Invalidate();
            }
        }

        /// <summary>
        /// Initialises the wall variable if it has not already been initialised
        /// </summary>
        private void InitialiseWall()
        {
            if (wall == null)
            {
                wall = new Wall();
            }
        }

        /// <summary>
        /// Resets all input controls that control adding new paintings
        /// </summary>
        private void ResetInputParams()
        {
            txtXPos.Clear();
            txtYPos.Clear();
            txtWidth.Clear();
            txtHeight.Clear();
        }

        /// <summary>
        /// Populate input controls from selected painting
        /// </summary>
        private void SetInputParams()
        {
            txtXPos.Text = currentSelect.Frame.X.ToString();
            txtYPos.Text = currentSelect.Frame.Y.ToString();
            txtWidth.Text = currentSelect.Frame.Width.ToString();
            txtHeight.Text = currentSelect.Frame.Height.ToString();
        }

        /// <summary>
        /// validates if appropriate input is in the textboxes
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            try
            {
                return int.Parse(txtXPos.Text) >= 0 &&
                       int.Parse(txtXPos.Text) <= pictureBoxWall.Width - int.Parse(txtWidth.Text) &&
                       int.Parse(txtYPos.Text) >= 0 &&
                       int.Parse(txtYPos.Text) <= pictureBoxWall.Height - int.Parse(txtHeight.Text) &&
                       int.Parse(txtWidth.Text) > 0 &&
                       int.Parse(txtHeight.Text) > 0;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return false; //try-catch has caught 'not a number' error
        }
    /// <summary>
    /// Displays the wall
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void pictureBoxWall_Paint(object sender, PaintEventArgs e)
        {
            if (wall != null)
                wall.Display(e.Graphics);
        }

        private void pictureBoxWall_MouseUp(object sender, MouseEventArgs e)
        {
            InitialiseWall(); //in case they did not create a new wall first
            currentSelect = wall.SelectArtwork(e.X, e.Y);
            if (currentSelect != null) //checks to see if the mouse is over a painting, and selects it if it is
                SetInputParams();
            else //otherwise clear the selected painting data
                ResetInputParams();
        }
        /// <summary>
        /// Adds/updates a painting 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int x = int.Parse(txtXPos.Text);
                int y = int.Parse(txtYPos.Text);
                int w = int.Parse(txtWidth.Text);
                int h = int.Parse(txtHeight.Text);
                if (currentSelect == null)
                {
                    Painting newPainting = new Painting(x, y, w, h);
                    InitialiseWall(); //in case they did not create a new wall first
                    wall.AddPainting(newPainting);
                    ResetInputParams();
                }
                else if(currentSelect is Painting)//updating an existing painting
                {
                    Painting pain = (Painting)currentSelect;
                    pain.Update(x, y, w, h);
                 }
                else if (currentSelect is Pedestal)
                {
                    Pedestal ped = (Pedestal)currentSelect;
                    ped.Update(x, y, w, h);
                }
                pictureBoxWall.Invalidate(); //use paint method to draw gallery wall
            }
            else
            {
                MessageBox.Show("Invalid input parameters");
            }
        }
        /// <summary>
        /// adds/ updates a pedestal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPedestal_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int x = int.Parse(txtXPos.Text);
                int y = int.Parse(txtYPos.Text);
                int w = int.Parse(txtWidth.Text);
                int h = int.Parse(txtHeight.Text);
                string colour = string.Empty;
                if(radioButtonBlack.Checked == true)
                {
                    colour = "black";
                }
                else
                {
                    colour = "white";
                }

                if (currentSelect == null)
                {
                    Pedestal newPedestal = new Pedestal(x, y, w, h, colour);
                    InitialiseWall(); //in case they did not create a new wall first
                    wall.AddArtwork(newPedestal);
                    ResetInputParams();
                }
                else if (currentSelect is Pedestal)
                {
                    Pedestal ped = (Pedestal)currentSelect;
                    ped.Update(x, y, w, h);
                }
                    pictureBoxWall.Invalidate(); //use paint method to draw gallery wall
            }
            else
            {
                MessageBox.Show("Invalid input parameters");
            }

        }
    }
}
