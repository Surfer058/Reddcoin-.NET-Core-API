using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implemenation class for retrieving/dumping the private key for the corresponding address in wallet-import-format (WIP).
    /// </summary>
    /// <remarks>
    /// Before being able to retrieve the private key, the wallet needs to be unlocked with the option StackOnly = false.
    /// The output of this call, can be used for <see cref="ImportPrivateKey"/>
    /// </remarks>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IExportPrivateKey" />
    public class ExportPrivateKey : IExportPrivateKey
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportPrivateKey"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public ExportPrivateKey(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Retrieves the private key.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>
        /// A <see cref="string" /> containing the private key.
        /// </returns>
        public async Task<ResponseInfo<string>> Execute(string address)
        {
            return await _rpcContext.MakeRequestAsync<string>(RpcType.DumpPrivKey, address);
        }

        #endregion
    }
}
