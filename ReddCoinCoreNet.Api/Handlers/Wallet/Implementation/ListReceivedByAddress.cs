using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the total number of Reddcoins received by each address.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IListReceivedByAddress" />
    public class ListReceivedByAddress : IListReceivedByAddress
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReceivedByAddress"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ListReceivedByAddress(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the list of addresses with its total balance.
        /// </summary>
        /// <returns>
        /// A collection of <see cref="ReceivedByAddressResponse" />.
        /// </returns>
        public async Task<ResponseInfo<IList<ReceivedByAddressResponse>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IList<ReceivedByAddressResponse>>(RpcType.ListReceivedByAddress);
        }

        /// <summary>
        /// Retrieves the list of addresses with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAddressResponse" />.
        /// </returns>
        public async Task<ResponseInfo<IList<ReceivedByAddressResponse>>> Execute(int minimumConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<IList<ReceivedByAddressResponse>>(RpcType.ListReceivedByAddress, minimumConfirmations);
        }

        /// <summary>
        /// Retrieves the list of addresses with its total balance.
        /// </summary>
        /// <param name="minimumConfirmations">The minimum confirmations.</param>
        /// <param name="includeEmpty">Whether to include the empty addresses as well.</param>
        /// <returns>
        /// A collection of <see cref="ReceivedByAddressResponse" />.
        /// </returns>
        public async Task<ResponseInfo<IList<ReceivedByAddressResponse>>> Execute(int minimumConfirmations, bool includeEmpty)
        {
            return await _rpcContext.MakeRequestAsync<IList<ReceivedByAddressResponse>>(RpcType.ListReceivedByAddress, minimumConfirmations, includeEmpty);
        }

        #endregion
    }
}
