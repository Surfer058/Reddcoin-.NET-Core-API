using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for retrieving/dumping the private key for the corresponding address in wallet-import-format (WIP).
    /// </summary>
    /// <remarks>
    /// Before being able to retrieve the private key, the wallet needs to be unlocked with the option StackOnly = false.
    /// The output of this call, can be used for <see cref="IImportPrivateKey"/>
    /// </remarks>
    public interface IExportPrivateKey
    {
        /// <summary>
        /// Retrieves the private key.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>A <see cref="string"/> containing the private key.</returns>
        Task<ResponseInfo<string>> Execute(string address);
    }
}