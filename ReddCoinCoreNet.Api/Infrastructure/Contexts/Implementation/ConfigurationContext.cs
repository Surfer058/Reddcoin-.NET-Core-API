namespace ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation
{
    public class ConfigurationContext : IConfigurationContext
    {
        public string Url
        {
            get
            {
                return "http://localhost:45333";
            }
        }

        public string RpcUsername
        {
            get
            {
                return "developer";
            }
        }

        public string RpcPassword
        {
            get
            {
                return "developerpassword";
            }
        }

        public string WalletPassword
        {
            get
            {
                return "WalletPassPhrase";
            }
        }

        public int RpcRequestTimeout
        {
            get
            {
                return 10000;
            }
        }
    }
}
