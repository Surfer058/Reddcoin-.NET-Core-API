using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the header hash of a block at the given height in the local best block chain.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IGetBlockHash" />
    public class GetBlockHash : IGetBlockHash
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockHash"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetBlockHash(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the block hash.
        /// </summary>
        /// <param name="blockHeight">Height of the block.</param>
        /// <returns>
        /// A <see cref="string" /> containing the block hash.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute(int blockHeight)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.GetBlockHash, blockHeight);
        }

        #endregion
    }
}