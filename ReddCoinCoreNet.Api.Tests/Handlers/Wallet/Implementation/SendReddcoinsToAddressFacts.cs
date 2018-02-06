using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class SendReddcoinsToAddressFacts
    {
        [TestMethod]
        public void ShouldSendToAddress()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ISendReddcoinsToAddress systemUnderTest = new SendReddcoinsToAddress(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute("RtEbgZV6PcR4oKJTx9e3AQBcT4nLMvdwK4", 1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldSendToAddressWithComment()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ISendReddcoinsToAddress systemUnderTest = new SendReddcoinsToAddress(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute("RtEbgZV6PcR4oKJTx9e3AQBcT4nLMvdwK4", 1, "Test").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldSendToAddressWithCommentAndCommentTo()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ISendReddcoinsToAddress systemUnderTest = new SendReddcoinsToAddress(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute("RtEbgZV6PcR4oKJTx9e3AQBcT4nLMvdwK4", 1, "test", "tester").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
