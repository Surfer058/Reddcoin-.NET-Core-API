using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for listing groups of addresses which have had their common ownership
    /// made public by common use as inputs or as the resulting change in past transactions.
    /// </summary>
    public class ListAddressGroupings : IListAddressGroupings
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAddressGroupings"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ListAddressGroupings(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves a list of grouped addresses.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Object" /> with the groups.
        /// </returns>
        public async Task<ResponseInfo<object>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.ListAddressGroupings);
        }

        #endregion
    }
}
