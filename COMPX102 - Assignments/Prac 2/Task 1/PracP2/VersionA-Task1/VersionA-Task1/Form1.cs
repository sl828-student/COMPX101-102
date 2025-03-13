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

namespace VersionA_Task1
{
    public partial class Form1 : Form
    {
        //Name:
        //Id:

        //The number of columns in the grid
        const int NUM_COLUMNS = 50;
        //The number of rows in the grid
        const int NUM_ROWS = 26;
        //The size of each Tile in the grid
        const int TILE_SIZE = 10;
        //Colors for the various terrain tiles
        Color GROUND_COLOR = Color.LightGreen;
        Color PLASMA_CANNON_COLOR = Color.Purple;
        Color RAIL_GUN_COLOR = Color.Orange;
        Color MACHINE_GUN_COLOR = Color.Blue;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Converts the letter that represents a row into
        /// a y position in the grid.
        /// </summary>
        /// <param name="row">Letter of the row</param>
        /// <returns>The y position of the row in the grid</returns>
        private int CalcYPos(string row)
        {
            int y = (row[0] - 'A') * TILE_SIZE;

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
        /// Display the weapen at the given x and y value in the given colour.
        /// Also draws a circle around the weapon to show it's power/range.
        /// </summary>
        /// <param name="paper">Where to draw the weapon</param>
        /// <param name="x">The x position of the weapon</param>
        /// <param name="y">The y position of the weapon</param>
        /// <param name="weaponColor">The colour of the weapon</param>
        /// <param name="power">The range of the weapon</param>
        private void DisplayWeapon(Graphics paper, int x, int y, Color weaponColor, int power)
        {
            //Display the tile for the weapon in the correct colour
            DisplayTile(paper, x, y, weaponColor);
            Pen pen1 = new Pen(weaponColor, 1);
            //Draw a circle centred around the current weapon
            paper.DrawEllipse(pen1, x - (power - TILE_SIZE / 2), y - (power - TILE_SIZE / 2), power * 2, power * 2);
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
    }
}
