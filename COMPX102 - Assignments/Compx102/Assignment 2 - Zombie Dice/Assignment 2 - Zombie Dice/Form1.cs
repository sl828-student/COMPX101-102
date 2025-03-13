using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2___Zombie_Dice
{
    public partial class Form1 : Form
    {
        private int brains = 0;
        private int shotguns = 0;

        private List<Die> cup = new List<Die>();
        private List<Die> currentDice = new List<Die>(); // Dice rolled in the current turn
        private List<Die> footprintsDice = new List<Die>(); // Dice rolled as footprints

        public Form1()
        {
            InitializeComponent();
            InitializeCup();
        }

        private void buttonRollDice_Click(object sender, EventArgs e)
        {
            PickThreeDice();
            footprintsDice.Clear(); // Clear previous footprints

            // Roll the dice and update the counts
            foreach (Die die in currentDice)
            {
                Die.DieResult result = die.Roll();
                switch (result)
                {
                    case Die.DieResult.Brain:
                        brains++;
                        break;
                    case Die.DieResult.Shotgun:
                        shotguns++;
                        break;
                    case Die.DieResult.Footprints:
                        footprintsDice.Add(die); // Add to footprints dice
                        break;
                }
            }

            // Update UI elements
            UpdateScoreDisplay();

            // Check for footprints and show re-roll button
            if (footprintsDice.Count > 0)
            {
                labelFootprints.Text = "Footprints - Re-roll?";
                buttonReRoll.Visible = true; // Show re-roll button
            }
            else
            {
                labelFootprints.Text = string.Empty; // Clear the label if no footprints were rolled
                buttonReRoll.Visible = false; // Hide re-roll button
            }

            // Check for shotguns
            if (shotguns >= 3)
            {
                EndTurn();
            }
        }

        private void buttonReRoll_Click(object sender, EventArgs e)
        {
            ReRollFootprints();
        }

        private void EndTurn()
        {
            MessageBox.Show("You got 3 shotguns! Turn over.");
            brains = 0;
            shotguns = 0;
            UpdateScoreDisplay();
            labelFootprints.Text = string.Empty; // Clear footprints label
            buttonReRoll.Visible = false; // Hide re-roll button
        }

        private void ReRollFootprints()
        {
            // Roll the footprint dice again
            List<Die> newFootprints = new List<Die>();

            foreach (Die die in footprintsDice)
            {
                Die.DieResult result = die.Roll();
                switch (result)
                {
                    case Die.DieResult.Brain:
                        brains++;
                        break;
                    case Die.DieResult.Shotgun:
                        shotguns++;
                        break;
                    case Die.DieResult.Footprints:
                        newFootprints.Add(die); // Keep track of any new footprints
                        break;
                }
            }

            // Update footprints list
            footprintsDice = newFootprints; // Keep only new footprints
            UpdateScoreDisplay();
            labelFootprints.Text = footprintsDice.Count > 0 ? "Footprints - Re-roll?" : string.Empty; // Update label
            buttonReRoll.Visible = footprintsDice.Count > 0; // Show/hide button based on footprints

            // Check for shotguns
            if (shotguns >= 3)
            {
                EndTurn();
            }
        }

        private void UpdateScoreDisplay()
        {
            labelBrains.Text = $"Brains: {brains}";
            labelShotgun.Text = $"Shotguns: {shotguns}";
        }

        private void InitializeCup()
        {
            // Add 6 Green dice, 4 Yellow dice, 3 Red dice to the cup
            cup.Clear(); // Clear the cup for fresh start
            for (int i = 0; i < 6; i++) cup.Add(new Die(Die.DieColor.Green));
            for (int i = 0; i < 4; i++) cup.Add(new Die(Die.DieColor.Yellow));
            for (int i = 0; i < 3; i++) cup.Add(new Die(Die.DieColor.Red));
        }

        private void PickThreeDice()
        {
            currentDice.Clear(); // Clear the current dice

            if (cup.Count < 3)
            {
                MessageBox.Show("Not enough dice in the cup. Resetting the cup.");
                InitializeCup(); // Re-initialize if there are not enough dice
            }

            Random rnd = new Random();
            HashSet<int> selectedIndexes = new HashSet<int>(); // To avoid duplicates

            // Randomly pick 3 unique dice from the cup
            while (selectedIndexes.Count < 3)
            {
                int randomIndex = rnd.Next(cup.Count);
                if (selectedIndexes.Add(randomIndex)) // Add returns false if already exists
                {
                    currentDice.Add(cup[randomIndex]);
                }
            }
        }
    }
}
