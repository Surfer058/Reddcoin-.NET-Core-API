using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class TransactionOutputResponse
    {
        [JsonProperty("bestblock")]
        public string Bestblock { get; set; }

        [JsonProperty("confirmations")]
        public int NumberOfConfirmations { get; set; }

        [JsonProperty("value")]
        public decimal TransactionValue { get; set; }

        [JsonProperty("scriptPubKey")]
        public ScriptPubKeyResponse ScriptPubKey { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("coinbase")]
        public bool Coinbase { get; set; }
    }
}
