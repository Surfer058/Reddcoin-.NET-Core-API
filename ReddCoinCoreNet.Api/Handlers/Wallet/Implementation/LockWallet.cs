using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for locking the wallet.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.ILockWallet" />
    public class LockWallet : ILockWallet
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LockWallet"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public LockWallet(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Locks the wallet.
        /// </summary>
        /// <returns>
        /// A <see cref="object" /> with value Null.
        /// </returns>
        public async Task<ResponseInfo<object>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.WalletLock);
        }

        #endregion
    }
}
