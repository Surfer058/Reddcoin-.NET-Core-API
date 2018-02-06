using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    public class MoveReddcoins
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        public MoveReddcoins(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        public async Task<ResponseInfo<decimal>> Execute(string fromAccount, string toAccount, decimal amount)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.Move, fromAccount, toAccount, amount);
        }

        public async Task<ResponseInfo<decimal>> Execute(string fromAccount, string toAccount, decimal amount, int minimumConfirmations)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.Move, fromAccount, toAccount, amount, minimumConfirmations);
        }

        public async Task<ResponseInfo<decimal>> Execute(string fromAccount, string toAccount, decimal amount, int minimumConfirmations, string comment)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.Move, fromAccount, toAccount, amount, minimumConfirmations, comment);
        }

        #endregion
    }
}
