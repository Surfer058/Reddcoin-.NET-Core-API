using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Network.Implementation
{
    /// <summary>
    /// Implemenation class for retrieving the network information.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Network.IGetNetTotals" />
    public class GetNetTotals : IGetNetTotals
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNetTotals"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetNetTotals(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        /// <summary>
        /// Retrieves the network totals.
        /// </summary>
        /// <returns>
        /// A <see cref="T:ReddCoinCoreNet.Api.Stores.Response.NetTotalResponse" /> object.
        /// </returns>
        public async Task<ResponseInfo<NetTotalResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<NetTotalResponse>(RpcType.GetNetTotals);
        }
    }
}
