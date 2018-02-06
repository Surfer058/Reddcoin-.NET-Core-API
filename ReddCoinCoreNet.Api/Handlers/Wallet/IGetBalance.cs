using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the balance within a wallet.
    /// </summary>
    public interface IGetBalance
    {
        /// <summary>
        /// Retrieves the total balance within the wallet.
        /// </summary>
        /// <returns>A <see cref="decimal"/> amount.</returns>
        Task<ResponseInfo<decimal>> Execute();
        /// <summary>
        /// Retrieves the total balance of an account within the wallet.
        /// </summary>
        /// <param name="account">The account name (also named label within Reddcoin Core - Wallet).</param>
        /// <returns>A <see cref="decimal"/> amount.</returns>
        /// <remarks>When an unknown account name is given, 0 will be returned.</remarks>
        Task<ResponseInfo<decimal>> Execute(string account);
        /// <summary>
        /// Retrieves the total balance of an account within the wallet with a minimum number of confirmations.
        /// </summary>
        /// <param name="account">The account name (also named label within Reddcoin Core - Wallet).</param>
        /// <param name="minimumAmountOfConfirmations">The minimum amount of confirmations.</param>
        /// <returns>A <see cref="decimal"/> amount.</returns>
        /// <remarks>When an unknown account name is given, 0 will be returned.</remarks>
        Task<ResponseInfo<decimal>> Execute(string account, int minimumAmountOfConfirmations);
    }
}
