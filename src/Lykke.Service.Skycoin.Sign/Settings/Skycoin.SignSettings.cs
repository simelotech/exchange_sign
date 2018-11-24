using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Skycoin.Sign.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class SkycoinSignSettings
    {
        public DbSettings Db { get; set; }
    }
}
