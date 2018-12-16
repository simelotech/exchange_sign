using System.Collections.Generic;
using skycoin;
namespace Lykke.Service.Skycoin.Sign.Services.Sign
{
    public class TransactionInfo
    {
        public string TransactionHex { get; set; }

        public IEnumerable<skycoin.coin__Transaction> UsedCoins { get; set; }
    }
}
