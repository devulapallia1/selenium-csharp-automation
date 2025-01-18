using System.IO;
using Newtonsoft.Json.Linq;

namespace Automation.Utils
{
    public static class ConfigReader
    {
        public static string GetConfigValue(string key)
        {
            var json = File.ReadAllText("appsettings.json");
            var jObject = JObject.Parse(json);
            return jObject[key]?.ToString();
        }
    }
}
