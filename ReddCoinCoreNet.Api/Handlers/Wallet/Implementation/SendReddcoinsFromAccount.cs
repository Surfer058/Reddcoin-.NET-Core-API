using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for sending Reddcoins to a specified address from a certain account.
    /// </summary>
    /// <remarks>
    /// Before being able to send Reddcoins, the wallet needs to be unlocked with the option StackOnly = false.
    /// Unlocking the wallet can be done with <see cref="IUnlockWallet"/> implementation.
    /// The comments passed through will only be stored in your own wallet and will not become part of the blockchain.
    /// </remarks>
    public class SendReddcoinsFromAccount : ISendReddcoinsFromAccount
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SendReddcoinsFromAccount"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public SendReddcoinsFromAccount(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Sends Reddcoins to a specified address.
        /// </summary>
        /// <param name="fromAccount">From account.</param>
        /// <param name="recipientAddress">The recipient address to send to.</param>
        /// <param name="amount">The amount of Reddcoins to send.</param>
        /// <param name="minimumNumberOfConfirmations">The minimum number of confirmations.</param>
        /// <param name="comment">A comment used to locally store what the transaction is for.</param>
        /// <param name="toComment">To comment.</param>
        /// <returns>
        /// A <see cref="string" /> containing the transaction identifier.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute(string fromAccount, string recipientAddress, decimal amount,
                                                        int minimumNumberOfConfirmations, string comment, string toComment)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.SendFrom, fromAccount, recipientAddress, amount,
                                                              minimumNumberOfConfirmations, comment, toComment);
        }

        #endregion
    }
}
