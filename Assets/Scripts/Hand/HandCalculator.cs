using System.Collections.Generic;

namespace Blackjack
{
    public class HandCalculator
    {
        public int[] Calculate(Hand hand)
        {
            return Calculate(hand.Cards);
        }

        public int[] Calculate(List<Card> cards)
        {
            if (cards.Count < 1)
                return new int[0];

            var scores = new List<int>();

            foreach (var card in cards)
            {
                if(scores.Count == 0)
                {
                    foreach (var point in card.Points)
                    {
                        scores.Add(point);
                    }

                    continue;
                }

                var newScores = new List<int>();

                foreach (var score in scores)
                {
                    foreach (var point in card.Points)
                    {
                        int pointsAdded = score + point;

                        if(newScores.Contains(pointsAdded))
                            continue;

                        newScores.Add(score + point);
                    }
                }

                scores = newScores;
            }

            return scores.ToArray();
        }
    }
}