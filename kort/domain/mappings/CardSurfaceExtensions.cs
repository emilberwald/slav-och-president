using System;
using kort.data.mappings;
using kort.data.values;
using kort.domain.values;

namespace kort.domain.mappings
{
    public static class CardSurfaceExtensions
    {
        public static CardRank ToCardRank(this CardSurface card)
        {
            switch (card)
            {
                case CardSurface.BACK:
                {
                    return CardRank.Back;
                }
                case CardSurface.ACE_OF_CLUBS:
                case CardSurface.ACE_OF_DIAMONDS:
                case CardSurface.ACE_OF_HEARTS:
                case CardSurface.ACE_OF_SPADES:
                {
                    return CardRank.Ace;
                }
                case CardSurface.TWO_OF_CLUBS:
                case CardSurface.TWO_OF_DIAMONDS:
                case CardSurface.TWO_OF_HEARTS:
                case CardSurface.TWO_OF_SPADES:
                {
                    return CardRank.Two;
                }
                case CardSurface.THREE_OF_CLUBS:
                case CardSurface.THREE_OF_DIAMONDS:
                case CardSurface.THREE_OF_HEARTS:
                case CardSurface.THREE_OF_SPADES:
                {
                    return CardRank.Three;
                }
                case CardSurface.FOUR_OF_CLUBS:
                case CardSurface.FOUR_OF_DIAMONDS:
                case CardSurface.FOUR_OF_HEARTS:
                case CardSurface.FOUR_OF_SPADES:
                {
                    return CardRank.Four;
                }
                case CardSurface.FIVE_OF_CLUBS:
                case CardSurface.FIVE_OF_DIAMONDS:
                case CardSurface.FIVE_OF_HEARTS:
                case CardSurface.FIVE_OF_SPADES:
                {
                    return CardRank.Five;
                }
                case CardSurface.SIX_OF_CLUBS:
                case CardSurface.SIX_OF_DIAMONDS:
                case CardSurface.SIX_OF_HEARTS:
                case CardSurface.SIX_OF_SPADES:
                {
                    return CardRank.Six;
                }
                case CardSurface.SEVEN_OF_CLUBS:
                case CardSurface.SEVEN_OF_DIAMONDS:
                case CardSurface.SEVEN_OF_HEARTS:
                case CardSurface.SEVEN_OF_SPADES:
                {
                    return CardRank.Seven;
                }
                case CardSurface.EIGHT_OF_CLUBS:
                case CardSurface.EIGHT_OF_DIAMONDS:
                case CardSurface.EIGHT_OF_HEARTS:
                case CardSurface.EIGHT_OF_SPADES:
                {
                    return CardRank.Eight;
                }
                case CardSurface.NINE_OF_CLUBS:
                case CardSurface.NINE_OF_DIAMONDS:
                case CardSurface.NINE_OF_HEARTS:
                case CardSurface.NINE_OF_SPADES:
                {
                    return CardRank.Nine;
                }
                case CardSurface.TEN_OF_CLUBS:
                case CardSurface.TEN_OF_DIAMONDS:
                case CardSurface.TEN_OF_HEARTS:
                case CardSurface.TEN_OF_SPADES:
                {
                    return CardRank.Ten;
                }
                case CardSurface.JACK_OF_CLUBS:
                case CardSurface.JACK_OF_DIAMONDS:
                case CardSurface.JACK_OF_HEARTS:
                case CardSurface.JACK_OF_SPADES:
                {
                    return CardRank.Jack;
                }
                case CardSurface.KNIGHT_OF_CLUBS:
                case CardSurface.KNIGHT_OF_DIAMONDS:
                case CardSurface.KNIGHT_OF_HEARTS:
                case CardSurface.KNIGHT_OF_SPADES:
                {
                    return CardRank.Knight;
                }
                case CardSurface.QUEEN_OF_CLUBS:
                case CardSurface.QUEEN_OF_DIAMONDS:
                case CardSurface.QUEEN_OF_HEARTS:
                case CardSurface.QUEEN_OF_SPADES:
                {
                    return CardRank.Queen;
                }
                case CardSurface.KING_OF_CLUBS:
                case CardSurface.KING_OF_DIAMONDS:
                case CardSurface.KING_OF_HEARTS:
                case CardSurface.KING_OF_SPADES:
                {
                    return CardRank.King;
                }
                case CardSurface.BLACK_JOKER:
                case CardSurface.RED_JOKER:
                case CardSurface.WHITE_JOKER:
                {
                    return CardRank.Joker;
                }
                case CardSurface.FOOL:
                {
                    return CardRank.Fool;
                }
                case CardSurface.TRUMP_1:
                case CardSurface.TRUMP_2:
                case CardSurface.TRUMP_3:
                case CardSurface.TRUMP_4:
                case CardSurface.TRUMP_5:
                case CardSurface.TRUMP_6:
                case CardSurface.TRUMP_7:
                case CardSurface.TRUMP_8:
                case CardSurface.TRUMP_9:
                case CardSurface.TRUMP_10:
                case CardSurface.TRUMP_11:
                case CardSurface.TRUMP_12:
                case CardSurface.TRUMP_13:
                case CardSurface.TRUMP_14:
                case CardSurface.TRUMP_15:
                case CardSurface.TRUMP_16:
                case CardSurface.TRUMP_17:
                case CardSurface.TRUMP_18:
                case CardSurface.TRUMP_19:
                case CardSurface.TRUMP_20:
                case CardSurface.TRUMP_21:
                {
                    return CardRank.Trump;
                }
                default:
                    throw new ArgumentException();
            }
        }

