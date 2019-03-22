using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void GetUserInfo(string userId, Action<UserResponse> callback)
        {
            IRestRequest request = new RestRequest("users/:userId", Method.GET)
                .AddUrlSegment("userId", userId);
            client.ExecuteAsync<UserResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}