using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the transactions in from the wallet.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IListTransactions" />
    public class ListTransactions : IListTransactions
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactions"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ListTransactions(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves als transactions.
        /// </summary>
        /// <returns>
        /// A <see cref="IList{TransactionsResponse}"/> collection.
        /// </returns>
        public async Task<ResponseInfo<IList<TransactionsResponse>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IList<TransactionsResponse>>(RpcType.ListTransactions);
        }

        /// <summary>
        /// Retrieves transaction by the specified account.
        /// </summary>
        /// <param name="account">The account name.</param>
        /// <returns>
        /// A <see cref="IList{TransactionsResponse}"/> collection.
        /// </returns>
        public async Task<ResponseInfo<IList<TransactionsResponse>>> Execute(string account)
        {
            return await _rpcContext.MakeRequestAsync<IList<TransactionsResponse>>(RpcType.ListTransactions, account);
        }

        /// <summary>
        /// Retrieves transaction by the specified account.
        /// </summary>
        /// <param name="account">The account name.</param>
        /// <param name="count">The number of latest transaction.</param>
        /// <returns>
        /// A <see cref="IList{TransactionsResponse}"/> collection.
        /// </returns>
        public async Task<ResponseInfo<IList<TransactionsResponse>>> Execute(string account, int count)
        {
            return await _rpcContext.MakeRequestAsync<IList<TransactionsResponse>>(RpcType.ListTransactions, account, count);
        }

        /// <summary>
        /// Retrieves transaction by the specified account.
        /// </summary>
        /// <param name="account">The account name.</param>
        /// <param name="count">The number of latest transaction.</param>
        /// <param name="from">The number to start from.</param>
        /// <returns>
        /// A <see cref="IList{TransactionsResponse}"/> collection.
        /// </returns>
        /// <remarks>
        /// This method can be used to paging.
        /// </remarks>
        public async Task<ResponseInfo<IList<TransactionsResponse>>> Execute(string account, int count, int from)
        {
            return await _rpcContext.MakeRequestAsync<IList<TransactionsResponse>>(RpcType.ListTransactions, account, count, from);
        }

        #endregion
    }
}
