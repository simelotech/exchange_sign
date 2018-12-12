﻿using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Skycoin.Sign.Client 
{
    /// <summary>
    /// Skycoin.Sign client settings.
    /// </summary>
    public class SkycoinSignServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
