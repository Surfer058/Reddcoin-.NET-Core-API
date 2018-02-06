using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class TransactionDetailResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
