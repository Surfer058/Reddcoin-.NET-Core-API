namespace ReddCoinCoreNet.Api.Infrastructure.Contexts
{
    public interface IConfigurationContext
    {
        string Url { get; }
        
        string RpcUsername { get; }

        string RpcPassword { get; }

        string WalletPassword { get; }

        int RpcRequestTimeout { get; }
    }
}
