using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    public class ImportPrivateKey
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        public ImportPrivateKey(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        public async Task<ResponseInfo<decimal>> Execute(string privateKey)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.ImportPrivKey, privateKey);
        }

        public async Task<ResponseInfo<decimal>> Execute(string privateKey, string label)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.ImportPrivKey, privateKey, label);
        }

        public async Task<ResponseInfo<decimal>> Execute(string privateKey, string label, bool rescan)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.ImportPrivKey, privateKey, label, rescan);
        }

        #endregion
    }
}
