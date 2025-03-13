using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_One
{
    class Square
    {
        //one square of 'land' in the dungeon, which has a terrain style and holds a dungeon item

        //enum of the different terrain types, and their corresponding symbol
        public enum TerrainTypes {  Floor, Wall, Water }
        public static string[] TerrainSymbols = { "_", "#", "~" };
        //symbol to display if square is not known
        public const string UNKNOWN = " ";

        private TreasureQuantity item_;
        private TerrainTypes terrain_;
        private bool known_ = false;
       
        /// <summary>
        /// initialises the square with terrain type and null items
        /// </summary>
        /// <param name="terrain"></param>
        public Square(TerrainTypes terrain)
        {
            terrain_ = terrain;
            item_ = null; //initially no items
        }
        /// <summary>
        /// converted from perviously treasure, gets and sets the item collected at a squarer
        /// </summary>
        public TreasureQuantity Item
        {
            get { return item_; }
            set { item_ = value; }
        }
        /// <summary>
        /// returns terain type 
        /// </summary>
        public TerrainTypes Terrain
        {
            get { return terrain_; }
        }
        /// <summary>
        /// gets and sets a boolian if know 
        /// </summary>
        public bool Known
        {
            get { return known_; }
            set { known_ = value; }
        }

        /// <summary>
        /// returns terrain symbo;s
        /// </summary>
        public string Symbol
        {
            get {
                if (!known_)
                    return UNKNOWN;
                if (Item != null)
                    return Item.ToString();
                return TerrainSymbols[(int)terrain_];
            }
        }
        /// <summary>
        /// override the tostring method to return the terrain as a string and any items 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = terrain_.ToString();
            if (!known_)
                 s = "unknown " + s;
            if (Item != null)
                s += " with a " + Item.ToString();
            return s;
        }
    }
}
