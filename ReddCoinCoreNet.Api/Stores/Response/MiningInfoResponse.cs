using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class MiningInfoResponse
    {
        [JsonProperty("blocks")]
        public int NumberOfBlocks { get; set; }

        [JsonProperty("currentblocksize")]
        public int CurrentBlockSize { get; set; }

        [JsonProperty("currentblocktx")]
        public int CurrentBlockTransaction { get; set; }

        [JsonProperty("difficulty")]
        public decimal Difficulty { get; set; }

        [JsonProperty("errors")]
        public string Errors { get; set; }

        [JsonProperty("genproclimit")]
        public int GenProcLimit { get; set; }

        [JsonProperty("networkhashps")]
        public int NetworkHashps { get; set; }

        [JsonProperty("pooledtx")]
        public int PooledTransaction { get; set; }

        [JsonProperty("testnet")]
        public bool TestNet { get; set; }

        [JsonProperty("generate")]
        public bool Generate { get; set; }

        [JsonProperty("hashespersec")]
        public int HashesPerSec { get; set; }

        [JsonProperty("stakeweight")]
        public StakeWeightResponse StakeWeight { get; set; }

        [JsonProperty("stakeinterest")]
        public int StakeInterest { get; set; }

        [JsonProperty("netstakeweight")]
        public long NetStakeWeight { get; set; }
    }
}
