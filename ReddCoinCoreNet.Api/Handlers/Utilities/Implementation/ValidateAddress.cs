using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Utilities.Implementation
{
    /// <summary>
    /// Implementation class for validation an address (public key).
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Utilities.IValidateAddress" />
    public class ValidateAddress : IValidateAddress
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAddress"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ValidateAddress(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Validates the address.
        /// </summary>
        /// <param name="address">The address/public key to validate.</param>
        /// <returns>
        /// A <see cref="ValidateAddressResponse" /> object representing the address information.
        /// </returns>
        public async Task<ResponseInfo<ValidateAddressResponse>> Execute(string address)
        {
            return await _rpcContext.MakeRequestAsync<ValidateAddressResponse>(RpcType.ValidateAddress, address);
        }

        #endregion
    }
}
