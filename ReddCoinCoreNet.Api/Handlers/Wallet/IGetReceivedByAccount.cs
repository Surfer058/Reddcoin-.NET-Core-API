using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the total amount of Reddcoins by the provided account name.
    /// </summary>
    public interface IGetReceivedByAccount
    {
        /// <summary>
        /// Retrieves the recieved amount of Reddcoins.
        /// </summary>
        /// <param name="accountName">The account name.</param>
        /// <returns>A <see cref="decimal"/> with the total amount of received Reddcoins.</returns>
        Task<ResponseInfo<decimal>> Execute(string accountName);

        /// <summary>
        /// Retrieves the recieved amount of Reddcoins with a minimum number of confirmations.
        /// </summary>
        /// <param name="accountName">The account name.</param>
        /// <param name="minimumConfirmation">The minimum number of confirmations.</param>
        /// <returns>A <see cref="decimal"/> with the total amount of received Reddcoins.</returns>
        Task<ResponseInfo<decimal>> Execute(string accountName, int minimumConfirmation);
    }
}