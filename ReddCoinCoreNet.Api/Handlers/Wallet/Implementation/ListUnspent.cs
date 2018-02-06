using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the unspent transaction outputs.
    /// </summary>
    /// <remarks>The sum of your unspent transaction outputs can be referenced as your balance.</remarks>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IListUnspent" />
    public class ListUnspent : IListUnspent
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ListUnspent"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ListUnspent(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the unspent transaction outputs.
        /// </summary>
        /// <returns>
        /// A collection of <see cref="UnspentResponse" /> containing the unspent transaction outputs.
        /// </returns>
        public async Task<ResponseInfo<IList<UnspentResponse>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IList<UnspentResponse>>(RpcType.ListUnspent);
        }

        /// <summary>
        /// Retrieves the unspent transaction outputs.
        /// </summary>
        /// <param name="minimumNumberOfConfirmations">The minimum number of confirmations.</param>
        /// <returns>
        /// A collection of <see cref="UnspentResponse" /> containing the unspent transaction outputs.
        /// </returns>
        public async Task<ResponseInfo<IList<UnspentResponse>>> Execute(int minimumNumberOfConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<IList<UnspentResponse>>(RpcType.ListUnspent, minimumNumberOfConfirmations);
        }

        /// <summary>
        /// Retrieves the unspent transaction outputs.
        /// </summary>
        /// <param name="minimumNumberOfConfirmations">The minimum number of confirmations.</param>
        /// <param name="maximumNumberOfConfirmations">The maximum number of confirmations.</param>
        /// <returns>
        /// A collection of <see cref="UnspentResponse" /> containing the unspent transaction outputs.
        /// </returns>
        public async Task<ResponseInfo<IList<UnspentResponse>>> Execute(int minimumNumberOfConfirmations, int maximumNumberOfConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<IList<UnspentResponse>>(RpcType.ListUnspent, minimumNumberOfConfirmations, maximumNumberOfConfirmations);
        }

        #endregion
    }
}
