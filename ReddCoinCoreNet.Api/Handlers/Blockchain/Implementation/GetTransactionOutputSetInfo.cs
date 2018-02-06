using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    /// <summary>
    /// Implementations class for retrieving the statistics of the unspent transaction set.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Blockchain.IGetTransactionOutputSetInfo" />
    public class GetTransactionOutputSetInfo : IGetTransactionOutputSetInfo
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionOutputSetInfo"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetTransactionOutputSetInfo(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the statistics.
        /// </summary>
        /// <returns>
        /// A <see cref="TransactionOutputSetInfoResponse" /> object containing the statistics.
        /// </returns>
        public async Task<ResponseInfo<TransactionOutputSetInfoResponse>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<TransactionOutputSetInfoResponse>(RpcType.GetTxOutsetInfo);
        }

        #endregion
    }
}
