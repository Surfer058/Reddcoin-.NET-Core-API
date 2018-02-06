using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving a hex-encoded transaction describing the transaction.
    /// </summary>
    public interface IGetRawTransaction
    {
        /// <summary>
        /// Retrieves a hex-encoded value of a transaction.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>A hex-encoded <see cref="string"/>.</returns>
        Task<ResponseInfo<RawTransactionResponse>> Execute(string transactionId);
    }
}