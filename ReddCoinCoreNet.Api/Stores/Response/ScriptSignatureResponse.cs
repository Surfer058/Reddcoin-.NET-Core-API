using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class ScriptSignatureResponse
    {
        [JsonProperty("asm")]
        public string Asm { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }
    }
}
