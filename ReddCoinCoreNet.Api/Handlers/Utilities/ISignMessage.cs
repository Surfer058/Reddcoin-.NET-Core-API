using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Utilities
{
    /// <summary>
    /// Interface for signing a message with the private key of the corresponding address.
    /// </summary>
    /// <remarks>
    /// Before being able to sign a message, the wallet needs to be unlocked with the option StackOnly = false.
    /// </remarks>
    public interface ISignMessage
    {
        /// <summary>
        /// Signs the message.
        /// </summary>
        /// <param name="address">The address for the corresponding private key.</param>
        /// <param name="message">The message to sign.</param>
        /// <returns>A <see cref="string"/> with the signed message.</returns>
        Task<ResponseInfo<string>> Execute(string address, string message);
    }
}