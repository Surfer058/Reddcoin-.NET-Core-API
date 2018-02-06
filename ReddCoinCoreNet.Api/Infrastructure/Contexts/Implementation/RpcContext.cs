using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ReddCoinCoreNet.Api.Infrastructure.Enums;
using ReddCoinCoreNet.Api.Stores.Request;
using ReddCoinCoreNet.Api.Stores.Response;

namespace ReddCoinCoreNet.Api.Infrastructure.Contexts.Implementation
{
    public class RpcContext : IRpcContext
    {
        #region Private fields

        private readonly IConfigurationContext _configurationContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcContext"/> class.
        /// </summary>
        /// <param name="configurationContext">The configuration context.</param>
        public RpcContext(IConfigurationContext configurationContext)
        {
            _configurationContext = configurationContext;
        }

        #endregion

        #region IRpcContext Implementation

        /// <summary>
        /// Makes the request asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="rpcType">Type of the RPC.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public async Task<ResponseInfo<TOut>> MakeRequestAsync<TOut>(RpcType rpcType, params object[] parameters)
        {
            RequestInfo jsonRpcRequest = new RequestInfo(1, rpcType.ToString().ToLower(), parameters);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_configurationContext.Url);
            webRequest.Credentials = new NetworkCredential(_configurationContext.RpcUsername, _configurationContext.RpcPassword);
            webRequest.ContentType = "application/json-rpc";
            webRequest.Method = "POST";
            byte[] byteArray = jsonRpcRequest.GetBytes();

            using (Stream dataStream = await webRequest.GetRequestStreamAsync())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Dispose();
            }

            string result;

            using (WebResponse webResponse = await webRequest.GetResponseAsync())
            {
                using (Stream stream = webResponse.GetResponseStream())
                {
                    if (stream != null)
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            result = reader.ReadToEnd();
                            reader.Dispose();
                        }
                    }
                    else
                    {
                        result = "Error";
                    }
                }
            }

            return JsonConvert.DeserializeObject<ResponseInfo<TOut>>(result);
        }

        #endregion
    }
}
