using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Utilities
{
    /// <summary>
    /// Interface for verifying a signed message.
    /// The message to verify can be the result of the <see cref="IVerifyMessage"/> response.
    /// </summary>
    /// <remarks>
    /// Before being able to verify a signed message, the wallet needs to be unlocked with the option StackOnly = false.
    /// </remarks>
    public interface IVerifyMessage
    {
        /// <summary>
        /// Verifies the message.
        /// </summary>
        /// <param name="address">The Reddcoin address.</param>
        /// <param name="signature">The signature provided by the signer in base 64 encoding (see signmessage).</param>
        /// <param name="message">The message to verify against the signature..</param>
        /// <returns>True if the message could be verified, else false.</returns>
        Task<ResponseInfo<bool>> Execute(string address, string signature, string message);
    }
}