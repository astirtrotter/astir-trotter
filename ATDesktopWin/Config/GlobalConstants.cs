using ATCommon.Models;
using System.Collections.Generic;

namespace ATDesktopWin.Config
{
    public static class GlobalConstants
    {
        // seed
        public static bool hasSeed = false;
        public static List<_Gender> genders;
        public static List<_Party> parties;
        public static List<_Nationality> nationalities;
        public static List<_OriginClass> classOrigins;
        public static List<_OriginSocial> socialOrigins;
        public static List<_OriginNational> nationalOrigins;

        // user
        public static string token;
        public static User user;
    }
}
