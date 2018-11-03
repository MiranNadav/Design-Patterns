using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper;


namespace A19_Nadav_308426048_David_311338016
{
    class Login
    {
        private string m_AccessToken;
        private LoginResult m_LoginResult;
        public bool IsLoginValid { get; set; }
        static readonly string r_AppID = "249075922425991";
        static readonly string[] r_Permissions = { "email" };

        public Login()
        {
            DoLogin();
        }

        private void DoLogin()
        {
            m_LoginResult = FacebookService.Login(r_AppID, r_Permissions);
            IsLoginValid = ValidateLogin();
            if (IsLoginValid)
            {
                m_AccessToken = m_LoginResult.AccessToken;
            }
        }

        private bool ValidateLogin()
        {
            return string.IsNullOrEmpty(m_LoginResult.AccessToken) ? false: true;
        }
    }
}
