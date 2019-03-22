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
            string details, string diedDay, byte[] picture, Action<LoginResponse, string> callback)
        {
            IRestRequest request = new RestRequest("auth/signup", Method.POST)
                //.AddParameter("userId", userId, ParameterType.RequestBody)
                //.AddParameter("password", password, ParameterType.RequestBody)
                //.AddParameter("firstName", firstName, ParameterType.RequestBody)
                //.AddParameter("lastName", lastName, ParameterType.RequestBody)
                //.AddParameter("gender", gender, ParameterType.RequestBody)
                //.AddParameter("birthday", birthday, ParameterType.RequestBody);
                .AddJsonBody(new
                 {
                     userId = userId,
                     password = password,
                     firstName = firstName,
                     lastName = lastName,
                     nickName = nickName,
                     gender = gender,
                     birthday = birthday,
                     address = address,
                     birthPlace = birthPlace,
                     party = party,
                     nationality = nationality,
                     nationalOrigin = nationalOrigin,
                     classOrigin = classOrigin,
                     socialOrigin = socialOrigin,
                     phoneNumber = phoneNumber,
                     email = email,
                     details = details,
                     diedDay = diedDay
                 });
            //.AddFile("picture", @"D:\Work\remote\mine\AstirTrotter\ATCommon\API\ClientManager_auth_signup.cs");
            client.ExecuteAsync<LoginResponse>(request, res => {
                callback.Invoke(res.Data, GetErrorMessage(res));
            });
        }
    }
}