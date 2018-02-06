using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for locking the wallet.
    /// </summary>
    public interface ILockWallet
    {
        /// <summary>
        /// Locks the wallet.
        /// </summary>
        /// <returns>A <see cref="object"/> with value Null.</returns>
        Task<ResponseInfo<object>> Execute();
    }
}