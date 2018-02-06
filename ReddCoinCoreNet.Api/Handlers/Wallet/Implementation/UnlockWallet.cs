using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for unlocking the wallet.
    /// Technically stores the wallet decryption key in memory for a certain time of seconds (timeout).
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IUnlockWallet" />
    public class UnlockWallet : IUnlockWallet
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockWallet"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public UnlockWallet(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Unlocks the wallet.
        /// </summary>
        /// <param name="passphrase">The passphrase of the wallet.</param>
        /// <param name="timeout">The amount of second the wallet is unlocked.</param>
        /// <returns>A <see cref="object"/> with value Null.</returns>
        public async Task<ResponseInfo<object>> Execute(string passphrase, int timeout)
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.WalletPassPhrase, passphrase, timeout);
        }

        /// <summary>
        /// Unlocks the wallet.
        /// </summary>
        /// <param name="passphrase">The passphrase of the wallet.</param>
        /// <param name="timeout">The amount of second the wallet is unlocked.</param>
        /// <param name="stakeonly">If set to <c>true</c> opens the wallet only for stacking, else <c>false</c>.</param>
        /// <returns>A <see cref="object"/> with value Null.</returns>
        public async Task<ResponseInfo<object>> Execute(string passphrase, int timeout, bool stakeonly)
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.WalletPassPhrase, passphrase, timeout, stakeonly);
        }

        #endregion
    }
}
