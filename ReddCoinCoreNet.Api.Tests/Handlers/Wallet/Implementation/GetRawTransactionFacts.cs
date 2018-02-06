using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class GetRawTransactionFacts
    {
        [TestMethod]
        public void ShouldReturnRawTransaction()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetRawTransaction systemUnderTest = new GetRawTransaction(rpcContext);

            // Act
            ResponseInfo<RawTransactionResponse> response = systemUnderTest.Execute("1404ab2b919af014c351056bf69b3f29a678e35377c7d32fc4597b623b107f1c").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
