using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Mining;
using ReddCoinCoreNet.Api.Handlers.Mining.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Mining.Implementation
{
    [TestClass]
    public class GetMiningInfoFacts
    {
        [TestMethod]
        public void ShouldReturnMiningInfo()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetMiningInfo systemUnderTest = new GetMiningInfo(rpcContext);

            // Act
            ResponseInfo<MiningInfoResponse> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
