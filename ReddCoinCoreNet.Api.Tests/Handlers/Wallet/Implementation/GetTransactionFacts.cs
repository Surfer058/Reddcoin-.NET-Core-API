using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class GetTransactionFacts
    {
        [TestMethod]
        public void ShouldReturnTransactionInformation()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetTransaction systemUnderTest = new GetTransaction(rpcContext);

            // Act
            // To retrieve a transaction by its identifier, run ListTransactionsFacts, to retrieve the list of transaction and pick one.
            ResponseInfo<TransactionResponse> response = systemUnderTest.Execute("b75e9ace88d5db393220e91a2b9b81cf2e2d4178dfc1272399707ad9781f4cda").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
