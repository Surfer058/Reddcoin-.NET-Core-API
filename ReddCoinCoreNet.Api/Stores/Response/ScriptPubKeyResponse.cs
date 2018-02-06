using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class ScriptPubKeyResponse
    {
        [JsonProperty("asm")]
        public string Asm { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reqSigs")]
        public int? RequestSigs { get; set; }
        
        [JsonProperty("addresses")]
        public IList<string> Addresses { get; set; }
    }
}
