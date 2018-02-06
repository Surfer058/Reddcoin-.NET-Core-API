using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for setting the account name for the specifiek address.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.ISetAccount" />
    public class SetAccount : ISetAccount
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccount"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public SetAccount(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Sets the account name for the specified address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="account">The account name.</param>
        /// <returns>
        /// An <see cref="object" /> with value null.
        /// </returns>
        public async Task<ResponseInfo<object>> Execute(string address, string account)
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.SetAccount, address, account);
        }

        #endregion
    }
}
