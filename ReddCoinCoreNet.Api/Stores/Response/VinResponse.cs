using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class VinResponse
    {
        [JsonProperty("txid")]
        public string TransactionId { get; set; }

        [JsonProperty("vout")]
        public int Vout { get; set; }

        [JsonProperty("scriptSig")]
        public ScriptSignatureResponse ScriptSignature { get; set; }

        [JsonProperty("sequence")]
        public object Sequence { get; set; }
    }
}
