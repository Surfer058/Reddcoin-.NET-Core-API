using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Blockchain;
using ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Blockchain.Implementation
{
    [TestClass]
    public class GetBestBlockhashFacts
    {
        [TestMethod]
        public void ShouldReturnBestBlockHashForAccount()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetBestBlockhash systemUnderTest = new GetBestBlockhash(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
