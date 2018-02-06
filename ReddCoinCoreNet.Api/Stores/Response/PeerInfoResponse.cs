using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class PeerInfoResponse
    {
        [JsonProperty("addr")]
        public string Address { get; set; }

        [JsonProperty("services")]
        public string Services { get; set; }

        [JsonProperty("lastsend")]
        public int LastSend { get; set; }

        [JsonProperty("lastrecv")]
        public int LastReceived { get; set; }

        [JsonProperty("bytessent")]
        public int BytesSent { get; set; }

        [JsonProperty("bytesrecv")]
        public int BytesReceived { get; set; }

        [JsonProperty("conntime")]
        public int ConnectionTime { get; set; }

        [JsonProperty("pingtime")]
        public decimal PingTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("subver")]
        public string SubVersion { get; set; }

        [JsonProperty("inbound")]
        public bool Inbound { get; set; }

        [JsonProperty("startingheight")]
        public int StartingHeight { get; set; }

        [JsonProperty("banscore")]
        public int BanScore { get; set; }

        [JsonProperty("syncnode")]
        public bool SyncNode { get; set; }
    }
}
