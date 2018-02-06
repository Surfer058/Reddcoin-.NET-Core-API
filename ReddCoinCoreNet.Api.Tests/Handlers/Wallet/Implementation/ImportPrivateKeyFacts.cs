using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class ImportPrivateKeyFacts
    {
        [TestMethod]
        public void ShouldImportPrivateKey()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ImportPrivateKey systemUnderTest = new ImportPrivateKey(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldImportPrivateKeyWithLabel()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ImportPrivateKey systemUnderTest = new ImportPrivateKey(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("","").GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }

        [TestMethod]
        public void ShouldImportPrivateKeyWithLabelRescan()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            ImportPrivateKey systemUnderTest = new ImportPrivateKey(rpcContext);

            // Act
            ResponseInfo<decimal> response = systemUnderTest.Execute("","",true).GetAwaiter().GetResult();

            // Assert
            Assert.IsNull(response.Error);
        }
    }
}
