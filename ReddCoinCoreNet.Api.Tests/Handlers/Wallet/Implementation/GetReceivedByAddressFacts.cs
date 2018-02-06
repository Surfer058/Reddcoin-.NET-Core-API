using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class GetReceivedByAddressFacts
    {
        [TestMethod]
        public void ShouldReturnReceivedByAddress()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetReceivedByAddress systemUnderTest = new GetReceivedByAddress(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("RtEbgZV6PcR4oKJTx9e3AQBcT4nLMvdwK4").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnReceivedByAddressWithAtLeastOneConfirmation()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetReceivedByAddress systemUnderTest = new GetReceivedByAddress(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("RtEbgZV6PcR4oKJTx9e3AQBcT4nLMvdwK4", 1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
