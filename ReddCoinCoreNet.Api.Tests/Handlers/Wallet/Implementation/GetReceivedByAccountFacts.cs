using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class GetReceivedByAccountFacts
    {
        [TestMethod]
        public void ShouldReturnReceivedByAccount()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetReceivedByAccount systemUnderTest = new GetReceivedByAccount(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("AccountName").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnReceivedByAccountWithAtLeastOneConfirmation()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetReceivedByAccount systemUnderTest = new GetReceivedByAccount(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("AccountName", 1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
