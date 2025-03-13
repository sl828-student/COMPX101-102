using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practical
{
    public partial class Form1 : Form
    {
        //The currently selected game object.  Will be null if no object is selected
        //Uncomment this when you are ready to test your code
        GameObject selectedObject = null;

        //A list of the game objects in the current level of the game
        //Uncomment this when you are ready to test your code
        List<GameObject> objectList = new List<GameObject>();

        const string FILTER = "CSV files (*.csv)|*.csv";

        public Form1()
        {
            InitializeComponent();
            //Start the time that will automatically redraw the graphics
            timer1.Enabled = true;
        }


        
        /// <summary>
        /// This will clear out the picturebox and then draw all the obejcts in the current level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDisplay_Paint(object sender, PaintEventArgs e)
        {
            //Clear the picturebox to green
            e.Graphics.Clear(Color.LightGreen);
            //Write the code to draw all the objects in the level here
            foreach (GameObject objects in objectList)
            {
                objects.DrawObject(e.Graphics);
            }

        }

        /// <summary>
        /// The method will select an object if none has been selected.  If an object has been selected
        /// then it will move the object to the mouse position and then deselect the object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (selectedObject != null)
                { 
                    //Move object
                    selectedObject.MoveObject(e.X, e.Y);
                    //deselect object
                    selectedObject.DeselectObject();
                    //set selected object to null
                    selectedObject = null;
                }
                else
                {
                    //iterates through the list of objects
                    foreach (GameObject objects in objectList)
                    {
                        //checks if the obnject is clicked
                        if (objects.IsClicked(e.X, e.Y))
                        {

                            selectedObject = objects;
                            break;

                        }
                    }
                    //if there is no selected object
                    if (selectedObject == null)
                    {
                        //if the radio button is checked
                        if (radioButtonCannon.Checked)
                        {
                            //add new cannon to the object list
                            LoveCannon newCannon = new LoveCannon(e.X, e.Y, int.Parse(textBoxRange.Text));
                            objectList.Add(newCannon);
                        }
                        //Checks if the barreier radio button is checked 
                        if (radioButtonBarrier.Checked)
                        {
                            //Creates new barrier at mouseclick and adds the barrier to the objectlist
                            Barrier newBarrier = new Barrier(e.X, e.Y);
                            objectList.Add(newBarrier);
                        }
                    }
                }

            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// This method will refresh the picturebox to re-draw the graphics.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }

        /// <summary>
        /// This method will end the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method will make all the cannons in the level upgrade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upgradeCannonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(GameObject objects in objectList)
            {
                if(objects is LoveCannon cannon)
                {
                    cannon.UpgradeCannon();
                }
            }
            pictureBoxDisplay.Refresh();
        }

        /// <summary>
        /// This method will load all the game objects for the current level from the csv file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create, filter and check that open file dialog is open
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = FILTER;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //create streamreader
                StreamReader reader = new StreamReader(ofd.FileName);
                string line;
                while(!reader.EndOfStream) 
                { 
                    //split lines read in by the streamreader into parts by ','
                    line = reader.ReadLine();
                    string[] parts = line.Split(',');
                    //checks if the number of values read in is 3, if it is then its a cannon
                    if (parts.Length == 3)
                    {
                        //create new cannon based on read data and add to the objectlist
                        LoveCannon newCannon = new LoveCannon(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
                        objectList.Add(newCannon);
                    }
                    //if the number of values is 2, it is a barrier 
                    else if(parts.Length == 2)
                    {
                        //create new barrier based on the data and add it to the objectlist
                        Barrier newBarrier = new Barrier(int.Parse(parts[0]), int.Parse(parts[1]));
                        objectList.Add(newBarrier);

                    }
                    else
                    { throw new Exception("Something is wrong with the csv"); }
                
                }
            }

        }
    }
}
