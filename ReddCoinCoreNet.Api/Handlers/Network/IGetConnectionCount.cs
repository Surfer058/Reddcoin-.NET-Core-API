using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Network
{
    /// <summary>
    /// Interface for retrieving the number of connections to other nodes.
    /// </summary>
    public interface IGetConnectionCount
    {
        /// <summary>
        /// Retrieves the number of connections.
        /// </summary>
        /// <returns>A <see cref="int"/> representing the number of connections.</returns>
        Task<ResponseInfo<int>> Execute();
    }
}