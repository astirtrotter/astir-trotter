using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void GetUserFamily(string userId, Action<FamilyResponse> callback)
        {
            IRestRequest request = new RestRequest("users/:userId/family", Method.GET)
                .AddUrlSegment("userId", userId);
            client.ExecuteAsync<FamilyResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}