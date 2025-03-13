using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_One
{
    class Adventurer
    {
        //symbol to display representing adventurer
        public const string ADVENTURER = "@";
        //stores an adventurer
        public int X;
        public int Y;
        public BindingList<TreasureQuantity> Carrying;
        public string Name;

        /// <summary>
        /// Constructor initialises the adventurer to the values passed in
        /// </summary>
        /// <param name="name"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Adventurer(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
            Carrying = new BindingList<TreasureQuantity>();
        }
        /// <summary>
        /// returns the adventurer symbol
        /// </summary>
        public string Symbol
        {
            get { return ADVENTURER; }
        }

        /// <summary>
        /// Overrides toString method to return the position of the adventurer
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + " at " + X.ToString() + "," + Y.ToString();
        }

        /// <summary>
        /// Returns the experience of each of the treaures and quantities carried in the carrying list
        /// </summary>
        public int Experience
        {
            get
            {
                //Set xp count to 0 start point
                int xp = 0;
                //loop through all treasure quantities in carrying list
                foreach(TreasureQuantity item in Carrying)
                {
                    //add to the xp count the experience of each item in the list
                    xp += item._Experience;
                }
                //return the value of xp
                return xp;
            }
        }
        /// <summary>
        /// Adds treasure to carrying list and output to console window
        /// </summary>
        /// <param name="item"></param>
        public void AddTreasure(TreasureQuantity item)
        {
            //add item to carrying list
            Carrying.Add(item);
            //output to console window
            Console.WriteLine(item.ToString());
        }
        /// <summary>
        /// Method combines all the treaure in carrying so that their are quantites of each type of treasure
        /// </summary>
        public void CombineTreasure()
        {
            //counters for each type of treasure 
            int gold = 0;
            int silver = 0;
            int copper = 0;
            int deathStarPlans = 0;


            //go through and combine items of same type, i.e. coins
            foreach(TreasureQuantity item in Carrying)
            {
                //checks  if the experience of the item is 1
                if (item._Treasure.Experience == 1)
                    //add the quantity of coppers in the carrying list to the copper counter
                    copper += item._Quantity;
                //checks if the experience of the item is 5
                else if (item._Treasure.Experience == 5)
                    //add the quantity of silver to the silver counter
                    silver += item._Quantity; 
                //checks if the experience of the item is 10, therefore gold
                else if (item._Treasure.Experience == 10)
                    //add the quantity of golf to the gold counter
                    gold += item._Quantity;
                //Checks if the experience of the item is 1000, therefore the deathstar plans
                else if (item._Treasure.Experience == 1000) 
                    //add the quantity of death star plans to the death star plans counter
                    deathStarPlans += item._Quantity;
            }
            //clears the carrying list of any values before updating to add the compined amounts
            Carrying.Clear();

            //Creates new treasure variables that can be assigned a quantity in next step
            Treasure goldTreasure = new Treasure("$", CoinType.Gold.ToString(), (int)CoinType.Gold);
            Treasure silverTreasure = new Treasure("$", CoinType.Silver.ToString(), (int)CoinType.Silver);
            Treasure copperTreasure = new Treasure("$", CoinType.Copper.ToString(), (int)CoinType.Copper);
            Treasure dstTreasure = new Treasure("!", "Death Star plans", 1000);

            //creates new treasure quantity variables passing in the previously created treasure variables and the counter of the various quantities of the treasure
            TreasureQuantity goldCombined = new TreasureQuantity(goldTreasure, gold);
            TreasureQuantity silverCombined = new TreasureQuantity(silverTreasure, silver);
            TreasureQuantity copperCombined = new TreasureQuantity(copperTreasure, copper);
            TreasureQuantity dstCombined = new TreasureQuantity(dstTreasure, deathStarPlans);

            //adds the newly combinded quantities to the carrying list
            Carrying.Add(copperCombined);
            Carrying.Add(silverCombined);
            Carrying.Add(goldCombined);
            Carrying.Add(dstCombined);

        }
    }
}
