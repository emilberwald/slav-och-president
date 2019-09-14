using System;
using System.Reflection;
using AutoMapper;
using kort.application;
using kort.application.implementations;
using kort.data.mappings;
using kort.data.values;
using kort.domain.mappings;
using kort.domain.models;
using kort.domain.models.implementations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace kort.composition
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<ICard, FrenchCard>().ConstructUsing(c => new FrenchCard(c.Suite, c.Rank));
            this.CreateMap<FrenchCard, CardSurface>().ConvertUsing<ICardToCardSurfaceTypeConverter>();
            this.CreateMap<CardSurface, FrenchCard>().ConvertUsing<CardSurfaceToFrenchCardTypeConverter>();
            this.CreateMap<string, CardSurface>().ConvertUsing<CardSurfaceFromUnicodeTypeConverter>();
            this.CreateMap<CardSurface, string>().ConvertUsing<CardSurfaceToUnicodeTypeConverter>();
        }
    }

    public static class Composer
    {
        public static IServiceProvider ConfigureServices(IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddLogging(builder => builder
                                        .AddConsole()
                                        .AddFile(o =>
                                        {
                                            o.RootPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
                                        })
                                        .SetMinimumLevel(LogLevel.Trace)
                                        )
                .AddSingleton<IConfigurationManager, ConfigurationManager>()
                .AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfile)))
                .BuildServiceProvider();
        }
    }
}