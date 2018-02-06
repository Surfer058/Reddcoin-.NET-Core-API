using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class ResponseInfo<T>
    {
        [JsonProperty(PropertyName = "result", Order = 0)]
        public T Result { get; set; }

        [JsonProperty(PropertyName = "id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "error", Order = 2)]
        public string Error { get; set; }
    }
}
