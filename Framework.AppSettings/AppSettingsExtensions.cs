using System.Collections.Specialized;

namespace System.Configuration
{
    /// <summary>
    /// ConfigurationManager.AppSettings Extensions
    /// </summary>
    public static class AppSettingsExtensions
    {
        /// <summary>
        /// OverWrite the AppSettings from Environment
        /// </summary>
        /// <param name="appSettings">ConfigurationManager.AppSettings Object</param>
        public static void OverwriteFromEnvironment(this NameValueCollection appSettings)
        {
            foreach (var key in appSettings.AllKeys)
            {
                var value = Environment.GetEnvironmentVariable(key);
                if (!string.IsNullOrEmpty(value))
                {
                    appSettings.Set(key, value);
                }
            }
        }
    }
}
