using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the staking information.
    /// </summary>
    public interface IGetStakingInfo
    {
        /// <summary>
        /// Retrieves the staking information.
        /// </summary>
        /// <returns>A <see cref="StakingInfoResponse"/> object.</returns>
        Task<ResponseInfo<StakingInfoResponse>> Execute();
    }
}