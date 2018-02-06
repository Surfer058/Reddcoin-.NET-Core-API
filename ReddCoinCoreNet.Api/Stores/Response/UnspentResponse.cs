using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class UnspentResponse
    {
        [JsonProperty("txid")]
        public string TransactionId { get; set; }

        [JsonProperty("vout")]
        public int Vout { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("scriptPubKey")]
        public string ScriptPubKey { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("confirmations")]
        public int NumberOfConfirmations { get; set; }
    }
}
