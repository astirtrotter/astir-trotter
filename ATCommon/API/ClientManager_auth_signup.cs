using ATCommon.Responses;
using RestSharp;
using System;

namespace ATCommon.API
{
    public partial class ClientManager
    {
        public void Signup(
            string userId, string password, string firstName, string lastName,
            string nickName, string gender, string birthday, string address,
            string birthPlace, string party, string nationality, string nationalOrigin,
            string classOrigin, string socialOrigin, string phoneNumber, string email,
            string moreContactInfo, Action<LoginResponse> callback)
        {
            RestRequest request = new RestRequest("auth/login", Method.POST);
            request.AddJsonBody(new { userId = userId, password = password });
            client.ExecuteAsync<LoginResponse>(request, res => {
                callback.Invoke(res.Data);
            });
        }
    }
}