using System;
using kort.data.values;

namespace kort.data.mappings
{
    public static class CardSurfaceExtensions
    {
        public static CardSurface ToCardSurface(this string unicode)
        {
            if (unicode == null)
                throw new ArgumentNullException(unicode);
            foreach (CardSurface value in Enum.GetValues(typeof(CardSurface)))
            {
                if (value.ToUnicode() == unicode)
                {
                    return value;
                }
            }
            throw new ArgumentException();
        }
        public static string ToUnicode(this CardSurface card)
        {
            switch (card)
            {
                case CardSurface.BACK:
                    return "🂠";

                case CardSurface.ACE_OF_SPADES:
                    return "🂡";

                case CardSurface.TWO_OF_SPADES:
                    return "🂢";

                case CardSurface.THREE_OF_SPADES:
                    return "🂣";

                case CardSurface.FOUR_OF_SPADES:
                    return "🂤";

                case CardSurface.FIVE_OF_SPADES:
                    return "🂥";

                case CardSurface.SIX_OF_SPADES:
                    return "🂦";

                case CardSurface.SEVEN_OF_SPADES:
                    return "🂧";

                case CardSurface.EIGHT_OF_SPADES:
                    return "🂨";

                case CardSurface.NINE_OF_SPADES:
                    return "🂩";

                case CardSurface.TEN_OF_SPADES:
                    return "🂪";

                case CardSurface.JACK_OF_SPADES:
                    return "🂫";

                case CardSurface.KNIGHT_OF_SPADES:
                    return "🂬";

                case CardSurface.QUEEN_OF_SPADES:
                    return "🂭";

                case CardSurface.KING_OF_SPADES:
                    return "🂮";

                case CardSurface.ACE_OF_HEARTS:
                    return "🂱";

                case CardSurface.TWO_OF_HEARTS:
                    return "🂲";

                case CardSurface.THREE_OF_HEARTS:
                    return "🂳";

                case CardSurface.FOUR_OF_HEARTS:
                    return "🂴";

                case CardSurface.FIVE_OF_HEARTS:
                    return "🂵";

                case CardSurface.SIX_OF_HEARTS:
                    return "🂶";

                case CardSurface.SEVEN_OF_HEARTS:
                    return "🂷";

                case CardSurface.EIGHT_OF_HEARTS:
                    return "🂸";

                case CardSurface.NINE_OF_HEARTS:
                    return "🂹";

                case CardSurface.TEN_OF_HEARTS:
                    return "🂺";

                case CardSurface.JACK_OF_HEARTS:
                    return "🂻";

                case CardSurface.KNIGHT_OF_HEARTS:
                    return "🂼";

                case CardSurface.QUEEN_OF_HEARTS:
                    return "🂽";

                case CardSurface.KING_OF_HEARTS:
                    return "🂾";

                case CardSurface.RED_JOKER:
                    return "🂿";

                case CardSurface.ACE_OF_DIAMONDS:
                    return "🃁";

                case CardSurface.TWO_OF_DIAMONDS:
                    return "🃂";

                case CardSurface.THREE_OF_DIAMONDS:
                    return "🃃";

                case CardSurface.FOUR_OF_DIAMONDS:
                    return "🃄";

                case CardSurface.FIVE_OF_DIAMONDS:
                    return "🃅";

                case CardSurface.SIX_OF_DIAMONDS:
                    return "🃆";

                case CardSurface.SEVEN_OF_DIAMONDS:
                    return "🃇";

                case CardSurface.EIGHT_OF_DIAMONDS:
                    return "🃈";

                case CardSurface.NINE_OF_DIAMONDS:
                    return "🃉";

                case CardSurface.TEN_OF_DIAMONDS:
                    return "🃊";

                case CardSurface.JACK_OF_DIAMONDS:
                    return "🃋";

                case CardSurface.KNIGHT_OF_DIAMONDS:
                    return "🃌";

                case CardSurface.QUEEN_OF_DIAMONDS:
                    return "🃍";

                case CardSurface.KING_OF_DIAMONDS:
                    return "🃎";

                case CardSurface.BLACK_JOKER:
                    return "🃏";

                case CardSurface.ACE_OF_CLUBS:
                    return "🃑";

                case CardSurface.TWO_OF_CLUBS:
                    return "🃒";

                case CardSurface.THREE_OF_CLUBS:
                    return "🃓";

                case CardSurface.FOUR_OF_CLUBS:
                    return "🃔";

                case CardSurface.FIVE_OF_CLUBS:
                    return "🃕";

                case CardSurface.SIX_OF_CLUBS:
                    return "🃖";

                case CardSurface.SEVEN_OF_CLUBS:
                    return "🃗";

                case CardSurface.EIGHT_OF_CLUBS:
                    return "🃘";

                case CardSurface.NINE_OF_CLUBS:
                    return "🃙";

                case CardSurface.TEN_OF_CLUBS:
                    return "🃚";

                case CardSurface.JACK_OF_CLUBS:
                    return "🃛";

                case CardSurface.KNIGHT_OF_CLUBS:
                    return "🃜";

                case CardSurface.QUEEN_OF_CLUBS:
                    return "🃝";

                case CardSurface.KING_OF_CLUBS:
                    return "🃞";

                case CardSurface.WHITE_JOKER:
                    return "🃟";

                case CardSurface.FOOL:
                    return "🃠";

                case CardSurface.TRUMP_1:
                    return "🃡";

                case CardSurface.TRUMP_2:
                    return "🃢";

                case CardSurface.TRUMP_3:
                    return "🃣";

                case CardSurface.TRUMP_4:
                    return "🃤";

                case CardSurface.TRUMP_5:
                    return "🃥";

                case CardSurface.TRUMP_6:
                    return "🃦";

                case CardSurface.TRUMP_7:
                    return "🃧";

                case CardSurface.TRUMP_8:
                    return "🃨";

                case CardSurface.TRUMP_9:
                    return "🃩";

                case CardSurface.TRUMP_10:
                    return "🃪";

                case CardSurface.TRUMP_11:
                    return "🃫";

                case CardSurface.TRUMP_12:
                    return "🃬";

                case CardSurface.TRUMP_13:
                    return "🃭";

                case CardSurface.TRUMP_14:
                    return "🃮";

                case CardSurface.TRUMP_15:
                    return "🃯";

                case CardSurface.TRUMP_16:
                    return "🃰";

                case CardSurface.TRUMP_17:
                    return "🃱";

                case CardSurface.TRUMP_18:
                    return "🃲";

                case CardSurface.TRUMP_19:
                    return "🃳";

                case CardSurface.TRUMP_20:
                    return "🃴";

                case CardSurface.TRUMP_21:
                    return "🃵";

                default:
                    throw new ArgumentException();
            }
        }
    }
}
