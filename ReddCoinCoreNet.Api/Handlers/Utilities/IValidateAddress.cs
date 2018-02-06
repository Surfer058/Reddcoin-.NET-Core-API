using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Utilities
{
    /// <summary>
    /// Interface for validation an address (public key).
    /// </summary>
    public interface IValidateAddress
    {
        /// <summary>
        /// Validates the address.
        /// </summary>
        /// <param name="address">The address/public key to validate.</param>
        /// <returns>A <see cref="ValidateAddressResponse"/> object representing the address information.</returns>
        Task<ResponseInfo<ValidateAddressResponse>> Execute(string address);
    }
}