using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rogue_One
{
    /// <summary>
    /// is the form of the program 
    /// </summary>
    public partial class Dungeon : Form
    {
        const int SIZE = 20;
        
        Random rand = new Random(); //seed random number generator
        Square[,] dungeon;
        Adventurer player;

        //list to store all found treasure 
        List<Treasure> treasures = new List<Treasure>();

        public Dungeon()
        {
            InitializeComponent();
            //display backstory
            textBoxDisplay.Text = "You are a troubled young tearaway called Jyn Erso who is recruited as part of the team" + 
            " tasked with retrieving the Imperial Death Star plans." + Environment.NewLine +
            "Use hjkl to move as in classic rogue";
            textBoxDisplay.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create an adventurer 
            player = new Adventurer("Jyn", 5, 5);
            listBoxContents.DataSource = player.Carrying;
            //create a map
            CreateDungeon();
            //display map
            DisplayDungeon();
        }

        private void CreateDungeon()
        {
            dungeon = new Square[SIZE, SIZE]; //create 2d array to hold dungeon
            //build floor
            for (int x = 0; x < SIZE; x++)
                for (int y = 0; y < SIZE; y++)
                    dungeon[x, y] = new Square(Square.TerrainTypes.Floor);
            //add walls
            for (int i = 0; i < 100; i++)
                if (rand.Next(5)==0) //4/5ths walls
                dungeon[rand.Next(SIZE), rand.Next(SIZE)] = new Square(Square.TerrainTypes.Water);
            else
                    dungeon[rand.Next(SIZE), rand.Next(SIZE)] = new Square(Square.TerrainTypes.Wall);
            //add treasure
            for (int i = 0; i < 50; i++)
                if (rand.Next(3) == 0)
                { //1/3rd gold
                    //create a new treasure variable
                    Treasure gold = new Treasure("$", CoinType.Gold.ToString(), (int)CoinType.Gold);
                    //Use the treasure just created to pass into a new treasurequantity variable that is a random quantity between 1 and 3
                    TreasureQuantity goldQuantity = new TreasureQuantity(gold, rand.Next(1,3));
                    dungeon[rand.Next(SIZE), rand.Next(SIZE)].Item = goldQuantity;
                    //add the new gold treasure found to the treasure list
                    treasures.Add(gold);
                }
                else if (rand.Next(3) == 1)
                {//1/3rd silver
                    //create new silver treasure variable 
                    Treasure silver = new Treasure("$", CoinType.Silver.ToString(), (int)CoinType.Silver);
                    //Use the treasure just created to pass into a new treasurequantity variable that is a random quantity between 1 and 3
                    TreasureQuantity silverQuantity = new TreasureQuantity(silver, rand.Next(1,3));
                    dungeon[rand.Next(SIZE), rand.Next(SIZE)].Item = silverQuantity;
                    //add new silver to treasure list
                    treasures.Add(silver);
                }
                else
                {
                    //create new copper treasure variable
                    Treasure copper = new Treasure("$", CoinType.Copper.ToString(), (int)CoinType.Copper);
                    //Use the treasure just created to pass into a new treasurequantity variable that is a random quantity between 1 and 3
                    TreasureQuantity copperQuantity = new TreasureQuantity(copper,rand.Next(1,3));
                    dungeon[rand.Next(SIZE), rand.Next(SIZE)].Item = copperQuantity;
                    //add new copper treasure to treasures list
                    treasures.Add(copper);

                }
            //do the same as above for the death star pland but set the maximum quantity to 1
            Treasure deathStarPlans = new Treasure("!", "Death Star plans", 1000);
            TreasureQuantity dstPlansQuantity = new TreasureQuantity(deathStarPlans, 1);
            dungeon[rand.Next(SIZE), rand.Next(SIZE)].Item =  dstPlansQuantity; 
            //add player
            dungeon[player.X, player.Y] = new Square(Square.TerrainTypes.Floor); ; //so player doesn't start in a wall
            WhatIsHere(player.X, player.Y); //know what is where the player is
        }

        private void DisplayDungeon()
        {
            int i = 0;
            string s = "";
             for (int y = 0; y < SIZE; y++)
                {
                for (int x = 0; x < SIZE; x++)
            {
              
                    if (x == player.X && y == player.Y)
                        s += player.Symbol; //symbol for the player
                    else
                        s += dungeon[x, y].Symbol;
                }

                s += Environment.NewLine;
                //   textBoxDisplay.Lines[i] = s ;
                i++;
            }
            textBoxDisplay.Text = s ;
            textBoxXP.Text = player.Experience.ToString();
        }

        private Square WhatIsHere(int x, int y)
        {
            dungeon[x, y].Known = true; //know what is here
            textBoxMessage.Text = dungeon[x, y].ToString(); //display stuff in listbox
            return dungeon[x, y];
        }
        private void PickUpTreasure(Square where)
        {
            if (where.Item != null)
            {
                //something here
                MessageBox.Show("You gain " + where.Item._Quantity + ": " + where.Item._Treasure.ToString());

                player.AddTreasure(where.Item); //grab item from square
                where.Item = null; //remove item from square
            }
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Square target;
            int newX = player.X;
            int newY = player.Y;
            try
            {
                //use hjkl as in classic rogue
                if (e.KeyChar == 'h')
                {
                    //go left
                    newX--;
                }
                else if (e.KeyChar == 'j')
                {
                    //go up
                    newY--;
                }
                else if (e.KeyChar == 'k')
                {
                    //go down
                    newY++;
   }
                else if (e.KeyChar == 'l')
                {
                    //go right
                    newX++;
                }
                target = WhatIsHere(newX, newY);
                if (target.Terrain == Square.TerrainTypes.Floor)
                {
                    player.X = newX;
                    player.Y = newY;
                }
                PickUpTreasure(target); //yay
              
            }
            catch
            {
                MessageBox.Show("You can't walk that way");
            }
            DisplayDungeon();
        }

        private void buttonRepack_Click(object sender, EventArgs e)
        {
            //repack items the adventurer is carrying by combining identical treasures
            player.CombineTreasure();
        }
    }
}