        public static CardColor ToCardColor(this CardSurface card)
        {
            switch (card)
            {
                case CardSurface.ACE_OF_SPADES:
                case CardSurface.TWO_OF_SPADES:
                case CardSurface.THREE_OF_SPADES:
                case CardSurface.FOUR_OF_SPADES:
                case CardSurface.FIVE_OF_SPADES:
                case CardSurface.SIX_OF_SPADES:
                case CardSurface.SEVEN_OF_SPADES:
                case CardSurface.EIGHT_OF_SPADES:
                case CardSurface.NINE_OF_SPADES:
                case CardSurface.TEN_OF_SPADES:
                case CardSurface.JACK_OF_SPADES:
                case CardSurface.KNIGHT_OF_SPADES:
                case CardSurface.QUEEN_OF_SPADES:
                case CardSurface.KING_OF_SPADES:
                case CardSurface.ACE_OF_CLUBS:
                case CardSurface.TWO_OF_CLUBS:
                case CardSurface.THREE_OF_CLUBS:
                case CardSurface.FOUR_OF_CLUBS:
                case CardSurface.FIVE_OF_CLUBS:
                case CardSurface.SIX_OF_CLUBS:
                case CardSurface.SEVEN_OF_CLUBS:
                case CardSurface.EIGHT_OF_CLUBS:
                case CardSurface.NINE_OF_CLUBS:
                case CardSurface.TEN_OF_CLUBS:
                case CardSurface.JACK_OF_CLUBS:
                case CardSurface.KNIGHT_OF_CLUBS:
                case CardSurface.QUEEN_OF_CLUBS:
                case CardSurface.KING_OF_CLUBS:
                case CardSurface.BLACK_JOKER:
                {
                    return CardColor.Black;
                }
                case CardSurface.ACE_OF_HEARTS:
                case CardSurface.TWO_OF_HEARTS:
                case CardSurface.THREE_OF_HEARTS:
                case CardSurface.FOUR_OF_HEARTS:
                case CardSurface.FIVE_OF_HEARTS:
                case CardSurface.SIX_OF_HEARTS:
                case CardSurface.SEVEN_OF_HEARTS:
                case CardSurface.EIGHT_OF_HEARTS:
                case CardSurface.NINE_OF_HEARTS:
                case CardSurface.TEN_OF_HEARTS:
                case CardSurface.JACK_OF_HEARTS:
                case CardSurface.KNIGHT_OF_HEARTS:
                case CardSurface.QUEEN_OF_HEARTS:
                case CardSurface.KING_OF_HEARTS:
                case CardSurface.ACE_OF_DIAMONDS:
                case CardSurface.TWO_OF_DIAMONDS:
                case CardSurface.THREE_OF_DIAMONDS:
                case CardSurface.FOUR_OF_DIAMONDS:
                case CardSurface.FIVE_OF_DIAMONDS:
                case CardSurface.SIX_OF_DIAMONDS:
                case CardSurface.SEVEN_OF_DIAMONDS:
                case CardSurface.EIGHT_OF_DIAMONDS:
                case CardSurface.NINE_OF_DIAMONDS:
                case CardSurface.TEN_OF_DIAMONDS:
                case CardSurface.JACK_OF_DIAMONDS:
                case CardSurface.KNIGHT_OF_DIAMONDS:
                case CardSurface.QUEEN_OF_DIAMONDS:
                case CardSurface.KING_OF_DIAMONDS:
                case CardSurface.RED_JOKER:
                {
                    return CardColor.Red;
                }
                case CardSurface.WHITE_JOKER:
                {
                    return CardColor.White;
                }
                default:
                {
                    throw new ArgumentException();
                }
            }
        }

