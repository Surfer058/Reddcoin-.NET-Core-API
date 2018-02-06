using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for changing the wallet its passphrase.
    /// </summary>
    public interface IChangeWalletPasswordPhrase
    {
        /// <summary>
        /// Executes the specified old password.
        /// </summary>
        /// <param name="oldPassPhrase">The old passphrase.</param>
        /// <param name="newPassPhrase">The new passphrase.</param>
        /// <returns>An <see cref="object"/> with value null.</returns>
        Task<ResponseInfo<object>> Execute(string oldPassPhrase, string newPassPhrase);
    }
}