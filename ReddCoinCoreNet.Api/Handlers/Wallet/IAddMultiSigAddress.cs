using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    public interface IAddMultiSigAddress
    {
        Task<ResponseInfo<decimal>> Execute();
    }
}
