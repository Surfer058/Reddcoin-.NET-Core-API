using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving wallet information like balance, number of transactions and version.
    /// </summary>
    public interface IGetWalletInfo
    {
        /// <summary>
        /// Retrieves the wallet information.
        /// </summary>
        /// <returns>A <see cref="WalletResponse"/> object.</returns>
        Task<ResponseInfo<WalletResponse>> Execute();
    }
}
