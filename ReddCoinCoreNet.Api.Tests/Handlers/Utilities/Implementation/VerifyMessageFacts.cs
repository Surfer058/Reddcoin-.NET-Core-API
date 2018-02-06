using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Utilities;
using ReddCoinCoreNet.Api.Handlers.Utilities.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Utilities.Implementation
{
    [TestClass]
    public class VerifyMessageFacts
    {
        [TestMethod]
        public void ShouldVerifyMessage()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IVerifyMessage systemUnderTest = new VerifyMessage(rpcContext);

            // Act
            ResponseInfo<bool> response = systemUnderTest.Execute("Rk5BT4zudWDQhdZ2cJakzDhWiRtjeKBzku", "H6DtnbyWtIi3VnrkJZujop1MUv8qK8AB+wpJ+zsFwLW/prvB1CuZTg4MrtLncrfGwBMAPb3r6qleUeBII5MfiRw=", "The message").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
