using Lykke.HttpClientGenerator;

namespace Lykke.Service.Skycoin.Sign.Client
{
    /// <summary>
    /// Skycoin.Sign API aggregating interface.
    /// </summary>
    public class SkycoinSignClient : ISkycoinSignClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to Skycoin.Sign Api.</summary>
        public ISkycoinSignApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public SkycoinSignClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<ISkycoinSignApi>();
        }
    }
}
