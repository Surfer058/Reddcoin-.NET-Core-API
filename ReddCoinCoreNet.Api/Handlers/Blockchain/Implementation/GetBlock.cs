using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Implementation class for retrieving a block with a particular header hash from the local block database.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IGetBlock" />
    public class GetBlock : IGetBlock
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlock"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetBlock(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the block.
        /// </summary>
        /// <param name="hash">The hash.</param>
        /// <returns>
        /// A <see cref="BlockResponse" /> containing the block information.
        /// </returns>
        public async Task<ResponseInfo<BlockResponse>> Execute(string hash)
        {
            return await _rpcContext.MakeRequestAsync<BlockResponse>(RpcType.GetBlock, hash);
        }

        #endregion
    }
}
