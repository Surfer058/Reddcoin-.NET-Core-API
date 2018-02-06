using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Environment;
using ReddCoinCoreNet.Api.Handlers.Environment.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Environment.Implementation
{
    [TestClass]
    public class GetHelpFacts
    {
        [TestMethod]
        public void ShouldReturnHelp()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetHelp systemUnderTest = new GetHelp(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
