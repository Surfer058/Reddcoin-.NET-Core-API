using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Class implementation for retrieving the current state of the blockchain.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IGetBlockchainInfo" />
    public class GetBlockchainInfo : IGetBlockchainInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockchainInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetBlockchainInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the current state of the blockchain.
        /// </summary>
        /// <returns>
        /// A <see cref="T:ReddCoinCoreNet.Api.Stores.Response.BlockchainInfoResponse" /> object.
        /// </returns>
        public async Task<ResponseInfo<BlockchainInfoResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<BlockchainInfoResponse>(RpcType.GetBlockchainInfo);
        }

        #endregion
    }
}
