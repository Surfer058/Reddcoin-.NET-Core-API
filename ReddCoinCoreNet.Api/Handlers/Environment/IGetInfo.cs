using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Environment
{
    /// <summary>
    /// Interface for retrieving the current state of the Reddcoin wallet.
    /// </summary>
    public interface IGetInfo
    {
        /// <summary>
        /// Retrieves the current state of the wallet.
        /// </summary>
        /// <returns>A <see cref="InfoResponse"/> object.</returns>
        Task<ResponseInfo<InfoResponse>> Execute();
    }
}