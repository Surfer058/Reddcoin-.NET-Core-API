using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Implementation class for verifying the blockchain database.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IVerifyChain" />
    public class VerifyChain : IVerifyChain
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyChain"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public VerifyChain(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the status of the blockhain.
        /// </summary>
        /// <returns>
        /// A <see cref="bool" /> with true is the blockchain is ok, else false.
        /// </returns>
        public async Task<ResponseInfo<bool>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<bool>(RpcType.VerifyChain);
        }

        /// <summary>
        /// Retrieves the status of the blockhain with a certain check level.
        /// </summary>
        /// <param name="checkLevel">The check level 0-4, default is 3.</param>
        /// <returns>
        /// A <see cref="bool" /> with true is the blockchain is ok, else false.
        /// </returns>
        public async Task<ResponseInfo<bool>> Execute(int checkLevel)
        {
            return await _rpcContext.MakeRequestAsync<bool>(RpcType.VerifyChain, checkLevel);
        }

        /// <summary>
        /// Retrieves the status of the blockhain with a certain check level and number of blocks.
        /// </summary>
        /// <param name="checkLevel">The check level 0-4, default is 3.</param>
        /// <param name="numberOfBlocks">The number of blocks, default=6, 0=all.</param>
        /// <returns>
        /// A <see cref="bool" /> with true is the blockchain is ok, else false.
        /// </returns>
        public async Task<ResponseInfo<bool>> Execute(int checkLevel, int numberOfBlocks)
        {
            return await _rpcContext.MakeRequestAsync<bool>(RpcType.VerifyChain, checkLevel, numberOfBlocks);
        }

        #endregion
    }
}
