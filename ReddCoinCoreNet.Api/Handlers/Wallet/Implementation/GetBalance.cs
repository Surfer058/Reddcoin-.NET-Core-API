using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Class implementation for retrieving the balance within a wallet.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetBalance" />
    public class GetBalance : IGetBalance
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalance"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetBalance(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the total balance within the wallet.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Decimal" /> amount.
        /// </returns>
        public async Task<ResponseInfo<decimal>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetBalance);
        }

        /// <summary>
        /// Retrieves the total balance of an account within the wallet.
        /// </summary>
        /// <param name="account">The account name (also named label within Reddcoin Core - Wallet).</param>
        /// <returns>
        /// A <see cref="T:System.Decimal" /> amount.
        /// </returns>
        /// <remarks>
        /// When an unknown account name is given, 0 will be returned.
        /// </remarks>
        public async Task<ResponseInfo<decimal>> Execute(string account)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetBalance, account);
        }

        /// <summary>
        /// Retrieves the total balance of an account within the wallet with a minimum number of confirmations.
        /// </summary>
        /// <param name="account">The account name (also named label within Reddcoin Core - Wallet).</param>
        /// <param name="minimumAmountOfConfirmations">The minimum amount of confirmations.</param>
        /// <returns>
        /// A <see cref="T:System.Decimal" /> amount.
        /// </returns>
        /// <remarks>
        /// When an unknown account name is given, 0 will be returned.
        /// </remarks>
        public async Task<ResponseInfo<decimal>> Execute(string account, int minimumAmountOfConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetBalance, account, minimumAmountOfConfirmations);
        }

        #endregion
    }
}
