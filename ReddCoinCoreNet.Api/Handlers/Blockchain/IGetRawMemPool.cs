using System.Collections.Generic;
using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Blockchain
{
    // ToDo
    public interface IGetRawMemPool
    {
        Task<ResponseInfo<IList<string>>> Execute();
    }
}