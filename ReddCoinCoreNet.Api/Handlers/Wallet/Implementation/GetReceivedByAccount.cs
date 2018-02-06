using System.Threading.Tasks;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implementation class for retrieving the total amount of Reddcoins by the provided account name.
    /// </summary>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IGetReceivedByAccount" />
    public class GetReceivedByAccount : IGetReceivedByAccount
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        public GetReceivedByAccount(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the recieved amount of Reddcoins.
        /// </summary>
        /// <param name="accountName">The account name.</param>
        /// <returns>
        /// A <see cref="decimal" /> with the total amount of received Reddcoins.
        /// </returns>
        public async Task<ResponseInfo<decimal>> Execute(string accountName)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetReceivedByAccount, accountName);
        }

        /// <summary>
        /// Retrieves the recieved amount of Reddcoins with a minimum number of confirmations.
        /// </summary>
        /// <param name="accountName">The account name.</param>
        /// <param name="minimumConfirmation">The minimum number of confirmations.</param>
        /// <returns>
        /// A <see cref="decimal" /> with the total amount of received Reddcoins.
        /// </returns>
        public async Task<ResponseInfo<decimal>> Execute(string accountName, int minimumConfirmation)
        {
            return await _rpcContext.MakeRequestAsync<decimal>(RpcType.GetReceivedByAccount, accountName, minimumConfirmation);
        }

        #endregion
    }
}
