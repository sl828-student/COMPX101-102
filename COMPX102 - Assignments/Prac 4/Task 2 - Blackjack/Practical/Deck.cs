using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public class Deck
    {
        private List<Card> _CardsList;
        private Random _Random;
        private int _NextCard;
  
        /// <summary>
        /// constructor initialises variables and creates the deck object
        /// </summary>
        public Deck()
        {
            _Random = new Random();
            _NextCard = 0;
            _CardsList= new List<Card>();

            for (int i = 1; i <= 52; i++) 
            {
                _CardsList.Add(new Card(i));
            }

            ShuffleDeck();
        }
        /// <summary>
        /// Writes all cards in the deck to the console
        /// </summary>
        private void DisplayDeck()
        {
            foreach (Card card in _CardsList)
            {
                Console.WriteLine(card.ToString());
            }
        }
        /// <summary>
        /// Shuffles the order of the cards in the cardslist
        /// </summary>
        private void ShuffleDeck()
        {
            int n = _CardsList.Count;
            while (n > 1) 
            {
                n--;
                int k = _Random.Next(n + 1);
                Card value = _CardsList[k];
                _CardsList[k] = _CardsList[n];
                _CardsList[n] = value;
            }
        }
        /// <summary>
        /// Deals a new card if the number of cards is less thean the number of cards in the cardslist, throws new exception if therer are too many
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Card DealCard()
        {
            if (_NextCard < _CardsList.Count)
            {
                return _CardsList[_NextCard++];   
            }
            else
            { throw new Exception("No more cards to deal"); }
        }

    }
}
