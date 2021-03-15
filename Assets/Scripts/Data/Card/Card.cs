using UnityEngine;

[System.Serializable]
public class Card
{
    [SerializeField] private ESuit _suit = ESuit.Clubs;
    public ESuit Suit { get { return _suit; } }

    [SerializeField] private ERank _rank = ERank.Ace;
    public ERank Rank { get { return _rank; } }

    [SerializeField] private int[] _points = new int[0];
    public int[] Points { get { return _points; } }
}
