using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the total amount of Reddcoins by the provided address.
    /// </summary>
    public interface IGetReceivedByAddress
    {
        /// <summary>
        /// Retrieves the recieved amount of Reddcoins.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>A <see cref="decimal"/> with the total amount of received Reddcoins.</returns>
        Task<ResponseInfo<decimal>> Execute(string address);

        /// <summary>
        /// Retrieves the recieved amount of Reddcoins with a minimum number of confirmations.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="minimumConfirmation">The minimum number of confirmations.</param>
        /// <returns>A <see cref="decimal"/> with the total amount of received Reddcoins.</returns>
        Task<ResponseInfo<decimal>> Execute(string address, int minimumConfirmation);
    }
}