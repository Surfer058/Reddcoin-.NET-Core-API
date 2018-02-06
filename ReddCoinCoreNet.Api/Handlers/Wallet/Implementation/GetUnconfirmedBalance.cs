using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the unconfirmed balance within the wallet.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetUnconfirmedBalance" />
    public class GetUnconfirmedBalance : IGetUnconfirmedBalance
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnconfirmedBalance"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetUnconfirmedBalance(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the unconfirmed balance.
        /// </summary>
        /// <returns>
        /// A <see cref="decimal" /> respresenting the unconfirmed balance.
        /// </returns>
        public async Task<ResponseInfo<decimal>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetUnconfirmedBalance);
        }

        #endregion
    }
}
