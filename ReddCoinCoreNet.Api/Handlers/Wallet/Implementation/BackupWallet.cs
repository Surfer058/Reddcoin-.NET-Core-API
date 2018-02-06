using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet.Implementation
{
    /// <summary>
    /// Implemenation class for creating a safe backup of the wallet.dat file.
    /// </summary>
    /// <remarks>
    /// When the destination location (e.g. C:\Backup) already contains a backup file, it will be overwritten.
    /// </remarks>
    /// <seealso cref="ReddCoinCoreNet.Api.Handlers.Wallet.IBackupWallet" />
    public class BackupWallet : IBackupWallet
    {
        #region Private fields

        private readonly IRpcContext _rpcContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupWallet"/> class.
        /// </summary>
        /// <param name="rpcContext">The RPC context.</param>
        public BackupWallet(IRpcContext rpcContext)
        {
            _rpcContext = rpcContext;
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Creates the backup.
        /// </summary>
        /// <param name="destination">The destination (example "C:\\Backup").</param>
        /// <returns>
        /// An <see cref="object" /> with value null.
        /// </returns>
        public async Task<ResponseInfo<object>> Execute(string destination)
        {
            return await _rpcContext.MakeRequestAsync<object>(RpcType.BackupWallet, destination);
        }

        #endregion
    }
}