        public static CardSuite ToCardSuite(this CardSurface card)
        {
            switch (card)
            {
                case CardSurface.ACE_OF_SPADES:
                case CardSurface.TWO_OF_SPADES:
                case CardSurface.THREE_OF_SPADES:
                case CardSurface.FOUR_OF_SPADES:
                case CardSurface.FIVE_OF_SPADES:
                case CardSurface.SIX_OF_SPADES:
                case CardSurface.SEVEN_OF_SPADES:
                case CardSurface.EIGHT_OF_SPADES:
                case CardSurface.NINE_OF_SPADES:
                case CardSurface.TEN_OF_SPADES:
                case CardSurface.JACK_OF_SPADES:
                case CardSurface.KNIGHT_OF_SPADES:
                case CardSurface.QUEEN_OF_SPADES:
                case CardSurface.KING_OF_SPADES:
                {
                    return CardSuite.Spades;
                }
                case CardSurface.ACE_OF_HEARTS:
                case CardSurface.TWO_OF_HEARTS:
                case CardSurface.THREE_OF_HEARTS:
                case CardSurface.FOUR_OF_HEARTS:
                case CardSurface.FIVE_OF_HEARTS:
                case CardSurface.SIX_OF_HEARTS:
                case CardSurface.SEVEN_OF_HEARTS:
                case CardSurface.EIGHT_OF_HEARTS:
                case CardSurface.NINE_OF_HEARTS:
                case CardSurface.TEN_OF_HEARTS:
                case CardSurface.JACK_OF_HEARTS:
                case CardSurface.KNIGHT_OF_HEARTS:
                case CardSurface.QUEEN_OF_HEARTS:
                case CardSurface.KING_OF_HEARTS:
                {
                    return CardSuite.Hearts;
                }
                case CardSurface.ACE_OF_DIAMONDS:
                case CardSurface.TWO_OF_DIAMONDS:
                case CardSurface.THREE_OF_DIAMONDS:
                case CardSurface.FOUR_OF_DIAMONDS:
                case CardSurface.FIVE_OF_DIAMONDS:
                case CardSurface.SIX_OF_DIAMONDS:
                case CardSurface.SEVEN_OF_DIAMONDS:
                case CardSurface.EIGHT_OF_DIAMONDS:
                case CardSurface.NINE_OF_DIAMONDS:
                case CardSurface.TEN_OF_DIAMONDS:
                case CardSurface.JACK_OF_DIAMONDS:
                case CardSurface.KNIGHT_OF_DIAMONDS:
                case CardSurface.QUEEN_OF_DIAMONDS:
                case CardSurface.KING_OF_DIAMONDS:
                {
                    return CardSuite.Diamonds;
                }
                case CardSurface.ACE_OF_CLUBS:
                case CardSurface.TWO_OF_CLUBS:
                case CardSurface.THREE_OF_CLUBS:
                case CardSurface.FOUR_OF_CLUBS:
                case CardSurface.FIVE_OF_CLUBS:
                case CardSurface.SIX_OF_CLUBS:
                case CardSurface.SEVEN_OF_CLUBS:
                case CardSurface.EIGHT_OF_CLUBS:
                case CardSurface.NINE_OF_CLUBS:
                case CardSurface.TEN_OF_CLUBS:
                case CardSurface.JACK_OF_CLUBS:
                case CardSurface.KNIGHT_OF_CLUBS:
                case CardSurface.QUEEN_OF_CLUBS:
                case CardSurface.KING_OF_CLUBS:
                {
                    return CardSuite.Clubs;
                }
                default:
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}