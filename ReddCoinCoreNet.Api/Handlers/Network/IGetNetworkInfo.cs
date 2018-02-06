using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Network
{
    /// <summary>
    /// Interface for retrieving information about the node's/wallet connection to the network.
    /// </summary>
    public interface IGetNetworkInfo
    {
        /// <summary>
        /// Retrieving the network information.
        /// </summary>
        /// <returns>A <see cref="NetworkInfoResponse"/> object.</returns>
        Task<ResponseInfo<NetworkInfoResponse>> Execute();
    }
}