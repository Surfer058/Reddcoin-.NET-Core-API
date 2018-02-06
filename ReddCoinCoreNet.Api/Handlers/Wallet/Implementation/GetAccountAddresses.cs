using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving a list of adresses (public keys) by its account name.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetAccountAddresses" />
    public class GetAccountAddresses : IGetAccountAddresses
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountAddresses"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetAccountAddresses(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves a list of addresses.
        /// </summary>
        /// <param name="accountName">The account name.</param>
        /// <returns>
        /// A collection of <see cref="string" /> containing the addresses.
        /// </returns>
        public async Task<ResponseInfo<IList<string>>> Execute(string accountName)
        {
            return await _rpcContext.MakeRequestAsync<IList<string>>(RpcType.GetAddressesByAccount, accountName);
        }

        #endregion
    }
}
