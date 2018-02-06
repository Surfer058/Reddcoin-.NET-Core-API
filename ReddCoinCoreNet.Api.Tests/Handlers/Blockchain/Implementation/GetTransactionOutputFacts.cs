using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Blockchain;
using ReddCoinCoreNet.Api.Handlers.Blockchain.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Blockchain.Implementation
{
    [TestClass]
    public class GetTransactionOutputFacts
    {
        [TestMethod]
        public void ShouldReturnOutgoingTransactionExcludingMemoryPool()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetTransactionOutput systemUnderTest = new GetTransactionOutput(rpcContext);

            // Act
            ResponseInfo<TransactionOutputResponse> response = systemUnderTest.Execute("1404ab2b919af014c351056bf69b3f29a678e35377c7d32fc4597b623b107f1c", 0, false).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnOutgoingTransactionIncludingMemoryPool()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IGetTransactionOutput systemUnderTest = new GetTransactionOutput(rpcContext);

            // Act
            ResponseInfo<TransactionOutputResponse> response = systemUnderTest.Execute("1404ab2b919af014c351056bf69b3f29a678e35377c7d32fc4597b623b107f1c", 0, true).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
