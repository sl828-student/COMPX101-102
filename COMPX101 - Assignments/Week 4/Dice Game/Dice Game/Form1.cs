using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game
{
    public partial class Form1 : Form
    {
        Random dice = new Random();
        int playerBalance = 100;
        int betAmount = 0;
        

        public Form1()
        {
            InitializeComponent();
            textBoxBetAmount.Text = betAmount.ToString();
            textBoxBalance.Text = playerBalance.ToString();

        }
        


        private void labelDiceOne_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            
            try
            {
                {
                    int playerDice1 = dice.Next(1, 7);
                    int playerDice2 = dice.Next(1, 7);
                    int computerDice1 = dice.Next(1, 7);
                    int computerDice2 = dice.Next(1, 7);

                    int betAmount = Convert.ToInt32(textBoxBetAmount.Text);

                    textBoxPlayerDiceOne.Text = playerDice1.ToString();
                    textBoxPlayerDiceTwo.Text = playerDice2.ToString();
                    textBoxComputerDiceOne.Text = computerDice1.ToString();
                    textBoxComputerDiceTwo.Text = computerDice2.ToString();

                    if (betAmount <= 0)
                    {
                        MessageBox.Show("Invalid bet amount. Please enter a positive number.");
                        return;
                    }
                    if (betAmount > playerBalance)
                    {
                        MessageBox.Show("Insufficient balance to make this bet.");
                        return;
                    }

                    int playerTotal = playerDice1 + playerDice2;
                    int computerTotal = computerDice1 + computerDice2;
                    if (playerTotal > computerTotal)
                    {
                        MessageBox.Show("You win!");
                        playerBalance += betAmount;

                    }
                    else if (playerTotal == computerTotal)
                    {
                        MessageBox.Show("It's a draw!");

                    }
                    else
                    {
                        MessageBox.Show("You lose!");
                        playerBalance -= betAmount;

                    }
                    textBoxBalance.Text = playerBalance.ToString();
                    textBoxBetAmount.Clear();
                    textBoxBetAmount.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
            
        }
    }
}
