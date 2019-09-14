using System;
using AutoMapper;
using kort.data.values;
using kort.domain.models;
using kort.domain.models.implementations;

namespace kort.domain.mappings
{
    public class ICardToCardSurfaceTypeConverter : ITypeConverter<ICard, CardSurface>
    {
        public CardSurface Convert(ICard source, CardSurface destination, ResolutionContext context)
        {
            foreach (CardSurface value in Enum.GetValues(typeof(CardSurface)))
            {
                if (value.ToCardRank() == source.Rank
                    && value.ToCardColor() == source.Color
                    && value.ToCardSuite() == source.Suite)
                {
                    return value;
                }
            }
            throw new ArgumentException();
        }
    }

    public class CardSurfaceToFrenchCardTypeConverter : ITypeConverter<CardSurface, FrenchCard>
    {
        public FrenchCard Convert(CardSurface source, FrenchCard destination, ResolutionContext context)
        {
            return new FrenchCard(source.ToCardSuite(), source.ToCardRank());
        }
    }

}
