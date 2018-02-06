using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class InfoResponse
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("protocolversion")]
        public int ProtocolVersion { get; set; }

        [JsonProperty("walletversion")]
        public int WalletVersion { get; set; }

        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("stake")]
        public decimal Stake { get; set; }

        [JsonProperty("locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("encrypted")]
        public bool IsEncrypted { get; set; }

        [JsonProperty("blocks")]
        public int NumberOfBlocks { get; set; }

        [JsonProperty("timeoffset")]
        public int TimeOffset { get; set; }

        [JsonProperty("moneysupply")]
        public decimal MoneySupply { get; set; }

        [JsonProperty("connections")]
        public int NumberOfConnections { get; set; }

        [JsonProperty("proxy")]
        public string Proxy { get; set; }

        [JsonProperty("difficulty")]
        public decimal Difficulty { get; set; }

        [JsonProperty("testnet")]
        public bool Testnet { get; set; }

        [JsonProperty("keypoololdest")]
        public int KeypoolOldest { get; set; }

        [JsonProperty("keypoolsize")]
        public int KeypoolSize { get; set; }

        [JsonProperty("unlocked_until")]
        public int UnlockedUntil { get; set; }

        [JsonProperty("paytxfee")]
        public decimal PayTransactionFee { get; set; }

        [JsonProperty("relayfee")]
        public decimal RelayFee { get; set; }

        [JsonProperty("errors")]
        public string Errors { get; set; }
    }
}
