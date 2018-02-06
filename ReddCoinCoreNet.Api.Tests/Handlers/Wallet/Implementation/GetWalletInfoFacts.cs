using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class GetWalletInfoFacts
    {
        [TestMethod]
        public void ShouldReturnWalletInfo()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetWalletInfo systemUnderTest = new GetWalletInfo(rpcContext);

            // Act
            ResponseInfo<WalletResponse> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
