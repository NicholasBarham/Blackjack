using System.Collections;
using System.Collections.Generic;

namespace Blackjack
{
    public class Hand
    {
        private List<Card> _cards = new List<Card>();
        public List<Card> Cards => _cards;

        private HandCalculator calculator = new HandCalculator();

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public void ResetHand()
        {
            _cards.Clear();
        }
    }
}