using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving wallet information like balance, number of transactions and version.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetWalletInfo" />
    public class GetWalletInfo : IGetWalletInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetWalletInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the wallet information.
        /// </summary>
        /// <returns>
        /// A <see cref="WalletResponse"/> object.
        /// </returns>
        public async Task<ResponseInfo<WalletResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<WalletResponse>(RpcType.GetWalletInfo);
        }

        #endregion
    }
}
