using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the unspent transaction outputs.
    /// </summary>
    /// <remarks>The sum of your unspent transaction outputs can be referenced as your balance.</remarks>
    public interface IListUnspent
    {
        /// <summary>
        /// Retrieves the unspent transaction outputs.
        /// </summary>
        /// <returns>A collection of <see cref="UnspentResponse"/> containing the unspent transaction outputs.</returns>
        Task<ResponseInfo<IList<UnspentResponse>>> Execute();

        /// <summary>
        /// Retrieves the unspent transaction outputs.
        /// </summary>
        /// <param name="minimumNumberOfConfirmations">The minimum number of confirmations.</param>
        /// <returns>
        /// A collection of <see cref="UnspentResponse" /> containing the unspent transaction outputs.
        /// </returns>
        Task<ResponseInfo<IList<UnspentResponse>>> Execute(int minimumNumberOfConfirmations);

        /// <summary>
        /// Retrieves the unspent transaction outputs.
        /// </summary>
        /// <param name="minimumNumberOfConfirmations">The minimum number of confirmations.</param>
        /// <param name="maximumNumberOfConfirmations">The maximum number of confirmations.</param>
        /// <returns>
        /// A collection of <see cref="UnspentResponse" /> containing the unspent transaction outputs.
        /// </returns>
        Task<ResponseInfo<IList<UnspentResponse>>> Execute(int minimumNumberOfConfirmations, int maximumNumberOfConfirmations);
    }
}