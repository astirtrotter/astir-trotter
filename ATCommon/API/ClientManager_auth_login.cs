using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void Login(string userId, string password, Action<LoginResponse> callback)
        {
            IRestRequest request = new RestRequest("auth/login", Method.POST)
                .AddJsonBody(new
                {
                    userId = userId,
                    password = password
                });
            client.ExecuteAsync<LoginResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}