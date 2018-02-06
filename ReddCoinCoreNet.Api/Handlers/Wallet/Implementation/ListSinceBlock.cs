using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    public class ListSinceBlock
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        public ListSinceBlock(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        public async Task<ResponseInfo<IList<SinceBlockResponse>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IList<SinceBlockResponse>>(RpcType.ListSinceBlock);
        }

        public async Task<ResponseInfo<IList<SinceBlockResponse>>> Execute(string blockhash)
        {
            return await _rpcContext.MakeRequestAsync<IList<SinceBlockResponse>>(RpcType.ListSinceBlock, blockhash);
        }

        public async Task<ResponseInfo<IList<SinceBlockResponse>>> Execute(string blockhash, int targetConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<IList<SinceBlockResponse>>(RpcType.ListSinceBlock, blockhash, targetConfirmations);
        }

        #endregion
    }
}
