using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Network;
using ReddCoinCoreNet.Api.Handlers.Network.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Network.Implementation
{
    [TestClass]
    public class GetConnectionCountFacts
    {
        [TestMethod]
        public void ShouldReturnNumberOfConnections()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetConnectionCount systemUnderTest = new GetConnectionCount(rpcContext);

            // Act
            ResponseInfo<int> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
