using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Nadav_308426048_David_311338016
{
    class ConnectRememberdUser
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
            //TODO: should this (connect) be static? 
            try
            {
                Connect connect = new Connect(m_SavedAccessToken);
                LoginResult connectionResult = connect.ConnectionResult;
                ConnectionResult = connectionResult;
                IsSuccessfulReconnection = true;
            }
            catch (Exception)
            {
                IsSuccessfulReconnection = false;
            }
        }
    }
}
