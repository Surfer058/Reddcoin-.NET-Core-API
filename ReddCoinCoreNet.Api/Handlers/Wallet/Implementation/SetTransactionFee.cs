using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for setting the transaction fee per KiloByte paid by transactions created by this wallet.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.ISetTransactionFee" />
    public class SetTransactionFee : ISetTransactionFee
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTransactionFee"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public SetTransactionFee(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Sets the transactions fee.
        /// </summary>
        /// <param name="amount">The transaction fee in RDD/KB.</param>
        /// <returns>
        /// True if set succesful, else false.
        /// </returns>
        public async Task<ResponseInfo<bool>> Execute(decimal amount)
        {
            return await _rpcContext.MakeRequestAsync<bool>(RpcType.SetTxFee, amount);
        }

        #endregion
    }
}
