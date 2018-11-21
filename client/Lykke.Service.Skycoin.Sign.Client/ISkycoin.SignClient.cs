using JetBrains.Annotations;

namespace Lykke.Service.Skycoin.Sign.Client
{
    /// <summary>
    /// Skycoin.Sign client interface.
    /// </summary>
    [PublicAPI]
    public interface ISkycoin.SignClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - ISkycoin.SignApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        ISkycoin.SignApi Api { get; }
    }
}
