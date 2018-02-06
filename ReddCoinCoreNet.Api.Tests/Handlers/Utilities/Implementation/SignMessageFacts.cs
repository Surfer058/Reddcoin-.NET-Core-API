using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Utilities;
using ReddCoinCoreNet.Api.Handlers.Utilities.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Utilities.Implementation
{
    [TestClass]
    public class SignMessageFacts
    {
        [TestMethod]
        public void ShouldSignMessage()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ISignMessage systemUnderTest = new SignMessage(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute("Rk5BT4zudWDQhdZ2cJakzDhWiRtjeKBzku", "The message").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
