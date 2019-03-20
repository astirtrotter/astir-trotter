using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void Signup(string userId, string password, Action<LoginResponse> callback)
        {
            RestRequest request = new RestRequest("auth/login", Method.POST);
            request.AddJsonBody(new { userId = userId, password = password });
            client.ExecuteAsync<LoginResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}