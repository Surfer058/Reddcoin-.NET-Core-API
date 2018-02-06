using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class MoveReddcoinsFacts
    {
        [TestMethod]
        public void ShouldSendCoins()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            MoveReddcoins systemUnderTest = new MoveReddcoins(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("", "", 1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldSendCoinsWithAtLeastOneConfirmation()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            MoveReddcoins systemUnderTest = new MoveReddcoins(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("", "", 1, 1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldSendCoinsWithAtLeastOneConfirmationAndALabel()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            MoveReddcoins systemUnderTest = new MoveReddcoins(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("", "", 1, 1, "Label").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
