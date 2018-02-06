using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the hash of the most recent block on the best block chain.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IGetBestBlockhash" />
    public class GetBestBlockhash : IGetBestBlockhash
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBestBlockhash"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetBestBlockhash(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the hash.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> containing the hash.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.GetBestBlockhash);
        }

        #endregion
    }
}
