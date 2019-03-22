using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATCommon.Global;
using ATCommon.Responses;
using RestSharp;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        private const string BASE_URL = "http://localhost:8888";
        private const string API_URL = "/api/v1";
        
        private static ClientManager _instance;
        public static ClientManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClientManager();
                }
                return _instance;
            }
        }

        private RestClient client;

        private ClientManager()
        {
            client = new RestClient(BASE_URL + API_URL);
            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("Content-Type", "application/json");
            client.UserAgent = Constants.USER_AGENT + ": " + Environment.OSVersion.ToString();
        }

        internal string GetErrorMessage<T>(IRestResponse<T> res) where T: _Response
        {
            if (res.Data != null)
            {
                return null;
            } else
            {
                return "(" + res.StatusDescription + ")\n" + res.ErrorMessage;
            }
        }
    }
}
