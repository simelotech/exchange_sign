using Lykke.HttpClientGenerator;

namespace Lykke.Service.Skycoin.Sign.Client
{
    /// <summary>
    /// Skycoin.Sign API aggregating interface.
    /// </summary>
    public class Skycoin.SignClient : ISkycoin.SignClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to Skycoin.Sign Api.</summary>
        public ISkycoin.SignApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public Skycoin.SignClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<ISkycoin.SignApi>();
        }
    }
}
