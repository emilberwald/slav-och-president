using System;
using System.Collections.Generic;
using kort.domain.values;

namespace kort.domain.models.implementations
{
    public class FrenchCardDeck : ICardDeck
    {
        public IEnumerable<ICard> GetDeck()
        {
            foreach (CardSuite suite in Enum.GetValues(typeof(CardSuite)))
            {
                switch (suite)
                {
                    case CardSuite.Spades:
                    case CardSuite.Clubs:
                    case CardSuite.Diamonds:
                    case CardSuite.Hearts:
                    {
                        foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                        {
                            switch (rank)
                            {
                                case CardRank.Ace:
                                case CardRank.Two:
                                case CardRank.Three:
                                case CardRank.Four:
                                case CardRank.Five:
                                case CardRank.Six:
                                case CardRank.Seven:
                                case CardRank.Eight:
                                case CardRank.Nine:
                                case CardRank.Ten:
                                case CardRank.Jack:
                                case CardRank.Knight:
                                case CardRank.Queen:
                                case CardRank.King:
                                {
                                    yield return new FrenchCard(suite, rank);
                                    break;
                                }
                                default: break;
                            }
                        }
                        break;
                    }
                    default: break;
                }
            }
        }
    }
}