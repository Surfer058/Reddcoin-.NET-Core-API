using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the account name attached to a certain address.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetAccount" />
    public class GetAccount : IGetAccount
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccount"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetAccount(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the account name.
        /// </summary>
        /// <param name="address">The address (public key).</param>
        /// <returns>
        /// A <see cref="string" /> with the name of the account.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute(string address)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.GetAccount, address);
        }

        #endregion
    }
}
