using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class UnlockWalletFacts
    {
        [TestMethod]
        public void ShouldUnlockWallet()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            UnlockWallet systemUnderTest = new UnlockWallet(rpcContext);

            // Act
            ResponseInfo<object> response = systemUnderTest.Execute("P@ssw0rd", 10000).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldUnlockWalletWithStakeOnly()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            UnlockWallet systemUnderTest = new UnlockWallet(rpcContext);

            // Act
            ResponseInfo<object> response = systemUnderTest.Execute("P@ssw0rd", 10000, true).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
