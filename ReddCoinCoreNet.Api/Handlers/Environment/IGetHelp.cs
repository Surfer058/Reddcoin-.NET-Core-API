using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Environment
{
    /// <summary>
    /// Interface for retrieving the list of available request methods.
    /// </summary>
    public interface IGetHelp
    {
        /// <summary>
        /// Retrieves the information.
        /// </summary>
        /// <returns>A <see cref="string"/> with the help information.</returns>
        Task<ResponseInfo<string>> Execute();
    }
}