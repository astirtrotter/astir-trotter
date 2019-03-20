using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void GetSeed(Action<SeedResponse> callback)
        {
            RestRequest request = new RestRequest("config/seed", Method.GET);
            client.ExecuteAsync<SeedResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}