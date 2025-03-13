using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision_session_2
{
    public partial class Form1 : Form
    {
        //Constant for spill rate of beans
        const double SPILL_RATE = 0.05;
        //Constant for cost per litre of beans
        const decimal COST_PER_LITRE = 3.5m;


        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This will exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This will clear the textboxes and set the focus 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears all Textboxes
            textBoxBags.Text = "";
            textBoxBeanAmount.Text = "";
            textBoxExtraSpilled.Clear();
            textBoxSize.Clear();
            textBoxTotalAmount.Text = string.Empty;
            textBoxTotalCost.Clear();

            //focus set on textBoxBeans
            textBoxBags.Focus();
        }
        /// <summary>
        /// This will calculate and output values based on the user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
            int numBags = 0;
            double sizeBags = 0;
            double amountBeans = 0;
            double spilledBeans = 0;
            double totalAmount = 0;
            decimal totalCost = 0;

            try
            {
                //Gets the user inputs number of bags
                numBags = int.Parse(textBoxBags.Text);
                //Gets the user inputs for size of bags
                sizeBags = double.Parse(textBoxSize.Text);

                //Calculates the amount of beans needed
                amountBeans = numBags * sizeBags;

                //Calcualtes the amount of beans spilled
                spilledBeans = amountBeans * SPILL_RATE;

                //Calcualtes the Total Amount of beans required
                totalAmount = amountBeans + spilledBeans;

                //Calcualtes the toatl cost 
                totalCost = (decimal)totalAmount * COST_PER_LITRE;

                //Displays the amount of beans needed
                textBoxBeanAmount.Text = amountBeans.ToString("n3");

                //Displays the spilled amount of beans 
                textBoxExtraSpilled.Text = spilledBeans.ToString("n3");

                //Displays the total amount of beans 
                textBoxTotalAmount.Text = totalAmount.ToString("n3");

                //Displays the total cost of beans 
                textBoxTotalCost.Text = totalCost.ToString("c");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
