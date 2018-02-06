using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class ListSinceBlockFacts
    {
        [TestMethod]
        public void ShouldReturnListSinceBlock()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ListSinceBlock systemUnderTest = new ListSinceBlock(rpcContext);

            // Act
            ResponseInfo<IList<SinceBlockResponse>> response = systemUnderTest.Execute().GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnListSinceBlockForBlockhash()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ListSinceBlock systemUnderTest = new ListSinceBlock(rpcContext);

            // Act
            ResponseInfo<IList<SinceBlockResponse>> response = systemUnderTest.Execute("").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldReturnListSinceBlockForBlockhashAndTargetConfirmations()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ListSinceBlock systemUnderTest = new ListSinceBlock(rpcContext);

            // Act
            ResponseInfo<IList<SinceBlockResponse>> response = systemUnderTest.Execute("", 1).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
