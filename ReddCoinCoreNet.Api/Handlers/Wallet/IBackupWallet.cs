using ReddCoinCoreNet.Api.Stores.Response;
using System.Threading.Tasks;

namespace ReddCoinCoreNet.Api.Handlers.Wallet
{
    /// <summary>
    /// Interface for creating a safe backup of the wallet.dat file.
    /// </summary>
    /// <remarks>
    /// When the destination location (e.g. C:\Backup) already contains a backup file, it will be overwritten.
    /// </remarks>
    public interface IBackupWallet
    {
        /// <summary>
        /// Creates the backup.
        /// </summary>
        /// <param name="destination">The destination (example "C:\\Backup").</param>
        /// <returns>An <see cref="object"/> with value null.</returns>
        Task<ResponseInfo<object>> Execute(string destination);
    }
}