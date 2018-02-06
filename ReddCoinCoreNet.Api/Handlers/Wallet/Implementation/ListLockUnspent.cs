using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving a list of locked unspent outputs.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IListLockUnspent" />
    public class ListLockUnspent : IListLockUnspent
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLockUnspent"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ListLockUnspent(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the locked unspent outputs.
        /// </summary>
        /// <returns>
        /// An <see cref="object" />.
        /// </returns>
        public async Task<ResponseInfo<object>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.ListLockUnspent);
        }

        #endregion
    }
}
