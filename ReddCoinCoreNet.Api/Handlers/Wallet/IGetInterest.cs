using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving the total amount of interest. 
    /// </summary>
    public interface IGetInterest
    {
        /// <summary>
        /// Retrieves the interest.
        /// </summary>
        /// <returns>A <see cref="decimal"/> with the interest.</returns>
        Task<ResponseInfo<decimal>> Execute();
    }
}