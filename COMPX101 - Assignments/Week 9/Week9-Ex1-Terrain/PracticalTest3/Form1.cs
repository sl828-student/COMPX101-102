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
using System.Web;

namespace PracticalTest3
{
    public partial class Form1 : Form
    {
        //Name:
        //Id:

        //The number of columns in the grid
        const int NUM_COLUMNS = 26;

        //The number of rows in the grid
        const int NUM_ROWS = 50;

        //The size of each Tile in the grid
        const int TILE_SIZE = 10;

        //Colors for the various terrain tiles
        Color GROUND_COLOR = Color.SandyBrown;
        Color MOUNTAIN_COLOR = Color.LightGray;
        Color FOREST_COLOR = Color.ForestGreen;
        Color TOWN_COLOR = Color.Purple;

        List<string> groundList = new List<string>();
        List<string> MountainList = new List<string>();
        List<string> ForestList = new List<string>();
        List<string> TownList = new List<string>();

        int totalValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Converts the letter that represents a column into
        /// an x position in the grid.
        /// </summary>
        /// <param name="column">Letter of the column</param>
        /// <returns>The x position of the column in the grid</returns>
        private int CalculateX(string column)
        {
            int x = (column[0] - 'A') * TILE_SIZE;

            return x;
        }

        /// <summary>
        /// calculate sthe y
        /// </summary>
        /// <param name="rowValue"></param>
        /// <returns></returns>
        private int CalculateY(int rowValue)
        {
            int y = (rowValue - 1) * TILE_SIZE;
            return y;
        }
        /// <summary>
        /// Display a tile in the grid at the given x and y position in
        /// the given colour.
        /// </summary>
        /// <param name="paper">Where to draw the tile</param>
        /// <param name="x">The x position of the tile</param>
        /// <param name="y">The y position of the tile</param>
        /// <param name="tileColor">The colour of the tile</param>
        private void DisplayTile(Graphics paper, int x, int y, Color tileColor)
        {
            SolidBrush br = new SolidBrush(tileColor);
            Pen pen1 = new Pen(Color.Gray, 1);
            paper.FillRectangle(br, x, y, TILE_SIZE, TILE_SIZE);
            paper.DrawRectangle(pen1, x, y, TILE_SIZE, TILE_SIZE);
        }

        /// <summary>
        /// Display the grid in the base ground colour.
        /// </summary>
        /// <param name="paper">Where to draw the grid</param>
        private void DisplayGrid(Graphics paper)
        {
            //x and y position of the current tile
            int x = 0;
            int y = 0;
            //For each row of tiles to draw
            for (int row = 1; row <= NUM_ROWS; row++)
            {
                //For each tile to draw in the current row
                for (int col = 1; col <= NUM_COLUMNS; col++)
                {
                    //Draw the tile at the current x and y position
                    //in the ground colour
                    DisplayTile(paper, x, y, GROUND_COLOR);
                    //Shift x to the right by width of tile
                    x += TILE_SIZE;
                }
                //Shift y down by height of tile
                y += TILE_SIZE;
                //Shift x back to start of row
                x = 0;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxMap.CreateGraphics();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.csv)| *.csv| All Files (*.*)| *.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //display normal grid
                    DisplayGrid(paper);

                    //opens the selected file
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        

                        //reads file line by line
                        while ((line = reader.ReadLine()) != null) //while (!reader.EndOfStream)
                        {
                            try
                            {
                                //Splits the lines of values into an array as string
                                string[] csvArray = line.Split(',');

                                //check there is the correct number of elements
                                if (csvArray.Length == 4)
                                {
                                    string column = csvArray[0];
                                    int row = int.Parse(csvArray[1]);
                                    string terrainType = csvArray[2];
                                    int terrainValue = int.Parse(csvArray[3]);

                                    //Add values to list box
                                    listBoxData.Items.Add(column.PadRight(5) + row.ToString().PadRight(5) + terrainType.PadRight(5) + terrainValue.ToString());

                                    //calc total
                                    totalValue += terrainValue;

                                    //draw ground
                                    if (terrainType == "Ground")
                                    {
                                        DisplayTile(pictureBoxMap.CreateGraphics(), CalculateX(column), CalculateY(row), GROUND_COLOR);
                                        groundList.Add(line);
                                    }
                                    //draw mountain
                                    else if (terrainType == "Mountain")
                                    {
                                        DisplayTile(pictureBoxMap.CreateGraphics(), CalculateX(column), CalculateY(row), MOUNTAIN_COLOR);
                                        groundList.Add(line);
                                    }
                                    //draw forest
                                    else if (terrainType == "Forest")
                                    {
                                        DisplayTile(pictureBoxMap.CreateGraphics(), CalculateX(column), CalculateY(row), FOREST_COLOR);
                                        groundList.Add(line);
                                    }
                                    //draw town
                                    else if (terrainType == "Town")
                                    {
                                        DisplayTile(pictureBoxMap.CreateGraphics(), CalculateX(column), CalculateY(row), TOWN_COLOR);
                                        groundList.Add(line);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error " + line);
                                    }

                                    //textBoxDisplay.Text = totalValue.ToString();


                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error processing line: " + line + ". " + ex.Message);
                            }
                        }
                        reader.Close();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }



        }

        private void sumTerrainValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = totalValue.ToString();
        }
    }
}
