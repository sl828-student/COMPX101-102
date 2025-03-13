using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2___Zombie_Dice
{
    public class Player
    {
        public int BrainsCollected { get; private set; }
        public int ShotgunsCollected { get; private set; }
        public bool IsTurnOver { get; private set; }
        private int initialBrains;
        public List<Die> diceWithFootprints = new List<Die>();

        public Player()
        {
            BrainsCollected = 0;
            ShotgunsCollected = 0;
            IsTurnOver = false;
        }

        public void StartTurn()
        {
            initialBrains = BrainsCollected;
            ShotgunsCollected = 0;
            IsTurnOver = false;
        }

        public void AddResult(Die.DieResult result)
        {
            if (!IsTurnOver)
            {
                switch (result)
                {
                    case Die.DieResult.Brain:
                        BrainsCollected++;
                        break;
                    case Die.DieResult.Shotgun:
                        ShotgunsCollected++;
                        break;
                }

                // Check if the player has rolled 3 shotguns
                if (ShotgunsCollected >= 3)
                {
                    IsTurnOver = true;
                    BrainsCollected = initialBrains; // Reset to initial brains
                }
            }
        }

        public void EndTurn()
        {
            IsTurnOver = true;
        }

        public void ResetTurn()
        {
            ShotgunsCollected = 0; // Reset shotguns only when turn is reset
        }

        public (int brainsRolledThisTurn, int shotgunsRolledThisTurn) play(ListBox listBoxRollResults, List<Die> dice)
        {
            int brainsRolledThisTurn = 0; // Variable to count brains rolled this turn
            int shotgunsRolledThisTurn = 0; // Variable to count shotguns rolled this turn
            try
            {
                listBoxRollResults.Items.Clear(); // Clear previous results

                Random random = new Random();
                List<Die> selectedDice = new List<Die>();

                // Add dice that previously rolled footprints
                selectedDice.AddRange(diceWithFootprints);

                // Randomly pick the remaining dice from the cup (if fewer than 3 dice have been selected)
                int diceNeeded = 3 - selectedDice.Count;
                for (int i = 0; i < diceNeeded; i++)
                {
                    int index = random.Next(dice.Count);
                    var newDie = dice[index];

                    // Ensure the newly selected dice aren't already in the selected list
                    if (!selectedDice.Contains(newDie))
                    {
                        selectedDice.Add(newDie);
                    }
                    else
                    {
                        i--; // Retry selection if duplicate
                    }
                }

                // Clear footprints list before rolling (we'll re-add any new footprints in this roll)
                diceWithFootprints.Clear();

                // Loop through each selected die, roll it, and display its result
                foreach (var die in selectedDice)
                {
                    var result = die.Roll(); // Roll each die
                    listBoxRollResults.Items.Add($"{die.Color,-7} Die: {result}"); // Display die result

                    // If the die rolls footprints, keep it for the next roll
                    if (result == Die.DieResult.Footprints)
                    {
                        diceWithFootprints.Add(die);
                    }

                    // Update the player's brain/shotgun count based on the result
                    this.AddResult(result);

                    // Count brains and shotguns rolled this turn
                    if (result == Die.DieResult.Brain)
                    {
                        brainsRolledThisTurn++;
                    }
                    else if (result == Die.DieResult.Shotgun)
                    {
                        shotgunsRolledThisTurn++;
                    }

                    // End turn if the current player rolled 3 shotguns
                    if (this.ShotgunsCollected >= 3)
                    {
                        this.EndTurn();
                        break;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message); // Display the error message
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

            return (brainsRolledThisTurn, shotgunsRolledThisTurn); // Return the counts of brains and shotguns rolled this turn
        }

    }
}
