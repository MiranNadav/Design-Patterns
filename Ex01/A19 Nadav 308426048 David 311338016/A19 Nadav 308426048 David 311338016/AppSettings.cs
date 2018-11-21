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
using System.Reflection;

namespace A19_Nadav_308426048_David_311338016
{
    class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        public string FilePath { get; set; }

        [JsonConstructor]
        private AppSettings(string i_filePath)
        {
            // Defualt Values 
            FilePath = i_filePath;
            LastWindowLocation = new Point(300, 300);
            LastWindowSize = new Size(802, 482);
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

        public static AppSettings loadSettingsFromFileOrUseDefualtValues()
        {
            AppSettings appSettings;
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
            catch (Exception e)
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

