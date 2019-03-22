using ATCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCommon.Global
{
    public static class LoginInfo
    {
        private static string _token;
        public static string token
        {
            get => Constants.TOKEN_PREFIX + _token;
            set => _token = value;
        }

        public static User user;
    }
}
