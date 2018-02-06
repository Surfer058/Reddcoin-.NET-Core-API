using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for sending Reddcoins to a specified address.
    /// </summary>
    /// <remarks>
    /// Before being able to send Reddcoins, the wallet needs to be unlocked with the option StackOnly = false.
    /// Unlocking the wallet can be done with <see cref="IUnlockWallet"/> implementation.
    /// The comments passed through will only be stored in your own wallet and will not become part of the blockchain.
    /// </remarks>
    public interface ISendReddcoinsToAddress
    {
        /// <summary>
        /// Sends Reddcoins to a specified address.
        /// </summary>
        /// <param name="recipientAddress">The recipient address to send to.</param>
        /// <param name="amount">The amount of Reddcoins to send.</param>
        /// <returns>A <see cref="string"/> containing the transaction identifier.</returns>
        Task<ResponseInfo<string>> Execute(string recipientAddress, decimal amount);
        /// <summary>
        /// Sends Reddcoins to a specified address.
        /// </summary>
        /// <param name="recipientAddress">The recipient address to send to.</param>
        /// <param name="amount">The amount of Reddcoins to send.</param>
        /// <param name="comment">A comment used to locally store what the transaction is for.</param>
        /// <returns>
        /// A <see cref="string" /> containing the transaction identifier.
        /// </returns>
        Task<ResponseInfo<string>> Execute(string recipientAddress, decimal amount, string comment);
        /// <summary>
        /// Sends Reddcoins to a specified address.
        /// </summary>
        /// <param name="recipientAddress">The recipient address to send to.</param>
        /// <param name="amount">The amount of Reddcoins to send.</param>
        /// <param name="comment">A comment used to locally store what the transaction is for.</param>
        /// <param name="commentTo">A comment to locally store the name of the person or organization to which you're sending the transaction.</param>
        /// <returns>
        /// A <see cref="string" /> containing the transaction identifier.
        /// </returns>
        Task<ResponseInfo<string>> Execute(string recipientAddress, decimal amount, string comment, string commentTo);
    }
}