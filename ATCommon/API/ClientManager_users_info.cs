using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void GetUser(string userId, Action<UserResponse> callback)
        {
            RestRequest request = new RestRequest("users/:userId", Method.GET);
            request.AddUrlSegment("userId", userId);
            client.ExecuteAsync<UserResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}