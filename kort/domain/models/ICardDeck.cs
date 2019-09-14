using System.Collections.Generic;

namespace kort.domain.models
{
    internal interface ICardDeck
    {
        IEnumerable<ICard> GetDeck();
    }
}