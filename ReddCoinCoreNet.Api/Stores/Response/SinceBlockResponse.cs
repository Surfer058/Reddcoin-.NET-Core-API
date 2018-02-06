using System.Collections.Generic;
using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class SinceBlockResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("confirmations")]
        public int NumberOfConfirmations { get; set; }

        [JsonProperty("generated")]
        public bool IsGenerated { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("blockindex")]
        public int Blockindex { get; set; }

        [JsonProperty("blocktime")]
        public int Blocktime { get; set; }

        [JsonProperty("txid")]
        public string TransactionId { get; set; }

        [JsonProperty("walletconflicts")]
        public List<object> WalletConflicts { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("timereceived")]
        public int TimeReceived { get; set; }

        [JsonProperty("fee")]
        public decimal? Fee { get; set; }
    }
}
