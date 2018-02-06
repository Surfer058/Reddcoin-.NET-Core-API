using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implemenation class for changing the wallet its passphrase.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IChangeWalletPasswordPhrase" />
    public class ChangeWalletPasswordPhrase : IChangeWalletPasswordPhrase
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeWalletPasswordPhrase"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ChangeWalletPasswordPhrase(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Executes the specified old password.
        /// </summary>
        /// <param name="oldPassPhrase">The old passphrase.</param>
        /// <param name="newPassPhrase">The new passphrase.</param>
        /// <returns>
        /// An <see cref="object" /> with value null.
        /// </returns>
        public async Task<ResponseInfo<object>> Execute(string oldPassPhrase, string newPassPhrase)
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.WalletPassPhraseChange, oldPassPhrase, newPassPhrase);
        }

        #endregion
    }
}
