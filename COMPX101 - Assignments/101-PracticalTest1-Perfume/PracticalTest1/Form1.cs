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
        //Name: Shokei Leger-Yoshihara
        //ID  : 1656804

        //Amount of perfume for a small bottle in litres
        const double SMALL_BOTTLE_AMOUNT = 0.25;
        //Amount of perfume for a large bottle in litres
        const double LARGE_BOTTLE_AMOUNT = 0.4;
        //Cost of perfume per litre
        const decimal PERFUME_COST_PER_LITRE = 550.50m;
        //Amount of litres of perfume in a drum (for the bonus task)
        const int PERFUME_IN_DRUM = 100;
        //Cost of a drum of perfume (for the bonus task)
        const decimal DRUM_COST = 25000m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ///Clicking the button clears all textboxes i.e clears the form
            textBoxLarge.Clear();
            textBoxSmall.Clear();  
            textBoxLargeAmount.Clear();
            textBoxSmallAmount.Clear(); 
            textBoxTotalAmount.Clear(); 
            textBoxTotalCost.Clear();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ///Clicking the exit button will exit the application 
            Application.Exit();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            ///Declaring the Variables required
            int smallBottleNumber = 0;
            int largeBottleNumber = 0;
            double smallBottleAmount = 0;
            double largeBottleAmount = 0;
            double totalBottleAmount = 0;
            decimal totalCost = 0.0m;
            double numberDrums = 0;
            decimal totalCostDrums = 0;
            


            try
            {///Get the number of small bottles ordered
                smallBottleNumber = int.Parse(textBoxSmall.Text);

                ///get the number of large bottles ordered
                largeBottleNumber = int.Parse(textBoxLarge.Text);

                ///Calculate the amount of perfume needed to fill small bottles
                smallBottleAmount = smallBottleNumber * SMALL_BOTTLE_AMOUNT;

                ///calculate the amount of perfume needed to fill large bottles
                largeBottleAmount = largeBottleNumber * LARGE_BOTTLE_AMOUNT;

                ///calculate the total amount of perfume needed 
                totalBottleAmount = smallBottleAmount + largeBottleAmount;

                ///calculate the total cost of perfume required
                totalCost = (decimal)totalBottleAmount * PERFUME_COST_PER_LITRE;

                ///Display the amount of perfume required for small bottles
                textBoxSmallAmount.Text = (smallBottleAmount).ToString("N3");

                ///display the amount of perfume required for large bottles
                textBoxLargeAmount.Text = (largeBottleAmount).ToString("N3");

                ///display the total amount of perfume required
                textBoxTotalAmount.Text = (totalBottleAmount).ToString("N3");

                ///display the toal cost of perfume 
                textBoxTotalCost.Text = totalCost.ToString("c");

               
                ///Calculate number of drums required
                numberDrums = (Math.Ceiling(totalBottleAmount / 100)) * 100 / PERFUME_IN_DRUM;

                ///Calculate the total cost of drums
                totalCostDrums = (decimal)numberDrums * DRUM_COST;

                ///Display number of drums required
                textBoxDrums.Text = (numberDrums).ToString();

                ///display total cost of drums
                textBoxDrumsCost.Text = totalCostDrums.ToString("c");
                

            }
            catch
            {
                ///display error message
                MessageBox.Show("Incorrect Value Input.");

                ///clear all textboxes
                textBoxLarge.Clear();
                textBoxSmall.Clear();
                textBoxLargeAmount.Clear();
                textBoxSmallAmount.Clear();
                textBoxTotalAmount.Clear();
                textBoxTotalCost.Clear();

                ///set focus to first textbox
                textBoxSmall.Focus();
            }
            
        }
          





            }
    }

