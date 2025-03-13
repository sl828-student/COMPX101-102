using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace map
{
    public partial class Form1 : Form
    {
        const string CSVFILTER = "CSV files|*.csv|All files|*.*";

        Map currentMap; // the current treasure map

        Features currentSelect; // the currently selected direction

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new map object and sets it up for directions to be added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMap = new Map();
            pictureBoxMap.Invalidate();  // draw empty map
        }

        /// <summary>
        /// Opens a saved map, reads out the directions and displays them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMap = new Map();
            try
            {
                openFileDialog1.Filter = CSVFILTER;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader infile = new StreamReader(openFileDialog1.FileName);

                    // Read list of directions
                    while (!infile.EndOfStream)
                    {
                        // Data is "startX,startY,endX,endY,size,name"
                        string line = infile.ReadLine();
                        string[] data = line.Split(',');

                        if (data.Length == 6)
                        {
                            int startx = int.Parse(data[0]);    // first data is start x value
                            int starty = int.Parse(data[1]);    // second data is start y
                            int endx = int.Parse(data[2]);      // third data is end x value
                            int endy = int.Parse(data[3]);      // fourth data is end y
                            int size = int.Parse(data[4]);      // fifth data is size
                            string name = data[5];              // sixth data is name of direction
                            Direction direction = new Direction(startx, starty, endx, endy, size, name);
                            currentMap.AddFeatures(direction);
                        }
                        else if(data.Length == 4)
                        {
                            int startx = int.Parse(data[0]);    // first data is start x value
                            int starty = int.Parse(data[1]);    // second data is start y
                            int size = int.Parse(data[2]);      // third data is size
                            string name = data[3];              // fourth data is name of direction
                            Landmarks landmark = new Landmarks(startx, starty, size, name);
                            currentMap.AddFeatures(landmark);
                        }
                        // Invalid data handling
                        else
                        {
                            MessageBox.Show("Invalid data on line:" + line);
                        }

                    }
                    infile.Close(); // be a tidy kiwi
                    pictureBoxMap.Invalidate();  // cause picturebox to be painted
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// Saves a map with all the directions on it to a CSV file
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

                    // Write list of directions
                    foreach (Features d in currentMap.featuresList)
                    {
                        outfile.WriteLine(d.ToString());  // ToString method from Directions class gives CSV format
                    }
                    outfile.Close(); // be a tidy kiwi
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Initialises the map variable if it has not already been initialised
        /// </summary>
        private void InitialiseMap()
        {
            if (currentMap == null)
            {
                currentMap = new Map();
            }
        }

        /// <summary>
        /// Resets all input controls that control adding new directions
        /// </summary>
        private void ResetInputParams()
        {
            txtName.Clear();
            txtXPos.Clear();
            txtYPos.Clear();
            txtEndX.Clear();
            txtEndY.Clear();
            txtSize.Clear();
        }

        /// <summary>
        /// Populate input controls from selected direction
        /// </summary>
        private void SetInputParams()
        {
            txtName.Text = currentSelect._Name;
            txtXPos.Text = currentSelect.Location.X.ToString();
            txtYPos.Text = currentSelect.Location.Y.ToString();

            txtSize.Text = currentSelect._Size.ToString();

            if (currentSelect is Direction)
            {
                Direction d = (Direction)currentSelect;
                txtEndX.Text = d.EndLocation.X.ToString();
                txtEndY.Text = d.EndLocation.Y.ToString();
            }
        }

        /// <summary>
        /// Validates if appropriate input is in the textboxes
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            try
            {
                return txtName.Text != "" &&
                    int.Parse(txtSize.Text) > 0 &&
                    CheckPoint(int.Parse(txtXPos.Text), int.Parse(txtYPos.Text)) && 
                    CheckPoint(int.Parse(txtEndX.Text), int.Parse(txtEndY.Text));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return false; //try-catch has caught 'not a number' error
        }

        /// <summary>
        /// Checks that a given point does not lie outside the picturebox
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool CheckPoint(int x, int y)
        {
            return x >= 0 && x <= pictureBoxMap.Width - int.Parse(txtSize.Text) &&
                y >= 0 && y <= pictureBoxMap.Height - int.Parse(txtSize.Text); 
        }

        /// <summary>
        /// Displays the information of a clicked on direction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMap_MouseUp(object sender, MouseEventArgs e)
        {
            InitialiseMap(); // in case they did not create a new page first
            currentSelect = currentMap.SelectFeature(e.X, e.Y);

            // If mouse is over a direction, select it and populate the list boxes
            if (currentSelect != null)
                SetInputParams();
            else // otherwise clear the selected direction data
                ResetInputParams();
        }

        /// <summary>
        /// Displays the map of directions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMap_Paint(object sender, PaintEventArgs e)
        {
            if (currentMap != null)
                currentMap.Display(e.Graphics);
        }

        /// <summary>
        /// Allows the user to add or update a direction on the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check for valid input
            if (ValidateInput())
            {
                int startx = int.Parse(txtXPos.Text);
                int starty = int.Parse(txtYPos.Text);
                int endx = int.Parse(txtEndX.Text);
                int endy = int.Parse(txtEndY.Text);
                int size = int.Parse(txtSize.Text);

                // If there is no direction currently selected, create a new one
                if (currentSelect == null)
                {
                    Direction newDirection = new Direction(startx, starty, endx, endy, size, txtName.Text);
                    InitialiseMap(); // in case they did not create a new page first
                    currentMap.AddFeatures(newDirection);
                    ResetInputParams();
                }
                // Otherwise you are updating an existing direction
                else
                {
                    if (currentSelect is Direction)
                    {
                        Direction d = (Direction)currentSelect;
                        d.MovePosition(startx, starty, endx, endy);
                    }
                    currentSelect._Size = size;
                    currentSelect._Name = txtName.Text;
                }
                pictureBoxMap.Invalidate(); // paint map in picturebox to show the new or updated direction
            }
            else
            {
                MessageBox.Show("Invalid input parameters");
            }
        }

        /// <summary>
        /// Sets map to have no background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
                InitialiseMap(); // in case they did not create a new map first
                currentMap.Background = null;
                pictureBoxMap.Invalidate();
        }
        
        /// <summary>
        /// Sets map to use background1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useBackground1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitialiseMap(); // in case they did not create a new map first
            currentMap.Background = map.Properties.Resources.treasuremapblank1;
            pictureBoxMap.Invalidate();

        }

        /// <summary>
        /// Sets map to use background2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useBackground2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitialiseMap(); // in case they did not create a new map first
            currentMap.Background = map.Properties.Resources.treasuremapblank2;
            pictureBoxMap.Invalidate();

        }

        /// <summary>
        /// Sets map to use background3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useBackground3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitialiseMap(); // in case they did not create a new map first
            currentMap.Background = map.Properties.Resources.treasuremapblank3;
            pictureBoxMap.Invalidate();

        }

        private void buttonAddUpdateLandmark_Click(object sender, EventArgs e)
        {
            // Check for valid input
            if (ValidateInput())
            {
                int startx = int.Parse(txtXPos.Text);
                int starty = int.Parse(txtYPos.Text);
                int endx = int.Parse(txtEndX.Text);
                int endy = int.Parse(txtEndY.Text);
                int size = int.Parse(txtSize.Text);

                // If there is no direction currently selected, create a new one
                if (currentSelect == null)
                {
                    Landmarks newLandmark = new Landmarks(startx, starty, size, txtName.Text);
                    InitialiseMap(); // in case they did not create a new page first
                    currentMap.AddFeatures(newLandmark);
                    ResetInputParams();
                }
                // Otherwise you are updating an existing direction
                else
                {
                    if (currentSelect is Landmarks)
                    {
                        Landmarks l = (Landmarks)currentSelect;
                        l.MovePosition(startx, starty);
                    }
                    currentSelect._Size = size;
                    currentSelect._Name = txtName.Text;
                }
                pictureBoxMap.Invalidate(); // paint map in picturebox to show the new or updated direction
            }
            else
            {
                MessageBox.Show("Invalid input parameters");
            }
        }
    }
}
