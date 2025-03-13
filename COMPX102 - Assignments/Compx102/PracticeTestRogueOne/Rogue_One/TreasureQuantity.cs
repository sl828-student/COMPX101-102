using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_One
{
    /// <summary>
    /// Class takes any treasure found and records the quantity of different treasure types 
    /// </summary>
    public class TreasureQuantity
    {
        public Treasure _Treasure;
        public int _Quantity;
        public int _Experience;

        /// <summary>
        /// Constructor initialises the treasure quantity
        /// </summary>
        /// <param name="treasure"></param>
        /// <param name="quantity"></param>
        public TreasureQuantity(Treasure treasure, int quantity)
        {
            _Treasure = treasure;
            _Quantity = quantity;
            //the experience of treasure is the experience of the treasure multiplied by the quantity of that specific treasure
            _Experience= treasure.Experience * quantity;

        }
        /// <summary>
        /// overrides the tostring method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //returns the treasure description, the quantity and the experience of the treasure as a good looking string
            return this._Treasure.ToString() + ": " + this._Quantity + ", XP: " + this._Experience;
        }

        // get expresienbce = treaser.xp * quantity 

        
    }
}
