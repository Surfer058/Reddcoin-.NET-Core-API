using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for setting the transaction fee per KiloByte paid by transactions created by this wallet.
    /// </summary>
    public interface ISetTransactionFee
    {
        /// <summary>
        /// Sets the transactions fee.
        /// </summary>
        /// <param name="amount">The transaction fee in RDD/KB.</param>
        /// <returns>True if set succesful, else false.</returns>
        Task<ResponseInfo<bool>> Execute(decimal amount);
    }
}