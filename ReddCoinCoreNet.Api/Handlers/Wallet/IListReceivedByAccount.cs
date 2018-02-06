using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the total number of Reddcoins received by each account.
    /// </summary>
    public interface IListReceivedByAccount
    {
        /// <summary>
        /// Retrieves the list of account with its total balance.
        /// </summary>
        /// <returns>A collection of <see cref="ReceivedByAccountResponse"/>.</returns>
        Task<ResponseInfo<IList<ReceivedByAccountResponse>>> Execute();

        /// <summary>
        /// Retrieves the list of account with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAccountResponse" />.
        /// </returns>
        Task<ResponseInfo<IList<ReceivedByAccountResponse>>> Execute(int minimumConfirmations);

        /// <summary>
        /// Retrieves the list of account with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <param name="includeEmpty">Whether to include the empty accounts as well.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAccountResponse" />.
        /// </returns>
        Task<ResponseInfo<IList<ReceivedByAccountResponse>>> Execute(int minimumConfirmations, bool includeEmpty);
    }
}