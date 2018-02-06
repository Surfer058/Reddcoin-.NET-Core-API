using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the number of blocks in the local best block chain.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IGetBlockCount" />
    public class GetBlockCount : IGetBlockCount
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockCount"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetBlockCount(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the number of blocks.
        /// </summary>
        /// <returns>
        /// A <see cref="int" /> containig the number of blocks.
        /// </returns>
        public async Task<ResponseInfo<int>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<int>(RpcType.GetBlockCount);
        }

        #endregion
    }
}
