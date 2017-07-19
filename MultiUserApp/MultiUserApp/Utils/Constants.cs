using System;
using System.Collections.Generic;
using System.Text;
using Amazon;



namespace MultiUserApp.Utils

{
    public class Constants
    {
        public static string APP_NAME = "MultiUserApp";

        public static string COGNITO_IDENTITY_POOL_ID = "us-west-2:2c86c1e9-5a70-4a47-83bf-c07824216b95";
        public static RegionEndpoint COGNITO_REGION = RegionEndpoint.USWest2;
        public static RegionEndpoint SIMPLEDB_REGION = RegionEndpoint.USWest2;

        enum Colors { Red, Yellow, Blue};

        // OAuth
        // For Google login, configure at https://console.developers.google.com/
        public static string iOSClientId = "222437492723-k2pao4agnmfr3bu0o91ljhivb4jecbqa.apps.googleusercontent.com";
        public static string AndroidClientId = "222437492723-ekcqd4r6c6u9lqk97cg7brqsgjr8nnfb.apps.googleusercontent.com";
        public static string UWPClientId = "222437492723-5cf57gcnnfroei8j1ubp558tksavh9s2.apps.googleusercontent.com";

        // These values do not need changing
        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
        public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
        public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string iOSRedirectUrl = "com.googleusercontent.apps.222437492723-k2pao4agnmfr3bu0o91ljhivb4jecbqa:/oauth2redirect";
        public static string AndroidRedirectUrl = "com.googleusercontent.apps.222437492723-ekcqd4r6c6u9lqk97cg7brqsgjr8nnfb:/oauth2redirect";
        public static string UWPRedirectUrl = "com.googleusercontent.apps.222437492723-5cf57gcnnfroei8j1ubp558tksavh9s2:/oauth2redirect";
    }
}
