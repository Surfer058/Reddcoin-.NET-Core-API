using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Network
{
    /// <summary>
    /// Interface for retrieving information about each connected node in the network.
    /// </summary>
    public interface IGetPeerInfo
    {
        /// <summary>
        /// Retrieves the peer information.
        /// </summary>
        /// <returns>A <see cref="IList{PeerInfoResponse}"/> collection.</returns>
        Task<ResponseInfo<IList<PeerInfoResponse>>> Execute();
    }
}