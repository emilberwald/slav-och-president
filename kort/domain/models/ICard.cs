using kort.domain.values;

namespace kort.domain.models
{
    public interface ICard
    {
        CardColor Color { get; }
        CardRank Rank { get; }
        CardSuite Suite { get; }
    }
}