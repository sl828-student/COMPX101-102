using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public class Hand
    {
        private List<Card> _cards;

        /// <summary>
        /// Constructor initializes the list of cards for the hand.
        /// </summary>
        public Hand()
        {
            _cards = new List<Card>();
        }

        /// <summary>
        /// Adds a card to the hand.
        /// </summary>
        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        /// <summary>
        /// Calculates the total points of the hand.
        /// </summary>
        public int Total
        {
            get
            {
                return _cards.Sum(card => card.Points);
            }
        }

        /// <summary>
        /// Displays the hand in the provided ListBox.
        /// </summary>
        public void DisplayHand(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (Card card in _cards)
            {
                listBox.Items.Add(card.ToString());
            }
        }

        /// <summary>
        /// Clears the hand.
        /// </summary>
        public void Clear()
        {
            _cards.Clear();
        }
    }
}
