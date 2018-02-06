using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Network
{
    /// <summary>
    /// Information for retrieving the network totals.
    /// </summary>
    public interface IGetNetTotals
    {
        /// <summary>
        /// Retrieves the network totals.
        /// </summary>
        /// <returns>A <see cref="NetTotalResponse"/> object.</returns>
        Task<ResponseInfo<NetTotalResponse>> Execute();
    }
}