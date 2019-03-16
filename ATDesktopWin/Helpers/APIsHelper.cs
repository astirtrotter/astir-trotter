using System;
using RestSharp;

namespace ATDesktopWin.Helpers
{
    class APIsHelper
    {
        private static APIsHelper _instance;
        public static APIsHelper getInstance()
        {
            if (_instance == null)
            {
                _instance = new APIsHelper();
            }
            return _instance;
        }

        /**********************************************************/

        private RestClient client;

        public APIsHelper()
        {
            client = new RestClient(Config.Backend.API_BASE_URL);
        }

        public RestRequest createRequest(string endpoint)
        {
            return new RestRequest(endpoint);
        }

        public RestRequestAsyncHandle executeAsync<T>(RestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, Method method)
        {
            return client.ExecuteAsync(request, callback, method);
        }
    }
}
