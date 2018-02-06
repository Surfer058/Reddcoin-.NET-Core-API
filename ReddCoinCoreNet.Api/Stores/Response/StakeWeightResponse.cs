using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class StakeWeightResponse
    {
        [JsonProperty("average")]
        public int Average { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
