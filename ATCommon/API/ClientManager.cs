using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            client.AddDefaultHeader("Content-Type", "application/json");
            client.UserAgent = "Astir Trotter (Win)";
        }
    }
}
