using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for unlocking the wallet.
    /// Technically stores the wallet decryption key in memory for a certain time of seconds (timeout).
    /// </summary>
    public interface IUnlockWallet
    {
        /// <summary>
        /// Unlocks the wallet.
        /// </summary>
        /// <param name="passphrase">The passphrase of the wallet.</param>
        /// <param name="timeout">The amount of second the wallet is unlocked.</param>
        /// <returns>A <see cref="object"/> with value Null.</returns>
        Task<ResponseInfo<object>> Execute(string passphrase, int timeout);

        /// <summary>
        /// Unlocks the wallet.
        /// </summary>
        /// <param name="passphrase">The passphrase of the wallet.</param>
        /// <param name="timeout">The amount of second the wallet is unlocked.</param>
        /// <param name="stakeonly">If set to <c>true</c> opens the wallet only for stacking, else <c>false</c>.</param>
        /// <returns>A <see cref="object"/> with value Null.</returns>
        Task<ResponseInfo<object>> Execute(string passphrase, int timeout, bool stakeonly);
    }
}