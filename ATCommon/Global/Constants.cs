using ATCommon.Models;
using System.Collections.Generic;

namespace ATCommon.Global
{
    public static class Constants
    {
        // seed
        public static bool hasSeed = false;
        public static List<_Gender> genders;
        public static List<_Party> parties;
        public static List<_Nationality> nationalities;
        public static List<_OriginClass> classOrigins;
        public static List<_OriginSocial> socialOrigins;
        public static List<_OriginNational> nationalOrigins;

        // messages
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
                public const string NoConnection = "Cannot connect to server. Check your network configuration and try again.";
                public const string NoResponse = "Cannot receive any responses from the server.";
            }
        }
    }
}
