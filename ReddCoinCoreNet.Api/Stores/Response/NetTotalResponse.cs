using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class NetTotalResponse
    {
        [JsonProperty("totalbytesrecv")]
        public int TotalBytesReceived { get; set; }

        [JsonProperty("totalbytessent")]
        public int TotalBytesSent { get; set; }

        [JsonProperty("timemillis")]
        public long TimeMilliseconds { get; set; }
    }
}
