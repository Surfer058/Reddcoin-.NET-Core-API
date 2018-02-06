using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Utilities.Implementation
{
    /// <summary>
    /// Implementation class for signing a message with the private key of the corresponding address.
    /// </summary>
    /// <remarks>
    /// Before being able to sign a message, the wallet needs to be unlocked with the option StackOnly = false.
    /// </remarks>
    public class SignMessage : ISignMessage
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SignMessage"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public SignMessage(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Signs the message.
        /// </summary>
        /// <param name="address">The address for the corresponding private key.</param>
        /// <param name="message">The message to sign.</param>
        /// <returns>
        /// A <see cref="string" /> with the signed message.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute(string address, string message)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.SignMessage, address, message);
        }

        #endregion
    }
}
