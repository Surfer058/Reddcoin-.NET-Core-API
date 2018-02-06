using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Infrastructure.Contexts
{
    public interface IRpcContext
    {
        Task<ResponseInfo<TOut>> MakeRequestAsync<TOut>(RpcType rpcType, params object[] parameters);
    }
}
