using Lykke.Service.Skycoin.Sign.Core.Sign;

namespace Lykke.Service.Skycoin.Sign.Services.Sign
{
    internal class SignResult : ISignResult
    {
        public string TransactionHex { get; private set; }


        public static SignResult Ok(string signedHex)
        {
            return new SignResult
            {
                TransactionHex = signedHex
            };
        }
    }
}
