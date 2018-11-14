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
        public bool SettingsWereSaved { get; set; }

        public AppSettings()
        {
            // Defualt Values 
            FilePath = @"C:\Users\shuhs\Desktop.AppSettings.txt";
            LastWindowLocation = new Point(300, 300);
            LastWindowSize = new Size(300, 300);
            RememberUser = false;
            LastAccessToken = null;
            SettingsWereSaved = File.Exists(FilePath) && new FileInfo(FilePath).Length != 0;
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

        public AppSettings ReadSavedSettingsFromFile()
        {
            using (StreamReader appSettingsFile = new StreamReader(FilePath))
            {
                //TODO: should use try catch?
                JsonSerializer serializer = new JsonSerializer();
                AppSettings appSettingsFromFile = (AppSettings)serializer.Deserialize(appSettingsFile, typeof(AppSettings));

                return appSettingsFromFile;
            }
        }
    }
}

