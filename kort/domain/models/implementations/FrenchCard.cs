using System;
using kort.domain.values;

namespace kort.domain.models.implementations
{
    public class FrenchCard : ICard
    {
        public FrenchCard(CardSuite cardSuite, CardRank cardRank)
        {
            this.Suite = cardSuite;
            this.Rank = cardRank;
            switch (cardSuite)
            {
                case CardSuite.Spades:
                { this.Color = CardColor.Black; break; }
                case CardSuite.Clubs:
                { this.Color = CardColor.Black; break; }
                case CardSuite.Diamonds:
                { this.Color = CardColor.Red; break; }
                case CardSuite.Hearts:
                { this.Color = CardColor.Red; break; }
                default:
                    throw new ArgumentException();
            }
        }

        public CardColor Color { get; private set; }

        public CardRank Rank { get; private set; }

        public CardSuite Suite { get; private set; }
    }
}