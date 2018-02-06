using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Mining.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Mining.Implementation
{
    [TestClass]
    public class GetNetworkHashesPerSecondFacts
    {
        [TestMethod]
        public void ShouldReturnNumberOfNetworkHashesPerSecond()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            GetNetworkHashesPerSecond systemUnderTest = new GetNetworkHashesPerSecond(rpcContext);

            // Act
            ResponseInfo<int> response = systemUnderTest.Execute(1, 10).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
