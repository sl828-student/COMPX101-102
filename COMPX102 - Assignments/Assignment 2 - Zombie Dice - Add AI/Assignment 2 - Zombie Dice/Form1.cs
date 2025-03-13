using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_2___Zombie_Dice
{

    public partial class Form1 : Form
    {
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        private bool vsComputer;
        private List<Die> dice;

        public Form1()
        {
            InitializeComponent();

        }

        private void InitializeGame()
        {
            player1 = new Player();
            player2 = new Player();
            currentPlayer = player1;

            // Initialize a cup of 13 dice (4 green, 4 yellow, 5 red)
            dice = new List<Die>();
            for (int i = 0; i < 4; i++) // 4 green
            {
                dice.Add(new Die(Die.DieColor.Green));
            }
            for (int i = 0; i < 4; i++) // 4 yellow
            {
                dice.Add(new Die(Die.DieColor.Yellow));
            }
            for (int i = 0; i < 5; i++) // 5 red
            {
                dice.Add(new Die(Die.DieColor.Red));
            }

            UpdateUI();
        }

        private void UpdateUI()
        {

            // Update UI elements like player stats
            labelPlayer1Brains.Text = $"Brains: {player1.BrainsCollected}";
            labelPlayer1Shotguns.Text = $"Shotguns: {player1.ShotgunsCollected}";


            labelPlayer2Brains.Text = $"Brains: {player2.BrainsCollected}";
            labelPlayer2Shotguns.Text = $"Shotguns: {player2.ShotgunsCollected}";


            if (currentPlayer == player1)
            {
                labelCurrentTurn.Text = "Player 1's Turn! Roll On!";
                labelCurrentTurn.ForeColor = Color.Lime;
                labelPlayer1.ForeColor = Color.Lime;
                labelPlayer2.ForeColor = Color.Black;
                buttonRollDice.Enabled = true;  // Enable roll button for Player 1
                buttonEndTurn.Enabled = true;
            }
            else if (vsComputer && currentPlayer == player2)
            {
                labelCurrentTurn.Text = "Computer's Turn!";
                labelCurrentTurn.ForeColor = Color.Lime;
                labelPlayer2.ForeColor = Color.Lime;
                labelPlayer1.ForeColor = Color.Black;
                buttonRollDice.Enabled = false;  // Disable button for computer
                buttonEndTurn.Enabled = false;

            }
            else
            {
                labelCurrentTurn.Text = "Player 2's Turn! Roll On!";
                labelCurrentTurn.ForeColor = Color.Lime;
                labelPlayer2.ForeColor = Color.Lime;
                labelPlayer1.ForeColor = Color.Black;
                buttonRollDice.Enabled = true;  // Enable roll button for Player 2
                buttonEndTurn.Enabled = true;
            }

            // Check for a winner
            if (currentPlayer.BrainsCollected >= 13)
            {
                string message = $"{(currentPlayer == player1 ? "Player 1" : vsComputer ? "Computer" : "Player 2")} wins with 13 brains!";
                InitializeGame();  // Reset the game
                Form win = new WinBox(message);
                win.Show();


                return;
            }

            
        }

        private void buttonRollDice_Click(object sender, EventArgs e)
        {
            if (currentPlayer == null)
            {
                MessageBox.Show("Please select a game mode before rolling the dice.");
                return;
            }

            // Play the turn and collect results
            var (brainsRolled, shotgunsRolled) = currentPlayer.play(listBoxRollResults, dice);

            // Check if the current player has rolled 3 shotguns and end the turn
            if (currentPlayer.IsTurnOver)
            {
                MessageBox.Show("You collected 3 shotguns, your turn is over.");
                currentPlayer.EndTurn(); // End the current player's turn
                SwitchTurn(); // Switch to the next player

                // If playing against the computer, start the computer's turn automatically
                if (vsComputer && currentPlayer == player2)
                {
                    computerTurn(); // Start the computer's turn
                }
            }

            UpdateUI();

        }


        private void SwitchTurn()
        {
            // Before switching, check the current player's status
            if (currentPlayer.IsTurnOver)
            {
                currentPlayer.ResetTurn(); // Reset the shotguns of the current player
            }

            // Switch the current player
            currentPlayer = currentPlayer == player1 ? player2 : player1;
            

            currentPlayer.StartTurn(); // Start the new player's turn
            UpdateUI();
        }

        private void playerVsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vsComputer = false;
            InitializeGame();
            MessageBox.Show("Player vs Player mode selected.");
            labelPlayer2.Text = "Player 2";

        }

        private void playerVsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vsComputer = true;
            InitializeGame();
            MessageBox.Show("Player vs Computer mode selected.");
            labelPlayer2.Text = "Computer";
            

        }

        private void buttonEndTurn_Click(object sender, EventArgs e)
        {
            if (player1 == null|| player2 == null) { return; }
            
            UpdateUI();
            SwitchTurn();
            if (vsComputer) { computerTurn(); }
        }

        private void computerTurn()
        {
            List <string> computerScores = new List<string> ();

            int i = 0;
            do
            {
                // Play a turn for the computer player and get the number of brains and shotguns rolled this turn
                var (brainsRolled, shotgunsRolled) = player2.play(listBoxRollResults, dice);

                // Update the UI after the computer's roll
                UpdateUI();

                // Store the results in the computerScores array
                computerScores.Add ($"Brains: {brainsRolled}, Shotguns: {shotgunsRolled}, Footprints: {player2.diceWithFootprints.Count}");

                
                i++;
            } while (computerTurnLogic());
            string message = "";
            i = 0;
            foreach (var item in computerScores)
            {
                message += $"Roll {i + 1}:\n{computerScores.ElementAt(i)}\n";
                i++;
            }

            Console.WriteLine("-----");
            // Show the scores in a message box
            MessageBox.Show($"THE COMPUTER ROLLED:\n\n" + message);

            player2.EndTurn(); // End the computer's turn
            SwitchTurn(); // Switch to the player's turn

        }

        private bool computerTurnLogic()
        {
            int shotguns = player2.ShotgunsCollected;
            int brains = player2.BrainsCollected;
            if (brains >= 13)
                return false;
            else if (shotguns == 2)
                return false;
            else if (shotguns < 3)
            {
                return true;
            }
            else if (player2.IsTurnOver)
            { return false; }
            else
                return false;
        }
    }
}