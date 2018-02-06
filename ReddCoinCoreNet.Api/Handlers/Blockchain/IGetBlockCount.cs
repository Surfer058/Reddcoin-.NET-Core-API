using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for retrieving the number of blocks in the local best block chain.
    /// </summary>
    public interface IGetBlockCount
    {
        /// <summary>
        /// Retrieves the number of blocks.
        /// </summary>
        /// <returns>A <see cref="int"/> containig the number of blocks.</returns>
        Task<ResponseInfo<int>> Execute();
    }
}