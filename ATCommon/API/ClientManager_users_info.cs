using ATCommon.Global;
using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void GetUserInfo(string userId, Action<UserResponse, string> callback)
        {
            IRestRequest request = new RestRequest("users/:userId", Method.GET)
                .AddUrlSegment("userId", userId)
                .AddHeader("Authorization", LoginInfo.token);
            client.ExecuteAsync<UserResponse>(request, res => {
                callback.Invoke(res.Data, GetErrorMessage(res));
            });
        }
    }
}