using System;
using AutoMapper;
using kort.data.values;

namespace kort.data.mappings
{
    public class CardSurfaceFromUnicodeTypeConverter : ITypeConverter<string, CardSurface>
    {
        public CardSurface Convert(string source, CardSurface destination, ResolutionContext context)
        {
            return source.ToCardSurface();
        }
    }

    public class CardSurfaceToUnicodeTypeConverter : ITypeConverter<CardSurface, string>
    {
        public string Convert(CardSurface source, string destination, ResolutionContext context)
        {
            return source.ToUnicode();
        }
    }

}
