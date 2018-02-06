using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class SendReddcoinsFromAccountFacts
    {
        [TestMethod]
        public void ShouldReturnTransactionId()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ISendReddcoinsFromAccount systemUnderTest = new SendReddcoinsFromAccount(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute("Test account1", "RtEbgZV6PcR4oKJTx9e3AQBcT4nLMvdwK4",
                                                                     2, 5, "comment", "toComment").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
