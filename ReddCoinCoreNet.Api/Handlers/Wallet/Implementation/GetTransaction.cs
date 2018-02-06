using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the transaction information by its identifier.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetTransaction" />
    public class GetTransaction : IGetTransaction
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransaction"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetTransaction(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the transaction information.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>
        /// A <see cref="TransactionResponse" /> object containing the transaction information.
        /// </returns>
        public async Task<ResponseInfo<TransactionResponse>> Execute(string transactionId)
        {
            return await _rpcContext.MakeRequestAsync<TransactionResponse>(RpcType.GetTransaction, transactionId);
        }

        #endregion
    }
}
