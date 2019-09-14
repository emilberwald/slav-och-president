using kort.data.values;

namespace kort.data.entities
{
    public class Card
    {
        public uint Id { get; set; }
        public CardSurface Back { get; set; }
        public CardSurface Front { get; set; }
    }
}
