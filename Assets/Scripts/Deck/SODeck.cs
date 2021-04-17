using UnityEngine;

namespace Blackjack
{
    [CreateAssetMenu(fileName = "Deck", menuName = "Blackjack/Deck")]
    public class SODeck : ScriptableObject
    {
        [SerializeField] private SOCard[] _cards = null;

        private Deck _deck = null;

        public Deck Deck
        {
            get
            {
                if (_deck == null)
                {
                    if (_cards == null)
                        return new Deck(new Card[0]);
                    else
                        _deck = new Deck(_cards);
                }
                    
                return _deck;
            }
        }
    }
}