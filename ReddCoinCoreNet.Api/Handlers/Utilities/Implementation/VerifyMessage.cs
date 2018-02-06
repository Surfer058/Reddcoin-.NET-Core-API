using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Utilities.Implementation
{
    /// <summary>
    /// Implementation class for verifying a signed message.
    /// The message to verify can be the result of the <see cref="IVerifyMessage"/> response.
    /// </summary>
    /// <remarks>
    /// Before being able to verify a signed message, the wallet needs to be unlocked with the option StackOnly = false.
    /// </remarks>
    public class VerifyMessage : IVerifyMessage
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyMessage"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public VerifyMessage(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Verifies the message.
        /// </summary>
        /// <param name="address">The Reddcoin address.</param>
        /// <param name="signature">The signature provided by the signer in base 64 encoding (see signmessage).</param>
        /// <param name="message">The message to verify against the signature..</param>
        /// <returns>
        /// True if the message could be verified, else false.
        /// </returns>
        public async Task<ResponseInfo<bool>> Execute(string address, string signature, string message)
        {
            return await _rpcContext.MakeRequestAsync<bool>(RpcType.VerifyMessage, address, signature, message);
        }

        #endregion
    }
}
