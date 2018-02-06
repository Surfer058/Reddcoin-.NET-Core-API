using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for listing the accounts with corresponding balance.
    /// </summary>
    public interface IListAccounts
    {
        /// <summary>
        /// Retrieves the whole list of account with their balance.
        /// </summary>
        /// <returns>A <see cref="IDictionary{TKey,TValue}"/>, where Key is the name of the account and Value the balance.</returns>
        Task<ResponseInfo<IDictionary<string, decimal>>> Execute();
        /// <summary>
        /// Retrieves the whole list of account with their balance with a minimum number of confirmations.
        /// </summary>
        /// <param name="minimumAmountOfConfirmations">The minimum amount of confirmations.</param>
        /// <returns>A <see cref="IDictionary{TKey,TValue}"/>, where Key is the name of the account and Value the balance.</returns>
        Task<ResponseInfo<IDictionary<string, decimal>>> Execute(int minimumAmountOfConfirmations);
    }
}