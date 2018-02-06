using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Mining.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the estimated network hashes per second based on the number of blocks.
    /// </summary>
    public class GetNetworkHashesPerSecond : IGetNetworkHashesPerSecond
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNetworkHashesPerSecond"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetNetworkHashesPerSecond(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the network hashes per second.
        /// </summary>
        /// <param name="block">The number of blocks, or -1 for blocks since last difficulty change.</param>
        /// <param name="height">To estimate at the time of the given height.</param>
        /// <returns>
        /// A <see cref="int" /> with the estimated number of hashes per second.
        /// </returns>
        public async Task<ResponseInfo<int>> Execute(int block, int height)
        {
            return await _rpcContext.MakeRequestAsync<int>(RpcType.GetNetworkHashps, block, height);
        }

        #endregion
    }
}
