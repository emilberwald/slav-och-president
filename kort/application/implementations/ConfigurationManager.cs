using System;
using kort.data.contexts;
using Newtonsoft.Json;

namespace kort.application.implementations
{
    /// <summary>
    /// Manages configuration as in https://docs.microsoft.com/sv-se/windows/uwp/design/app-settings/store-and-retrieve-app-data#retrieve-the-local-app-data-store
    /// </summary>
    public class ConfigurationManager : IConfigurationManager
    {
        internal class SqliteSettings : ISqliteSettings { public string ConnectionString { get; set; } public int? CommandTimeout { get; set; } };

        public ISqliteSettings CreateISqliteSettings(Uri sqliteUri, int? commandTimeout)
        {
            return new SqliteSettings
            {
                ConnectionString = $"Data Source={sqliteUri.LocalPath};Version=3;",
                CommandTimeout = commandTimeout
            };
        }

        public bool Has<T>()
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            return localSettings.Values.ContainsKey(typeof(T).FullName);
        }

        public void Set<T>(T t)
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            localSettings.Values[typeof(T).FullName] = JsonConvert.SerializeObject(t);
        }

        public T Get<T>()
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            string value = localSettings.Values[typeof(T).FullName] as string;
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}