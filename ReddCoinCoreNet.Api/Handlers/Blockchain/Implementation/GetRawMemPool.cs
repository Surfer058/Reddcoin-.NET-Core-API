using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation
{
    public class GetRawMemPool : IGetRawMemPool
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        public GetRawMemPool(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        public async Task<ResponseInfo<IList<string>>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<IList<string>>(RpcType.GetRawMemPool);
        }
        
        #endregion
    }
}
