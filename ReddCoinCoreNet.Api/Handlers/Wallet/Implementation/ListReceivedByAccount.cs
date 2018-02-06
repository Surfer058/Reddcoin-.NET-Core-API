using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the total number of Reddcoins received by each account.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IListReceivedByAccount" />
    public class ListReceivedByAccount : IListReceivedByAccount
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReceivedByAccount"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ListReceivedByAccount(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the list of account with its total balance.
        /// </summary>
        /// <returns>
        /// A collection of <see cref="ReceivedByAccountResponse" />.
        /// </returns>
        public async Task<ResponseInfo<IList<ReceivedByAccountResponse>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IList<ReceivedByAccountResponse>>(RpcType.ListReceivedByAccount);
        }

        /// <summary>
        /// Retrieves the list of account with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAccountResponse" />.
        /// </returns>
        public async Task<ResponseInfo<IList<ReceivedByAccountResponse>>> Execute(int minimumConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<IList<ReceivedByAccountResponse>>(RpcType.ListReceivedByAccount, minimumConfirmations);
        }

        /// <summary>
        /// Retrieves the list of account with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <param name="includeEmpty">Whether to include the empty accounts as well.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAccountResponse" />.
        /// </returns>
        public async Task<ResponseInfo<IList<ReceivedByAccountResponse>>> Execute(int minimumConfirmations, bool includeEmpty)
        {
            return await _rpcContext.MakeRequestAsync<IList<ReceivedByAccountResponse>>(RpcType.ListReceivedByAccount, minimumConfirmations, includeEmpty);
        }

        #endregion
    }
}
