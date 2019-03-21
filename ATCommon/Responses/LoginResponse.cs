using ATCommon.Models;

namespace ATCommon.Responses
{
    public class LoginResponse : UserResponse
    {
        public string token { get; set; }
    }
}
