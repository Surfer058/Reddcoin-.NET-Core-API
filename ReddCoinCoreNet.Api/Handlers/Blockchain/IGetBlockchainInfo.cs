using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for retrieving the current state of the blockchain.
    /// </summary>
    public interface IGetBlockchainInfo
    {
        /// <summary>
        /// Retrieves the current state of the blockchain.
        /// </summary>
        /// <returns>A <see cref="BlockchainInfoResponse"/> object.</returns>
        Task<ResponseInfo<BlockchainInfoResponse>> Execute();
    }
}