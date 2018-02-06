using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for retrieving the hash of the most recent block on the best block chain.
    /// </summary>
    public interface IGetBestBlockhash
    {
        /// <summary>
        /// Retrieves the hash.
        /// </summary>
        /// <returns>A <see cref="string"/> containing the hash.</returns>
        Task<ResponseInfo<string>> Execute();
    }
}