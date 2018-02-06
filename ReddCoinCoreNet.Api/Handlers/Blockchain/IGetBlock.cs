using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for retrieving a block with a particular header hash from the local block database.
    /// </summary>
    public interface IGetBlock
    {
        /// <summary>
        /// Retrieves the block.
        /// </summary>
        /// <param name="hash">The hash.</param>
        /// <returns>A <see cref="BlockResponse"/> containing the block information.</returns>
        Task<ResponseInfo<BlockResponse>> Execute(string hash);
    }
}