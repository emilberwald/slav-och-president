using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using kort.application;
using kort.data.contexts;
using kort.data.values;
using kort.domain.extensions;
using kort.domain.models;
using kort.domain.models.implementations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace kort.presentation.viewmodels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        public IMapper Mapper { get; }
        public ILogger<SettingsPageViewModel> Logger { get; }
        internal IConfigurationManager ConfigurationManager { get; private set; }
        public ICommand ConfigureCommand { get; set; }
        public ICommand ViewLoadedCommand { get; set; }
        public RelayCommand AddDeckCommand { get; set; }

        private List<FrenchCard> currentHand;

        public string CurrentHand
        {
            get
            {
                return this.currentHand == null
                        ? "<empty>"
                        : string.Join(",", this.currentHand.Select(x=>this.Mapper.Map<string>(this.Mapper.Map<CardSurface>(x))));
            }
            set
            {
                this.Set(ref this.currentHand, value.Split(",").Select(x => this.Mapper.Map<FrenchCard>(this.Mapper.Map<CardSurface>(x))).ToList());
            }
        }

        /// <summary>
        /// Default constructor for XAML
        /// </summary>
        public SettingsPageViewModel() : this
            (
                (App.Current as App)?.ServiceProvider.GetService<ILogger<SettingsPageViewModel>>(),
                (App.Current as App)?.ServiceProvider.GetService<IConfigurationManager>(),
                (App.Current as App)?.ServiceProvider.GetService<IMapper>()
            )
        { }

        public SettingsPageViewModel(ILogger<SettingsPageViewModel> logger, IConfigurationManager configurationManager, IMapper mapper)
        {
            this.Mapper = mapper;
            this.Logger = logger;
            this.ConfigurationManager = configurationManager;
            this.ConfigureCommand = new RelayCommand(async () => await this.Configure());
            this.ViewLoadedCommand = new RelayCommand(async () =>
            {
                if (!this.ConfigurationManager?.Has<ISqliteSettings>() ?? false)
                {
                    this.Logger.LogWarning("ISQliteSettings are not set.");
                    await this.Configure();
                }
            });
            this.AddDeckCommand = new RelayCommand(() =>
            {
                var deck = new FrenchCardDeck().GetDeck().AsQueryable().ProjectTo<FrenchCard>(this.Mapper.ConfigurationProvider).ToList().Shuffle().Take(5);
                this.CurrentHand = string.Join(",", deck.Select(x=>this.Mapper.Map<string>(this.Mapper.Map<CardSurface>(x))));
            });
        }

        public async Task Configure()
        {
            var databaseUri = await ChooseFile();
            if (databaseUri == null)
                throw new ArgumentNullException("databaseUri");
            this.ConfigurationManager.Set(this.ConfigurationManager.CreateISqliteSettings(databaseUri, null));
        }

        private static async Task<Uri> ChooseFile()
        {
            FileSavePicker savePicker = new FileSavePicker
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("SQLite", new List<string>() { ".sqlite" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = "database";

            StorageFile file = await savePicker.PickSaveFileAsync();
            return file != null ? new Uri(file.Path, UriKind.Absolute) : null;
        }
    }
}