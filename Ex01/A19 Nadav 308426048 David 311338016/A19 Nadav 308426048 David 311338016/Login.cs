﻿using System;
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
        public LoginResult LoginResult { get; set; }
        public bool IsLoginValid { get; set; }
        static readonly string r_AppID = "249075922425991";
        static readonly string[] r_Permissions = { "email", "user_likes" };
        
        
        public Login()
        {
            DoLogin();
        }

        private void DoLogin()
        {
            LoginResult = FacebookService.Login(r_AppID, r_Permissions);
            IsLoginValid = ValidateLogin();
            if (IsLoginValid)
            {
                m_AccessToken = LoginResult.AccessToken;
            }
        }

        private bool ValidateLogin()
        {
            return string.IsNullOrEmpty(LoginResult.AccessToken) ? false : true;
        }
    }
}