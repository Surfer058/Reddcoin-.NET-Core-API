using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class LocalAddressResponse
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }
}
