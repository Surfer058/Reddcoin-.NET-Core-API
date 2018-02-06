using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Mining.Implementation
{
    /// <summary>
    /// Implementation class for retrieving mining and stake information.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Mining.IGetMiningInfo" />
    public class GetMiningInfo : IGetMiningInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMiningInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetMiningInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the mining information.
        /// </summary>
        /// <returns>
        /// A <see cref="T:ReddCoinCoreNet.Api.Stores.Response.MiningInfoResponse" /> object.
        /// </returns>
        public async Task<ResponseInfo<MiningInfoResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<MiningInfoResponse>(RpcType.GetMiningInfo);
        }

        #endregion
    }
}
