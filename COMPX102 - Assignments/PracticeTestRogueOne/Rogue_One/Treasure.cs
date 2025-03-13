using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_One
{
    /// <summary>
    /// pre-defines the cointypes and values
    /// </summary>
    public enum CoinType { Copper = 1, Silver = 5, Gold = 10 };

    /// <summary>
    /// this is the class for treasure
    /// </summary>
    public class Treasure 
    {
        //private properties
        private string symbol_ = ".";
        private string description_ = "";
        private int experience_ = 0;

        /// <summary>
        /// constructor initialises the values to the data passed in
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="description"></param>
        /// <param name="experience"></param>
        public Treasure(string letter, string description, int experience)
        {
            symbol_ = letter;
            description_ = description;
            experience_ = experience;
        }
        /// <summary>
        /// Returns the symbol for the treasure
        /// </summary>
        public string Symbol
        {
            get { return symbol_; }
        }
        /// <summary>
        /// returns the number of experience points of each treasure
        /// </summary>
        public int Experience
        {
            get { return experience_; }
        }
        /// <summary>
        /// Returns the description for the treasure
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return description_;
        }
        
    }
}
