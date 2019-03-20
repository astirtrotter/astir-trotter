using ATCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDesktopWin.Config
{
    public static class Global
    {
        // seed
        public static bool hasSeed = false;
        public static List<_Gender> genders;
        public static List<_Party> parties;
        public static List<_Nationality> nationalities;
        public static List<_OriginClass> classOrigins;
        public static List<_OriginSocial> socialOrigins;
        public static List<_OriginNational> nationalOrigins;

        // token
        public static string token;

        // user
        public static User user;
    }
}
