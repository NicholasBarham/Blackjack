using UnityEngine;

namespace Blackjack
{
    [System.Serializable]
    public class Card
    {
        public Card(int[] points, ESuit suit = ESuit.Clubs, ERank rank = ERank.Ace)
        {
            _suit = suit;
            _rank = rank;
            _points = points;
        }

        [SerializeField] private ESuit _suit = ESuit.Clubs;
        public ESuit Suit { get { return _suit; } }

        [SerializeField] private ERank _rank = ERank.Ace;
        public ERank Rank { get { return _rank; } }

        [SerializeField] private int[] _points = new int[0];

        public int[] Points { get { return _points; } }
    }
}

