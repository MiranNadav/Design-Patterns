using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;

namespace A19_Nadav_308426048_David_311338016
{
    class Connect
    {
        public LoginResult ConnectResult { get; set; }
        public string AccessToke { get; set; }

        public Connect(string i_AccessToken)
        {
            AccessToke = i_AccessToken;
            ConnectResult = FacebookService.Connect(i_AccessToken);
        }
    }
}
