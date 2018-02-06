using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class TransactionResponse
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("blockindex")]
        public int BlockIndex { get; set; }

        [JsonProperty("blocktime")]
        public int BlockTime { get; set; }

        [JsonProperty("txid")]
        public string TransactionId { get; set; }

        [JsonProperty("walletconflicts")]
        public IList<object> WalletConflicts { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("timereceived")]
        public int TimeReceived { get; set; }

        [JsonProperty("details")]
        public List<TransactionDetailResponse> Details { get; set; }

        [JsonProperty("hex")]
        public string Hexadecimal { get; set; }
    }
}
