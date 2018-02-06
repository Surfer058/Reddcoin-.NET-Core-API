using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Environment.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the list of available request methods.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Environment.IGetHelp" />
    public class GetHelp : IGetHelp
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHelp"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetHelp(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the information.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> with the help information.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.Help);
        }

        #endregion
    }
}
