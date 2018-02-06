using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the total amount of Reddcoins by the provided address.
    /// </summary>
    public class GetReceivedByAddress : IGetReceivedByAddress
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReceivedByAddress"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public GetReceivedByAddress(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the recieved amount of Reddcoins.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>
        /// A <see cref="decimal" /> with the total amount of received Reddcoins.
        /// </returns>
        public async Task<ResponseInfo<decimal>> Execute(string address)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetReceivedByAddress, address);
        }

        /// <summary>
        /// Retrieves the recieved amount of Reddcoins with a minimum number of confirmations.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="minimumConfirmation">The minimum number of confirmations.</param>
        /// <returns>
        /// A <see cref="decimal" /> with the total amount of received Reddcoins.
        /// </returns>
        public async Task<ResponseInfo<decimal>> Execute(string address, int minimumConfirmation)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetReceivedByAddress, address, minimumConfirmation);
        }

        #endregion
    }
}
