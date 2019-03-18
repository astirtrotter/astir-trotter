using ATCommon.Models;

namespace ATCommon.Responses
{
    public class LoginResponse : _Response
    {
        public string token { get; set; }
        public User user { get; set; }
    }
}
