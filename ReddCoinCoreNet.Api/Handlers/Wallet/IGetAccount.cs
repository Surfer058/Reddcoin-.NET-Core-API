using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the account name attached to a certain address.
    /// </summary>
    public interface IGetAccount
    {
        /// <summary>
        /// Retrieves the account name.
        /// </summary>
        /// <param name="address">The address (public key).</param>
        /// <returns>A <see cref="string"/> with the name of the account.</returns>
        Task<ResponseInfo<string>> Execute(string address);
    }
}