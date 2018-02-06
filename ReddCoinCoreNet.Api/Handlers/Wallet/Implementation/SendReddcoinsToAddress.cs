using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for sending Reddcoins to a specified address.
    /// </summary>
    /// <remarks>
    /// Before being able to send Reddcoins, the wallet needs to be unlocked with the option StackOnly = false.
    /// Unlocking the wallet can be done with <see cref="IUnlockWallet"/> implementation.
    /// The comments passed through will only be stored in your own wallet and will not become part of the blockchain.
    /// </remarks>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.ISendReddcoinsToAddress" />
    public class SendReddcoinsToAddress : ISendReddcoinsToAddress
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SendReddcoinsToAddress"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public SendReddcoinsToAddress(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Sends Reddcoins to a specified address.
        /// </summary>
        /// <param name="recipientAddress">The recipient address to send to.</param>
        /// <param name="amount">The amount of Reddcoins to send.</param>
        /// <returns>
        /// A <see cref="string" /> containing the transaction identifier.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute(string recipientAddress, decimal amount)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.SendToAddress, recipientAddress, amount);
        }

        /// <summary>
        /// Sends Reddcoins to a specified address.
        /// </summary>
        /// <param name="recipientAddress">The recipient address to send to.</param>
        /// <param name="amount">The amount of Reddcoins to send.</param>
        /// <param name="comment">A comment used to locally store what the transaction is for.</param>
        /// <returns>
        /// A <see cref="string" /> containing the transaction identifier.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute(string recipientAddress, decimal amount, string comment)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.SendToAddress, recipientAddress, amount, comment);
        }

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
        public async Task<ResponseInfo<string>> Execute(string recipientAddress, decimal amount, string comment, string commentTo)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.SendToAddress, recipientAddress, amount, comment, commentTo);
        }

        #endregion
    }
}
