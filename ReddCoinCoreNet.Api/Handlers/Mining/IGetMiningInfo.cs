using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Mining
{
    /// <summary>
    /// Interface for retrieving mining and stake information.
    /// </summary>
    public interface IGetMiningInfo
    {
        /// <summary>
        /// Retrieves the mining information.
        /// </summary>
        /// <returns>A <see cref="MiningInfoResponse"/> object.</returns>
        Task<ResponseInfo<MiningInfoResponse>> Execute();
    }
}