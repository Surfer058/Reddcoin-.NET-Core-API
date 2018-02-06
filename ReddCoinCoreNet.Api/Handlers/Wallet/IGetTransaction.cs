using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the transaction information by its identifier.
    /// </summary>
    public interface IGetTransaction
    {
        /// <summary>
        /// Retrieves the transaction information.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>A <see cref="TransactionResponse"/> object containing the transaction information.</returns>
        Task<ResponseInfo<TransactionResponse>> Execute(string transactionId);
    }
}