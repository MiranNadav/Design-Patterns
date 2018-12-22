using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public class ConnectRememberdUser
    {
        private string m_SavedAccessToken;

        public bool IsSuccessfulReconnection { get; set; }

        public LoginResult ConnectionResult { get; set; }

        public ConnectRememberdUser(string i_savedAccessToken)
        {
            m_SavedAccessToken = i_savedAccessToken;
        }

        public void ReconnectRememberdUser()
        {
            try
            {
                ConnectionResult = FacebookService.Connect(m_SavedAccessToken);
                IsSuccessfulReconnection = true;
            }
            catch (Exception)
            {
                IsSuccessfulReconnection = false;
            }
        }
    }
}
