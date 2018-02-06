using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class ListUnspentFacts
    {
        [TestMethod]
        public void ShouldReturnACollectionOfUnspentTransactionOutputs()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListUnspent systemUnderTest = new ListUnspent(rpcContext);

            // Act
            ResponseInfo<IList<UnspentResponse>> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnACollectionOfUnspentTransactionOutputsWhenProvidingMinNumberOfConfirmation()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListUnspent systemUnderTest = new ListUnspent(rpcContext);

            // Act
            ResponseInfo<IList<UnspentResponse>> response = systemUnderTest.Execute(1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnACollectionOfUnspentTransactionOutputsWhenProvidingMinNumberOfConfirmationAndMaxNumberOfConfirmations()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListUnspent systemUnderTest = new ListUnspent(rpcContext);

            // Act
            ResponseInfo<IList<UnspentResponse>> response = systemUnderTest.Execute(1,10).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
