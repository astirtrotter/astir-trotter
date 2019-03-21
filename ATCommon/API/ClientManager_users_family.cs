using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void GetFamily(string userId, Action<FamilyResponse> callback)
        {
            RestRequest request = new RestRequest("users/:userId/family", Method.GET);
            request.AddUrlSegment("userId", userId);
            client.ExecuteAsync<FamilyResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}