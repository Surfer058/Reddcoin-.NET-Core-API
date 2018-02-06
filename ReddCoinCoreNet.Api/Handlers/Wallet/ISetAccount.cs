using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for setting the account name for the specifiek address.
    /// </summary>
    public interface ISetAccount
    {
        /// <summary>
        /// Sets the account name for the specified address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="account">The account name.</param>
        /// <returns>An <see cref="object"/> with value null.</returns>
        Task<ResponseInfo<object>> Execute(string address, string account);
    }
}