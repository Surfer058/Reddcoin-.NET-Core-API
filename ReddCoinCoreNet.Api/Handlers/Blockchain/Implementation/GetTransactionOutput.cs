using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the details of an unspent transaction.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IGetTransactionOutput" />
    public class GetTransactionOutput : IGetTransactionOutput
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionOutput"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetTransactionOutput(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the transaction details.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="voutNumber">The vout number.</param>
        /// <param name="includeMemoryPool"><see cref="bool" /> indicating to include the memory pool, default is true.</param>
        /// <returns>
        /// A <see cref="TransactionOutputResponse" /> object containing transaction details.
        /// </returns>
        public async Task<ResponseInfo<TransactionOutputResponse>> Execute(string transactionId, int voutNumber, bool includeMemoryPool)
        {
            return await _rpcContext.MakeRequestAsync<TransactionOutputResponse>(RpcType.GetTxOut, transactionId, voutNumber, includeMemoryPool);
        }

        #endregion
    }
}
