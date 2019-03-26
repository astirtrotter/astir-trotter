using ATCommon.Models;
using System.Collections.Generic;

namespace ATCommon.Global
{
    public static class Constants
    {
        #region api
        public const string BASE_URL = "http://localhost:8888";
        public const string API_URL = "/api/v1";
        public const string USER_AGENT = "Astir Trotter";
        public const string TOKEN_PREFIX = "Bearer ";
        #endregion

        #region seed
        public static bool hasSeed = false;
        public static List<_Gender> genders;
        public static List<_Party> parties;
        public static List<_Nationality> nationalities;
        public static List<_OriginClass> classOrigins;
        public static List<_OriginSocial> socialOrigins;
        public static List<_OriginNational> nationalOrigins;
        public static List<_Relationship> relationships;
        #endregion

        #region page
        public const string DASHBOARD = "Dashboard";
        public const string FAMILY_TREE = "Family Tree";
        public const string FAMILY_TABLE = "Family Table";
        #endregion

        #region message
        public static class Messages
        {
            public static class Info
            {
                public const string Title = "Info";
                public const string SignupSuccess = "You have successfully signed up. Now you can log in.";
            }

            public static class Warning
            {
                public const string Title = "Warning";
                public const string InvalidInput = "Invalid fields: \n\n";
                public const string ActionFailed = "Action failed. \n\nReason:\n";
            }

            public static class Error
            {
                public const string Title = "Error";
                public const string ActionFailed = "Action failed. \n\nReason:\n";
            }
        }
        #endregion
    }
}
