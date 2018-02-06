using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Network;
using ReddCoinCoreNet.Api.Handlers.Network.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Network.Implementation
{
    [TestClass]
    public class GetNetworkInfoFacts
    {
        [TestMethod]
        public void ShouldReturnNetworkInfo()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetNetworkInfo systemUnderTest = new GetNetworkInfo(rpcContext);

            // Act
            ResponseInfo<NetworkInfoResponse> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
