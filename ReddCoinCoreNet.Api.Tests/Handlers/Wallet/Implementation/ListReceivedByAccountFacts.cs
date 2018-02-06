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
    public class ListReceivedByAccountFacts
    {
        [TestMethod]
        public void ShouldReturnReceivedByAccount()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListReceivedByAccount systemUnderTest = new ListReceivedByAccount(rpcContext);

            // Act
            ResponseInfo<IList<ReceivedByAccountResponse>> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnReceivedByAccountWithALeastOneConfirmation()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListReceivedByAccount systemUnderTest = new ListReceivedByAccount(rpcContext);

            // Act
            ResponseInfo<IList<ReceivedByAccountResponse>> response = systemUnderTest.Execute(1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnReceivedByAccountWithALeastOneConfirmationAndEmptyIncluded()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListReceivedByAccount systemUnderTest = new ListReceivedByAccount(rpcContext);

            // Act
            ResponseInfo<IList<ReceivedByAccountResponse>> response = systemUnderTest.Execute(1, true).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
