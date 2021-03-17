using System.Collections;
using System.Collections.Generic;
using Blackjack;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HandCalculatorTest
    {
        private HandCalculator calculator;

        [OneTimeSetUp]
        public void Setup()
        {
            calculator = new HandCalculator();
        }

        private Card CreateCard(params int[] points)
        {
            return new Card(points);
        }

        private Hand CreateHand(params Card[] cards)
        {
            var hand = new Hand();

            foreach (var card in cards)
            {
                hand.AddCard(card);
            }

            return hand;
        }

        [Test]
        public void DoSimpleSinglePointsCalculations()
        {
            var card1 = CreateCard(9);
            var card2 = CreateCard(8);

            var hand = CreateHand(card1, card2);

            var points = calculator.Calculate(hand);
            Assert.AreEqual(1, points.Length);
            Assert.AreEqual(17, points[0]);
        }

        [Test]
        public void DoDoublePointsCalculations()
        {
            var card1 = CreateCard(1,11);
            var card2 = CreateCard(10);

            var hand = CreateHand(card1, card2);

            var points = calculator.Calculate(hand);
            Assert.AreEqual(2, points.Length);
            Assert.AreEqual(11, points[0]);
            Assert.AreEqual(21, points[1]);
        }

        [Test]
        public void DoTriplePointsCalculations()
        {
            var card1 = CreateCard(1, 11);
            var card2 = CreateCard(7);
            var card3 = CreateCard(1, 11);

            var hand = CreateHand(card1, card2, card3);

            var points = calculator.Calculate(hand);
            Assert.AreEqual(3, points.Length);
            Assert.AreEqual(9, points[0]);
            Assert.AreEqual(19, points[1]);
            Assert.AreEqual(29, points[2]);
        }
    }
}
