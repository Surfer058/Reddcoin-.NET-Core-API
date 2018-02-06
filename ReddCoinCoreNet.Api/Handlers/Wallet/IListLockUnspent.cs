using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving a list of locked unspent outputs.
    /// </summary>
    public interface IListLockUnspent
    {
        /// <summary>
        /// Retrieves the locked unspent outputs.
        /// </summary>
        /// <returns>An <see cref="object"/>.</returns>
        Task<ResponseInfo<object>> Execute();
    }
}