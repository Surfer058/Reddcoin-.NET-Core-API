using System.Collections.Generic;
using Newtonsoft.Json;

namespace ReddCoinCoreNet.Api.Stores.Response
{
    public class BlockResponse
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("confirmations")]
        public int NumberOfConfirmations { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("merkleroot")]
        public string MerkleRoot { get; set; }

        [JsonProperty("tx")]
        public IList<string> Transactions { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("nonce")]
        public int Nonce { get; set; }

        [JsonProperty("bits")]
        public string Bits { get; set; }

        [JsonProperty("difficulty")]
        public decimal Difficulty { get; set; }

        [JsonProperty("chainwork")]
        public string Chainwork { get; set; }

        [JsonProperty("previousblockhash")]
        public string PreviousBlockhash { get; set; }

        [JsonProperty("nextblockhash")]
        public string NextBlockhash { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }

        [JsonProperty("moneysupply")]
        public decimal MoneySupply { get; set; }

        [JsonProperty("mint")]
        public decimal Mint { get; set; }

        [JsonProperty("entropybit")]
        public int Entropybit { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [JsonProperty("modifierchecksum")]
        public string ModifierChecksum { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
    }
}
