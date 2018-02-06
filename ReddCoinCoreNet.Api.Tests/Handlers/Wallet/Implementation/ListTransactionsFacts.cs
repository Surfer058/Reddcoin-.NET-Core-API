using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;
using System.Collections.Generic;
using ReddCoinCoreNet.Api.Handlers.Wallet;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class ListTransactionsFacts
    {
        [TestMethod]
        public void ShouldReturnAllTransactions()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListTransactions systemUnderTest = new ListTransactions(rpcContext);

            // Act
            ResponseInfo<IList<TransactionsResponse>> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnTransactionsWhenProvidingAnAccount()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListTransactions systemUnderTest = new ListTransactions(rpcContext);

            // Act
            ResponseInfo<IList<TransactionsResponse>> response = systemUnderTest.Execute("").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnMax10Transactions()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListTransactions systemUnderTest = new ListTransactions(rpcContext);

            // Act
            ResponseInfo<IList<TransactionsResponse>> response = systemUnderTest.Execute("", 10).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnMax10TransactionsFrom0()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListTransactions systemUnderTest = new ListTransactions(rpcContext);

            // Act
            ResponseInfo<IList<TransactionsResponse>> response = systemUnderTest.Execute("", 10, 0).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
