using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving a hex-encoded transaction describing the transaction.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetRawTransaction" />
    public class GetRawTransaction : IGetRawTransaction
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRawTransaction"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetRawTransaction(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves a hex-encoded value of a transaction.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>
        /// A hex-encoded <see cref="string" />.
        /// </returns>
        public async Task<ResponseInfo<RawTransactionResponse>> Execute(string transactionId)
        {
            return await _rpcContext.MakeRequestAsync<RawTransactionResponse>(RpcType.GetRawTransaction, transactionId, 1);
        }

        #endregion
    }
}
