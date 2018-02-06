using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for listing groups of addresses which have had their common ownership
    /// made public by common use as inputs or as the resulting change in past transactions.
    /// </summary>
    public interface IListAddressGroupings
    {
        /// <summary>
        /// Retrieves a list of grouped addresses.
        /// </summary>
        /// <returns>A <see cref="object"/> with the groups.</returns>
        Task<ResponseInfo<object>> Execute();
    }
}