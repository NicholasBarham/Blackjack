using UnityEngine;

namespace Blackjack
{
    [System.Serializable]
    public class Deck
    {
        public Deck(SOCard[] soCards)
        {
            _cards = new Card[soCards.Length];

            for (int i = 0; i < soCards.Length; i++)
                _cards[i] = soCards[i].Card;
        }

        public Deck(Card[] cards)
        {
            _cards = cards;
        }

        [SerializeField] private Card[] _cards = null;
        public Card[] Cards => _cards;
    }
}
