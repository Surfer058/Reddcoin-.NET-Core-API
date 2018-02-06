using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for retrieving the statistics of the unspent transaction set.
    /// </summary>
    public interface IGetTransactionOutputSetInfo
    {
        /// <summary>
        /// Retrieves the statistics.
        /// </summary>
        /// <returns>A <see cref="TransactionOutputSetInfoResponse"/> object containing the statistics.</returns>
        Task<ResponseInfo<TransactionOutputSetInfoResponse>> Execute();
    }
}