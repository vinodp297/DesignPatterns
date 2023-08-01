using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignDemo
{
    public sealed class ConfigurationManager
    {
        private static readonly ConfigurationManager Instance = new ConfigurationManager();

        private ConfigurationManager()
        {
            LoadConfigurationSettings();
        }

        private Dictionary<string, string> _configuration = new Dictionary<string, string>();

        public static ConfigurationManager GetConfigurationManagerInstance() { return Instance; }

        private void LoadConfigurationSettings()
        {
            _configuration["Connectionstring"] = "Sample Connection";
            _configuration["Loglevel"] = "1";
        }

        public string GetConfigurationSettings(string key)
        {
            if (_configuration.ContainsKey(key))
                return _configuration[key];

            return null;
        }

    }
}
