using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for retrieving the header hash of a block at the given height in the local best block chain.
    /// </summary>
    public interface IGetBlockHash
    {
        /// <summary>
        /// Retrieves the block hash.
        /// </summary>
        /// <param name="blockHeight">Height of the block.</param>
        /// <returns>A <see cref="string"/> containing the block hash.</returns>
        Task<ResponseInfo<string>> Execute(int blockHeight);
    }
}