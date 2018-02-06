using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class ReceivedByAccountResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("confirmations")]
        public int NumberOfConfirmations { get; set; }
    }
}
