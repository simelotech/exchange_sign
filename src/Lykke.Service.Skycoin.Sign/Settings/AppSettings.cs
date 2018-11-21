using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.Skycoin.Sign.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public Skycoin.SignSettings Skycoin.SignService { get; set; }
    }
}
