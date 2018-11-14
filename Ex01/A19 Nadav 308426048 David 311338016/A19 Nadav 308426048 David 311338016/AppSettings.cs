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

namespace A19_Nadav_308426048_David_311338016
{
    class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        public AppSettings()
        {

        }

        public void SaveSettingsToDataBase()
        {
            saveAccessToken();
            //string appSettingsJson = new JavaScriptSerializer().Serialize(this.GetType().GetProperties());

        }

        private void saveAccessToken()
        {

            string json = JsonConvert.SerializeObject(this);
            Console.WriteLine(json);
            //string path = @"appSettings.txt";

            //using (Stream stream = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    //TODO: missing clearing the file
            //    byte[] stringToBytes;
            //    stringToBytes = Encoding.ASCII.GetBytes(this.LastAccessToken);
            //    stream.Write(stringToBytes, 0, stringToBytes.Length);
            //}
        }
    }
}

