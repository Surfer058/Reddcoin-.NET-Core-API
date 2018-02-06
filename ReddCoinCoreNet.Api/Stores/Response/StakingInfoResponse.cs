using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class StakingInfoResponse
    {
        [JsonProperty("enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("staking")]
        public bool IsStaking { get; set; }

        [JsonProperty("currentblocksize")]
        public int CurrentBlockSize { get; set; }

        [JsonProperty("currentblocktx")]
        public int CurrentBlockTransaction { get; set; }

        [JsonProperty("pooledtx")]
        public int PooledTransaction { get; set; }

        [JsonProperty("difficulty")]
        public decimal Difficulty { get; set; }

        [JsonProperty("search-interval")]
        public int SearchInterval { get; set; }

        [JsonProperty("averageweight")]
        public int AverageWeight { get; set; }

        [JsonProperty("totalweight")]
        public int TotalWeight { get; set; }

        [JsonProperty("netstakeweight")]
        public long NetStakeWeight { get; set; }

        [JsonProperty("expectedtime")]
        public long ExpectedTimeInSeconds { get; set; }
    }
}
