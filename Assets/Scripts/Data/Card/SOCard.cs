using UnityEngine;

namespace Blackjack
{
    [CreateAssetMenu(fileName = "Card", menuName = "Blackjack/Card")]
    public class SOCard : ScriptableObject
    {
        [SerializeField] private Card _card = null;
        public Card Card => _card;

        [SerializeField] private Sprite _frontImage = null;
        public Sprite FrontImage => _frontImage;

        [SerializeField] private Sprite _rearImage = null;
        public Sprite RearImage => _rearImage;
    }
}