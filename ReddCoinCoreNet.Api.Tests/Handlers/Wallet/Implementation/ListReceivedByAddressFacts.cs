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
    public class ListReceivedByAddressFacts
    {
        [TestMethod]
        public void ShouldReturnReceivedByAddress()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListReceivedByAddress systemUnderTest = new ListReceivedByAddress(rpcContext);

            // Act
            ResponseInfo<IList<ReceivedByAddressResponse>> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnReceivedByAddressWithALeastOneConfirmation()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListReceivedByAddress systemUnderTest = new ListReceivedByAddress(rpcContext);

            // Act
            ResponseInfo<IList<ReceivedByAddressResponse>> response = systemUnderTest.Execute(1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnReceivedByAddressWithALeastOneConfirmationAndEmptyIncluded()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IListReceivedByAddress systemUnderTest = new ListReceivedByAddress(rpcContext);

            // Act
            ResponseInfo<IList<ReceivedByAddressResponse>> response = systemUnderTest.Execute(1, true).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
