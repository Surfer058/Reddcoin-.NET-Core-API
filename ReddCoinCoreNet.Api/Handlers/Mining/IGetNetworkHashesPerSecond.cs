using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Mining
{
    /// <summary>
    /// Interface for retrieving the estimated network hashes per second based on the number of blocks.
    /// </summary>
    public interface IGetNetworkHashesPerSecond
    {
        /// <summary>
        /// Retrieves the network hashes per second.
        /// </summary>
        /// <param name="block">The number of blocks, or -1 for blocks since last difficulty change.</param>
        /// <param name="height">To estimate at the time of the given height.</param>
        /// <returns>A <see cref="int"/> with the estimated number of hashes per second.</returns>
        Task<ResponseInfo<int>> Execute(int block, int height);
    }
}