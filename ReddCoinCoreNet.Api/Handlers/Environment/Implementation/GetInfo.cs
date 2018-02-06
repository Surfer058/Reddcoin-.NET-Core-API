using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Environment.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the current state of the Reddcoin wallet.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Environment.IGetInfo" />
    public class GetInfo : IGetInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        /// <summary>
        /// Retrieves the current state of the wallet.
        /// </summary>
        /// <returns>
        /// A <see cref="T:ReddCoinCoreNet.Api.Stores.Response.InfoResponse" /> object.
        /// </returns>
        public async Task<ResponseInfo<InfoResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<InfoResponse>(RpcType.GetInfo);
        }
    }
}
