using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving a list of adresses (public keys) by its account name.
    /// </summary>
    public interface IGetAccountAddresses
    {
        /// <summary>
        /// Retrieves a list of addresses.
        /// </summary>
        /// <param name="accountName">The account name.</param>
        /// <returns>A collection of <see cref="string"/> containing the addresses.</returns>
        Task<ResponseInfo<IList<string>>> Execute(string accountName);
    }
}