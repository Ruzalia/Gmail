using System.Configuration;

namespace GmailTest.Framework.Configuration
{
    public class ConfigManager
    {
        public static string TestUrl
        {
            get
            {
                return string.Format("{0}://{1}", ProtocolName, HostName +
                    ConfigurationManager.AppSettings["loginPath"] + ConfigurationManager.AppSettings["loginParametersAndValues"]);
            }
        }

        public static string Username
        {
            get
            {
                return ConfigurationManager.AppSettings["Username"];
            }
        }

        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["Password"];
            }
        }

        public static string HostName
        {
            get { return ConfigurationManager.AppSettings["HostName"]; }
        }

        public static string ProtocolName
        {
            get
            {
                return ConfigurationManager.AppSettings["ProtocolName"];
            }
        }

        public static string BrowserType
        {
            get { return ConfigurationManager.AppSettings["browserType"]; }
        }
    }
}
