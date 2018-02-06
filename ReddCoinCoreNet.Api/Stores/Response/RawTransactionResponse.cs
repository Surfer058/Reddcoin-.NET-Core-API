using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class RawTransactionResponse
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("txid")]
        public string TransactionId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("locktime")]
        public int LockTime { get; set; }

        [JsonProperty("vin")]
        public List<VinResponse> Vin { get; set; }

        [JsonProperty("vout")]
        public List<VoutResponse> Vout { get; set; }

        [JsonProperty("blockhash")]
        public string BlockHash { get; set; }

        [JsonProperty("confirmations")]
        public int NumberOfConfirmations { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("blocktime")]
        public int BlockTime { get; set; }
    }
}
