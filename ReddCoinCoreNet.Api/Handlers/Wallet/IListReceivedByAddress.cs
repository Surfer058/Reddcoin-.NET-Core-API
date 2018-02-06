using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the total number of Reddcoins received by each address.
    /// </summary>
    public interface IListReceivedByAddress
    {
        /// <summary>
        /// Retrieves the list of addresses with its total balance.
        /// </summary>
        /// <returns>A collection of <see cref="ReceivedByAddressResponse"/>.</returns>
        Task<ResponseInfo<IList<ReceivedByAddressResponse>>> Execute();

        /// <summary>
        /// Retrieves the list of addresses with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAddressResponse" />.
        /// </returns>
        Task<ResponseInfo<IList<ReceivedByAddressResponse>>> Execute(int minimumConfirmations);

        /// <summary>
        /// Retrieves the list of addresses with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <param name="includeEmpty">Whether to include the empty addresses as well.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAddressResponse" />.
        /// </returns>
        Task<ResponseInfo<IList<ReceivedByAddressResponse>>> Execute(int minimumConfirmations, bool includeEmpty);
    }
}