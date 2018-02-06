using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class VoutResponse
    {
        [JsonProperty("txid")]
        public decimal Value { get; set; }

        [JsonProperty("in")]
        public int Number { get; set; }

        [JsonProperty("scriptPubKey")]
        public ScriptPubKeyResponse ScriptPubKey { get; set; }
    }
}
