using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class NetworkInfoResponse
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("protocolversion")]
        public int ProtocolVersion { get; set; }

        [JsonProperty("timeoffset")]
        public int TimeOffset { get; set; }

        [JsonProperty("connections")]
        public int Connections { get; set; }

        [JsonProperty("proxy")]
        public string Proxy { get; set; }

        [JsonProperty("relayfee")]
        public decimal RelayFee { get; set; }

        [JsonProperty("localaddresses")]
        public List<LocalAddressResponse> Localaddresses { get; set; }
    }
}
