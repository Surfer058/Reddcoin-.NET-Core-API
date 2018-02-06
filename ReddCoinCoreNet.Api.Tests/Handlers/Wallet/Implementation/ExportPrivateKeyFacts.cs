using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReddCoinCoreNet.Api.Handlers.Wallet;
using ReddCoinCoreNet.Api.Handlers.Wallet.Implementation;
using ReddCoinCoreNet.Api.Infrastructure.Contexts;
using ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Tests.Handlers.Wallet.Implementation
{
    [TestClass]
    public class ExportPrivateKeyFacts
    {
        [TestMethod]
        public void ShouldDumpPrivateKey()
        {
            // Arrange
            IConfigurationContext configurationContext = new ConfigurationContext();
            IRpcContext rpcContext = new RpcContext(configurationContext);
            IExportPrivateKey systemUnderTest = new ExportPrivateKey(rpcContext);

            // Act
            ResponseInfo<string> response = systemUnderTest.Execute("Rk5BT4zudWDQhdZ2cJakzDhWiRtjeKBzku").GetAwaiter().GetResult();

            //Assert
            Assert.IsNull(response.Error);
        }
    }
}
