using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Network.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the number of connections to other nodes.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Network.IGetConnectionCount" />
    public class GetConnectionCount : IGetConnectionCount
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectionCount"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetConnectionCount(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the number of connections.
        /// </summary>
        /// <returns>
        /// A <see cref="int" /> representing the number of connections.
        /// </returns>
        public async Task<ResponseInfo<int>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<int>(RpcType.GetConnectionCount);
        }

        #endregion
    }
}
