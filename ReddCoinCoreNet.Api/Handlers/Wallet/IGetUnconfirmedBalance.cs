using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the unconfirmed balance within the wallet.
    /// </summary>
    public interface IGetUnconfirmedBalance
    {
        /// <summary>
        /// Retrieves the unconfirmed balance.
        /// </summary>
        /// <returns>A <see cref="decimal"/> respresenting the unconfirmed balance.</returns>
        Task<ResponseInfo<decimal>> Execute();
    }
}