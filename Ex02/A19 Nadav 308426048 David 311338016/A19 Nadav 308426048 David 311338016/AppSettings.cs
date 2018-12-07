using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace A19_Nadav_308426048_David_311338016
{
    class AppSettings
    {
        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public string FilePath { get; set; }

        private static AppSettings s_AppSettingsInstance = null;
        private static readonly object sr_InstanceLockContext = new object();

        public static AppSettings GetAppSettingsInstance()
        {
            if (s_AppSettingsInstance == null)
            {
                lock(sr_InstanceLockContext)
                {
                    if (s_AppSettingsInstance == null)
                    {
                        s_AppSettingsInstance = loadSettingsFromFileOrUseDefualtValues();
                    }
                }
            }

            return s_AppSettingsInstance;
        }

        [JsonConstructor]
        private AppSettings(string i_filePath)
        {
            // Defualt Values 
            FilePath = i_filePath;
            LastWindowLocation = new Point(100, 100);
            LastWindowSize = new Size(933, 520);
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveAppSettingsToFile()
        {
            JsonSerializer serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            using (StreamWriter fileToWriteTo = new StreamWriter(FilePath))
            {
                using (JsonWriter writer = new JsonTextWriter(fileToWriteTo))
                {
                    serializer.Serialize(writer, this);
                }
            }
        }

        private static AppSettings loadSettingsFromFileOrUseDefualtValues()
        {
            AppSettings appSettings = null;
            string[] paths = { Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "facebookAppSettings" };
            string filePath = Path.Combine(paths);

            try
            {
                using (StreamReader appSettingsFile = File.OpenText(filePath))
                {
                    using (JsonTextReader reader = new JsonTextReader(appSettingsFile))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        appSettings = (AppSettings)serializer.Deserialize(appSettingsFile, typeof(AppSettings));
                    }
                }

                return appSettings;
            }
            catch (Exception)
            {
                appSettings = new AppSettings(filePath);

                return appSettings;
            }
        }

        public void DeleteAppSettingsFile()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
    }
}