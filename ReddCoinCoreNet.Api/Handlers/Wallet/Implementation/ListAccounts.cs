using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    public class ListAccounts : IListAccounts
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccounts"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ListAccounts(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        public async Task<ResponseInfo<IDictionary<string, decimal>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IDictionary<string, decimal>>(RpcType.ListAccounts);
        }

        public async Task<ResponseInfo<IDictionary<string, decimal>>> Execute(int minimumAmountOfConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<IDictionary<string, decimal>>(RpcType.ListAccounts, minimumAmountOfConfirmations);
        }

        #endregion
    }
}
