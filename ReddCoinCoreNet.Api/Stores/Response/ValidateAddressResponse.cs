using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class ValidateAddressResponse
    {
        [JsonProperty("isvalid")]
        public bool Isvalid { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("ismine")]
        public bool IsMine { get; set; }

        [JsonProperty("isscript")]
        public bool IsScript { get; set; }

        [JsonProperty("pubkey")]
        public string PubKey { get; set; }

        [JsonProperty("iscompressed")]
        public bool IsCompressed { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }
    }
}
