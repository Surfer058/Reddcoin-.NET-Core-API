using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class WalletResponse
    {
        [JsonProperty("walletversion")]
        public string WalletVersion { get; set; }

        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("txcount")]
        public ulong TxCount { get; set; }

        [JsonProperty("keypoololdest")]
        public decimal KeyPoolOldest { get; set; }

        [JsonProperty("unlocked_until")]
        public ulong UnlockedUntil { get; set; }

        [JsonProperty("keypoolsize")]
        public ulong KeyPoolSize { get; set; }
    }
}
