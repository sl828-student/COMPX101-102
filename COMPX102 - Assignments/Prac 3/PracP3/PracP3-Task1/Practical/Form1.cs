using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        //#############################################################################################
        //# Instance variables
        /// <summary>
        /// Random number generator, used to generate cards.
        /// </summary>
        private Random randomGenerator = new Random();

        // Instance variables
        private List<Card> playerCards = new List<Card>();
        private List<Card> dealerCards = new List<Card>();

        //private Card playerCard1;
        //private Card playerCard2;

        //private Card dealerCard1;
        //private Card dealerCard2;

        //#############################################################################################
        //# Constants
        /// <summary>
        /// Total number of cards
        /// </summary>
        private const int NUM_CARDS = 52;
        /// <summary>
        /// Maximum points allowed before going bust
        /// </summary>
        private const int BLACKJACK = 21;
        /// <summary>
        /// Initial amount of money available to the player (to implement betting).
        /// </summary>
        private const int START_MONEY = 100;

        //#############################################################################################
        //# Constructor
        public Form1()
        {
            InitializeComponent();
            // Prevent the user from resising the form
            MinimumSize = MaximumSize = Size;

            textBoxMoneyLeft_.Text= START_MONEY.ToString();
        }

        //#############################################################################################
        //# Event Handlers
        /**private void buttonDealFirstCard__Click(object sender, EventArgs e)
        {
            // Generate 4 new random cards
            playerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            playerCard2 = new Card(randomGenerator.Next(NUM_CARDS));
            dealerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            dealerCard2 = new Card(randomGenerator.Next(NUM_CARDS));

            // Display the first card to player and dealer
            textBoxPlayerCard1_.Text = playerCard1.ToString();
            textBoxDealerCard1_.Text = dealerCard1.ToString();

            // Clear the second card and totals
            textBoxPlayerCard2_.Text = "";
            textBoxPlayerTotal_.Text = "";
            textBoxDealerCard2_.Text = "";
            textBoxDealerTotal_.Text = "";
        }
        

        private void buttonDealSecondCard__Click(object sender, EventArgs e)
        {
            //display second two cards and total
            textBoxPlayerCard2_.Text = playerCard2.ToString();
            textBoxDealerCard2_.Text = dealerCard2.ToString();

            int playerTotal = playerCard1.Points + playerCard2.Points;
            int dealerTotal = dealerCard1.Points + dealerCard2.Points;

            textBoxPlayerTotal_.Text = playerTotal.ToString();
            textBoxDealerTotal_.Text = dealerTotal.ToString();

            if (playerTotal > BLACKJACK)
            { // Player bust: loses even if dealer bust.
                LoseGame();
            }
            else if (dealerTotal > BLACKJACK || playerTotal > dealerTotal)
            {
                MessageBox.Show("You win!");
            }
            else if (playerTotal == dealerTotal)
            {
                MessageBox.Show("You tie!");
            }
            else
            { // Player total less than dealer, and dealer did not bust.
                LoseGame();
            }
        }
        **/

        /// <summary>
        /// This method will end the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //#############################################################################################
        //# Private Methods
        private void LoseGame()
        {
            MessageBox.Show("You lose!");
            
        }

        private void WinGame()
        {
            MessageBox.Show("You win!");
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            // Deal a new card to the player
            Card newCard = new Card(randomGenerator.Next(NUM_CARDS));
            playerCards.Add(newCard);

            // Deal a new card to the dealer
            Card newDealerCard = new Card(randomGenerator.Next(NUM_CARDS));
            dealerCards.Add(newDealerCard);

            // Update the player ListBox
            listBoxPlayer.Items.Clear();
            foreach (Card card in playerCards)
            {
                listBoxPlayer.Items.Add(card.ToString());
            }

            //Update the dealer ListBox
            listBoxDealer.Items.Clear();
            foreach (Card card in dealerCards)
            {
                listBoxDealer.Items.Add(card.ToString());
            }

            // Calculate the points for player
            int playerPoints = playerCards.Sum(card => card.Points);
            textBoxPlayerTotal_.Text = playerPoints.ToString();

            //Calculate the points for the dealer
            int dealerPoints = dealerCards.Sum(card => card.Points);
            textBoxDealerTotal_.Text = dealerPoints.ToString();

            // Check for bust
            if (playerPoints > BLACKJACK)
            {
                LoseGame();
                clearMethod();
                playerCards.Clear();
                dealerCards.Clear();
                dealerPoints = 0;
            }
            else if (dealerPoints > BLACKJACK)
            {
                WinGame();
                clearMethod();
                playerCards.Clear();
                dealerCards.Clear();
                dealerPoints = 0;
            }
            else if (playerPoints == BLACKJACK)
            {
                WinGame();
                clearMethod();
                playerCards.Clear();
                dealerCards.Clear();
                dealerPoints = 0;
            }
         
        }

        private void clearMethod()
        {
            listBoxPlayer.Items.Clear();
            listBoxDealer.Items.Clear();
            textBoxPlayerTotal_.Clear();
            textBoxDealerTotal_.Clear();
        }
            // Quit button event handler
            private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            clearMethod();
        }
    }
        /**private void labelDealerCard1__Click(object sender, EventArgs e)
        {

        }
        **/
}


