using ReddCoinCoreNet.Api.Stores.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the transactions in from the wallet.
    /// </summary>
    public interface IListTransactions
    {
        /// <summary>
        /// Retrieves all transactions.
        /// </summary>
        /// <returns>A <see cref="IList{TransactionsResponse}"/> collection.</returns>
        Task<ResponseInfo<IList<TransactionsResponse>>> Execute();
        /// <summary>
        /// Retrieves transaction by the specified account.
        /// </summary>
        /// <param name="account">The account name.</param>
        /// <returns>A <see cref="IList{TransactionsResponse}"/> collection.</returns>
        Task<ResponseInfo<IList<TransactionsResponse>>> Execute(string account);
        /// <summary>
        /// Retrieves transaction by the specified account.
        /// </summary>
        /// <param name="account">The account name.</param>
        /// <param name="count">The number of latest transaction.</param>
        /// <returns>A <see cref="IList{TransactionsResponse}"/> collection.</returns>
        Task<ResponseInfo<IList<TransactionsResponse>>> Execute(string account, int count);
        /// <summary>
        /// Retrieves transaction by the specified account.
        /// </summary>
        /// <param name="account">The account name.</param>
        /// <param name="count">The number of latest transaction.</param>
        /// <param name="from">The number to start from.</param>
        /// <returns>A <see cref="IList{TransactionsResponse}"/> collection.</returns>
        /// <remarks>This method can be used to paging.</remarks>
        Task<ResponseInfo<IList<TransactionsResponse>>> Execute(string account, int count, int from);
    }
}