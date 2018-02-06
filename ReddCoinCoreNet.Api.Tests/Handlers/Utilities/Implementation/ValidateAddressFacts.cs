using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Utilities;
using ReddCoinCoreNet.Api.Handlers.Utilities.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Utilities.Implementation
{
    [TestClass]
    public class ValidateAddressFacts
    {
        [TestMethod]
        public void ShouldValidateAddress()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IValidateAddress systemUnderTest = new ValidateAddress(rpcContext);

            // Act
            ResponseInfo<ValidateAddressResponse> response = systemUnderTest.Execute("RokfF51SNqyuwX1JTJCuDyJ4PriFW6HuCK").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
