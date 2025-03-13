using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Bio_Fuel_Pump_Simulator
{
    public partial class Form1 : Form
    {
        //Constants
        const decimal FUEL_PRICE = 2.0m;
        const int MAX_FUEL = 200;

        private double fuelRemaining = MAX_FUEL;

        

        private void clear()
        {
            textBoxFillAmount.Clear();
            textBoxFillAmount.Focus();
        }

        private bool checkFuelCost(double fuelCost)
        {
            if (fuelCost > 0 && fuelCost % 10 == 0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        private double CalcLitresDispensed(double fuelcost)
        {
            double fuelDispensed = 0;
            fuelDispensed = fuelcost / (double)FUEL_PRICE;
            return fuelDispensed;

        }

        public Form1()
        {
            InitializeComponent();
            textBoxFillAmount.Focus();

        }

        private void buttonFillVehicle_Click(object sender, EventArgs e)
        {
            
            try
            {
                double fuelCost = int.Parse(textBoxFillAmount.Text);

                if (checkFuelCost(fuelCost))
                {
                    double litresDispensed = CalcLitresDispensed(fuelCost);

                    if (litresDispensed <= fuelRemaining)
                    {
                        fuelRemaining -= litresDispensed;
                        MessageBox.Show($"Dispensed {litresDispensed} litres of Bio Fuel.", "Fuel Dispensed");
                        textBoxRemainingFuel.Text = fuelRemaining.ToString();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Not enough fuel in the pump.", "Error");
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount of fuel(Multiple of 10).", "Error");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxFillAmount.Clear();
                textBoxFillAmount.Focus();
            }


        }

        private void buttonFillPump_Click(object sender, EventArgs e)
        {
            fuelRemaining = MAX_FUEL;
            textBoxRemainingFuel.Text = fuelRemaining.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
