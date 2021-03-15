using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Blackjack/Card")]
public class SOCard : ScriptableObject
{
    [SerializeField] private Card _card = null;
    public Card Card { get { return _card; } }

    [SerializeField] private Sprite _frontImage = null;
    public Sprite FrontImage { get { return _frontImage; } }

    [SerializeField] private Sprite _rearImage = null;
    public Sprite RearImage { get { return _rearImage; } }
}
