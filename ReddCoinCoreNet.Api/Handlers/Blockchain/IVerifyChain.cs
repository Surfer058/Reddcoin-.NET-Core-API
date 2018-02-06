using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    /// <summary>
    /// Interface for verifying the blockchain database.
    /// </summary>
    public interface IVerifyChain
    {
        /// <summary>
        /// Retrieves the status of the blockhain.
        /// </summary>
        /// <returns>A <see cref="bool"/> with true is the blockchain is ok, else false.</returns>
        Task<ResponseInfo<bool>> Execute();

        /// <summary>
        /// Retrieves the status of the blockhain with a certain check level.
        /// </summary>
        /// <param name="checkLevel">The check level 0-4, default is 3.</param>
        /// <returns>A <see cref="bool"/> with true is the blockchain is ok, else false.</returns>
        Task<ResponseInfo<bool>> Execute(int checkLevel);

        /// <summary>
        /// Retrieves the status of the blockhain with a certain check level and number of blocks.
        /// </summary>
        /// <param name="checkLevel">The check level 0-4, default is 3.</param>
        /// <param name="numberOfBlocks">The number of blocks, default=6, 0=all.</param>
        /// <returns>A <see cref="bool"/> with true is the blockchain is ok, else false.</returns>
        Task<ResponseInfo<bool>> Execute(int checkLevel, int numberOfBlocks);
    }
}