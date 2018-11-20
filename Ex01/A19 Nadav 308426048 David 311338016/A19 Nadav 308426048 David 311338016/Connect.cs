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
        public LoginResult ConnectionResult { get; set; }
        public string AccessToken { get; set; }

        public Connect(string i_AccessToken)
        {
            AccessToken = i_AccessToken;
            ConnectionResult = FacebookService.Connect(i_AccessToken);
        }
    }
}
