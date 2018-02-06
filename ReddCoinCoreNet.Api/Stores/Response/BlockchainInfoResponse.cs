using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class BlockchainInfoResponse
    {
        [JsonProperty("chain")]
        public string Chain { get; set; }

        [JsonProperty("blocks")]
        public int Blocks { get; set; }

        [JsonProperty("bestblockhash")]
        public string BestBlockhash { get; set; }

        [JsonProperty("difficulty")]
        public decimal Difficulty { get; set; }

        [JsonProperty("verificationprogress")]
        public decimal VerificationProgress { get; set; }

        [JsonProperty("chainwork")]
        public string ChainWork { get; set; }
    }
}
