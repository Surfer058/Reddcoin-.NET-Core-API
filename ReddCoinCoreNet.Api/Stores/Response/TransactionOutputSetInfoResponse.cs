
using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class TransactionOutputSetInfoResponse
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("bestblock")]
        public string BestBlock { get; set; }

        [JsonProperty("transactions")]
        public int NumberOfTransactions { get; set; }

        [JsonProperty("txouts")]
        public int NumberOfTransactionOutputs { get; set; }

        [JsonProperty("bytes_serialized")]
        public int BytesSerialized { get; set; }

        [JsonProperty("hash_serialized")]
        public string HashSerialized { get; set; }

        [JsonProperty("total_amount")]
        public decimal TotalAmount { get; set; }
    }
}
