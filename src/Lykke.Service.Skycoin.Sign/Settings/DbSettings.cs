using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Skycoin.Sign.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
