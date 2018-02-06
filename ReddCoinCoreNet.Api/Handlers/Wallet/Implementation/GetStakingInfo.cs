using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the staking information.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetStakingInfo" />
    public class GetStakingInfo : IGetStakingInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStakingInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetStakingInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the staking information.
        /// </summary>
        /// <returns>
        /// A <see cref="T:ReddCoinCoreNet.Api.Stores.Response.StakingInfoResponse" /> object.
        /// </returns>
        public async Task<ResponseInfo<StakingInfoResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<StakingInfoResponse>(RpcType.GetStakingInfo);
        }

        #endregion
    }
}
