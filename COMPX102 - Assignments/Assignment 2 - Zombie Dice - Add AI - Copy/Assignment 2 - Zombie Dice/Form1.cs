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
        #region fields
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        private bool vsComputer;
        private List<Die> dice;
        #endregion

        public delegate void CallBack();

        public delegate void colorCallBack(string turn, Label currentPlayerLable, Label otherPlayerLabel, bool buttonsOn = true);

        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// this method initialises the game including players and dice
        /// </summary>
        private void InitializeGame()
        {
            //initialising the players
            player1 = new Player();
            player2 = new Player();
            //set the current player to player 1
            currentPlayer = player1;

            // Initialize a cup of 13 dice (4 green, 4 yellow, 5 red)
            dice = new List<Die>();
            for (int i = 0; i < 4; i++) // 4 of each colour
            {
                dice.Add(new Die(Die.DieColor.Green));
                dice.Add(new Die(Die.DieColor.Yellow));
                dice.Add(new Die(Die.DieColor.Red));
            }
            dice.Add(new Die(Die.DieColor.Red));//+1 red dice


            UpdateUI();
        }

        
        /// <summary>
        /// This method updates the player scores
        /// </summary>
        private void updateScores()
        {
            // Update player 1 stats
            labelPlayer1Brains.Text = $"Brains: {player1.BrainsCollected}";
            labelPlayer1Shotguns.Text = $"Shotguns: {player1.ShotgunsCollected}";
            // Update player 2 stats
            labelPlayer2Brains.Text = $"Brains: {player2.BrainsCollected}";
            labelPlayer2Shotguns.Text = $"Shotguns: {player2.ShotgunsCollected}";
        }
        /// <summary>
        /// This method changes the colours of the labels when it is different players turns
        /// </summary>
        /// <param name="turn"></param>
        /// <param name="currentPlayerLable"></param>
        /// <param name="otherPlayerLabel"></param>
        /// <param name="buttonsOn"></param>
        public void changeColor(string turn, Label currentPlayerLable, Label otherPlayerLabel, bool buttonsOn = true)
        {
            //Current labels and player will be green, other will be black
            labelCurrentTurn.Text = turn;
            labelCurrentTurn.ForeColor = Color.Lime;

            currentPlayerLable.ForeColor = Color.Lime;
            otherPlayerLabel.ForeColor = Color.Black;

            buttonRollDice.Enabled = buttonsOn;  // Enable roll button for Player 1
            buttonEndTurn.Enabled = buttonsOn; // Enable end turn button for Player 1
        }
        /// <summary>
        /// This method updates the UI of the game according to which players turn it is
        /// </summary>
        private void UpdateUI()
        {
            Label curretnTurn = currentPlayer == player1 ? labelPlayer1 : labelPlayer2; //check who the surrent player is, sets according label
            Label otherTurn = currentPlayer == player1 ? labelPlayer2 : labelPlayer1; //checks who the "other" non-current player is, sets according to label
            colorCallBack changeColorCallBack = changeColor;
            //if its the computer turn 
            if (vsComputer && currentPlayer == player2)
            {
                changeColorCallBack("Computer's Turn!", curretnTurn, otherTurn, false);
            }
            //handles either players turn who is not computer
            else
            {
                string messageCallback = $"Player {(currentPlayer == player1 ? '1' : '2')}'s Turn! Roll On!";
                changeColorCallBack(messageCallback, curretnTurn, otherTurn);
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

        /// <summary>
        /// Method rolls the dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRollDice_Click(object sender, EventArgs e)
        {
            //Check ifthere is a current player
            if (currentPlayer == null)
            {
                MessageBox.Show("Please select a game mode before rolling the dice.");
                return;
            }

            // Play the turn and collect results
            var (brainsRolled, shotgunsRolled) = currentPlayer.play(listBoxRollResults, dice, updateScores);

            // Call updateScores directly instead of a delegate, if not needed.
            updateScores(); // This will update the scores in the UI

            if (currentPlayer.IsTurnOver)
            {
                MessageBox.Show("You collected 3 shotguns, your turn is over.");
                currentPlayer.EndTurn();
                SwitchTurn();

                if (vsComputer && currentPlayer == player2)
                {
                    computerTurn();
                }
            }

            UpdateUI();

        }

        /// <summary>
        /// Switches the turn to the player who is not the curernt player
        /// </summary>
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
            updateScores();
            UpdateUI();
        }
        /// <summary>
        /// Sets the game mode to player vs player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerVsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vsComputer = false;
            InitializeGame();
            MessageBox.Show("Player vs Player mode selected.");
            labelPlayer2.Text = "Player 2";

        }
        /// <summary>
        /// Sets the game mode to player vs computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerVsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vsComputer = true;
            InitializeGame();
            MessageBox.Show("Player vs Computer mode selected.");
            labelPlayer2.Text = "Computer";
        }
        /// <summary>
        /// End the turn of the current player if the player is not the computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEndTurn_Click(object sender, EventArgs e)
        {
            if (player1 == null|| player2 == null) { return; }
            
            UpdateUI();
            SwitchTurn();
            if (vsComputer) { computerTurn(); }
        }
        /// <summary>
        /// Method handles the computers turn
        /// </summary>
        private void computerTurn()
        {
            List <string> computerScores = new List<string> ();

            int i = 0;
            do
            {
                CallBack callBack = updateScores;
                // Play a turn for the computer player and get the number of brains and shotguns rolled this turn
                var (brainsRolled, shotgunsRolled) = player2.play(listBoxRollResults, dice, callBack);

                // Update the UI after the computer's roll
                UpdateUI();

                // Store the results in the computerScores array
                computerScores.Add ($"Brains: {brainsRolled}, Shotguns: {shotgunsRolled}, Footprints: {player2.diceWithFootprints.Count}");

                
                i++;
            } //computer plays until it thinks it should stop
            while (computerTurnLogic());
            string message = "";
            i = 0;
            //lists the roll outputs to a message
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
        /// <summary>
        /// The AI for the computer
        /// </summary>
        /// <returns>true if computer should stop, false otherwise</returns>
        private bool computerTurnLogic()
        {
            int shotguns = player2.ShotgunsCollected;
            int brains = player2.BrainsCollected;
            if (brains >= 13)
                return false;
            else if (shotguns == 2)
                return false;
            else if (shotguns < 3)
                return true;
            else if (player2.IsTurnOver)
                return false; 
            else
                return false;
        }
    }
}