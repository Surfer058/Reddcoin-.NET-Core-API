using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Network.Implementation
{
    /// <summary>
    /// Implemenation class for retrieving information about the node's/wallet connection to the network.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Network.IGetNetworkInfo" />
    public class GetNetworkInfo : IGetNetworkInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNetworkInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetNetworkInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieving the network information.
        /// </summary>
        /// <returns>
        /// A <see cref="T:ReddCoinCoreNet.Api.Stores.Response.NetworkInfoResponse" /> object.
        /// </returns>
        public async Task<ResponseInfo<NetworkInfoResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<NetworkInfoResponse>(RpcType.GetNetworkInfo);
        }

        #endregion
    }
}
