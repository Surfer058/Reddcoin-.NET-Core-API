using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for retrieving the details of an unspent transaction.
    /// </summary>
    public interface IGetTransactionOutput
    {
        /// <summary>
        /// Retrieves the transaction details.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="voutNumber">The vout number.</param>
        /// <param name="includeMemoryPool"><see cref="bool"/> indicating to include the memory pool, default is true.</param>
        /// <returns>A <see cref="TransactionOutputResponse"/> object containing transaction details.</returns>
        Task<ResponseInfo<TransactionOutputResponse>> Execute(string transactionId, int voutNumber, bool includeMemoryPool);
    }
}