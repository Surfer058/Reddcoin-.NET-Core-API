using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Network.Implementation
{
    /// <summary>
    /// Implementation class for retrieving information about each connected node in the network.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Network.IGetPeerInfo" />
    public class GetPeerInfo : IGetPeerInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPeerInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetPeerInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the peer information.
        /// </summary>
        /// <returns>
        /// A <see cref="IList{PeerInfoResponse}"/> collection.
        /// </returns>
        public async Task<ResponseInfo<IList<PeerInfoResponse>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IList<PeerInfoResponse>>(RpcType.GetPeerInfo);
        }

        #endregion
    }
}
