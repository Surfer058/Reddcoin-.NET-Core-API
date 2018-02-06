using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implemetation class for retrieving the total amount of interest. 
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetInterest" />
    public class GetInterest : IGetInterest
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInterest"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetInterest(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the interest.
        /// </summary>
        /// <returns>
        /// A <see cref="decimal" /> with the interest.
        /// </returns>
        public async Task<ResponseInfo<decimal>> Execute()
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetInterest);
        }

        #endregion
    }
}
