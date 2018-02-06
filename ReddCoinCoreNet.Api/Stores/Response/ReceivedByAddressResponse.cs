using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class ReceivedByAddressResponse
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("confirmations")]
        public int NumberOfConfirmations { get; set; }

        [JsonProperty("txids")]
        public IList<string> TransactionIdentifiers { get; set; }
    }
}
