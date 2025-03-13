using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTest1
{
    public partial class Form1 : Form
    {
        //Name: Shokei Leger-Yoshihara 1656804

        //cost of making 1 litre of beer is $10.50
        const decimal BEER_COST = 10.5m;
        //Amount of beer required for 1 can (in litres)
        const double CAN_AMOUNT = 0.25;
        //Amount of beer required for 1 bottle (in litres)
        const double BOTTLE_AMOUNT = 0.4;

        //The volume of a keg of beer (in litres) for Bonus Task
        const int KEG_VOLUME = 50;
        //The cost of a keg of beer for Bonus Task
        const decimal KEG_COST = 150m;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clears all textboxes when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAmountBottles.Clear();
            textBoxAmountCans.Clear();
            textBoxNumBottlesOrdered.Clear();
            textBoxNumCansOrdered.Clear();
            textBoxTotalBeer.Clear();
            textBoxTotalCost.Clear();
            textBoxNumberKegs.Clear();
            textBoxKegsCost.Clear();
        }
        /// <summary>
        /// exits application when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Calculates beer amounts and cost then outputs to textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int numberCansOrdered = 0;
            int numberBottlesOrdered = 0;
            double amountForCans = 0;
            double amountForBottles = 0;
            double totalBeer = 0;
            decimal totalCost = 0;
            
            double numberKegs = 0;
            decimal costKegs = 0;

            try
            {
                //Gets the number of cans ordered from user input
                numberCansOrdered = int.Parse(textBoxNumCansOrdered.Text);
                //Gets the number of bottles ordered from user input
                numberBottlesOrdered = int.Parse(textBoxNumBottlesOrdered.Text);

                //Calculates the amount of beer needed to fill cans
                amountForCans = numberCansOrdered * CAN_AMOUNT;
                //Calculates the amount of beer needed to fill bottles
                amountForBottles = numberBottlesOrdered * BOTTLE_AMOUNT;
                //Calculates the total amount of beer
                totalBeer = amountForCans + amountForBottles;
                //calcualtes the total cost of beer
                totalCost = (decimal)totalBeer * BEER_COST;

                //Displays the amount for cans
                textBoxAmountCans.Text = amountForCans.ToString("n2");
                //Displays the amount for bottles
                textBoxAmountBottles.Text = amountForBottles.ToString("n2");
                //Displays the total amount of beer required
                textBoxTotalBeer.Text = totalBeer.ToString("n2");
                //Displaus the total cost of beer
                textBoxTotalCost.Text = totalCost.ToString("c");

                //Calculates the number of kegs required
                numberKegs = Math.Ceiling(totalBeer / 50) * 50 / KEG_VOLUME;
                //calculates the cost of kegs
                costKegs = (decimal)numberKegs * KEG_COST;

                //Displays the number of kegs required
                textBoxNumberKegs.Text = numberKegs.ToString("n2");
                //Displays the cost of kegs
                textBoxKegsCost.Text = costKegs.ToString("c");
            }
            catch (Exception ex) 
            { 
                //Displays error message
                MessageBox.Show(ex.Message);
                //Clears all textboxes
                textBoxAmountBottles.Clear();
                textBoxAmountCans.Clear();
                textBoxNumBottlesOrdered.Clear();
                textBoxNumCansOrdered.Clear();
                textBoxTotalBeer.Clear();
                textBoxTotalCost.Clear();
                textBoxKegsCost.Clear();
                textBoxNumberKegs.Clear();
                //sets the focus 
                textBoxAmountBottles.Focus();
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
