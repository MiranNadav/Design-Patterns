using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper;

namespace A19_Nadav_308426048_David_311338016
{
    public class Login
    {
        private static readonly string r_AppID = "249075922425991";
        private static readonly string[] r_Permissions = { "email", "user_photos", "user_likes", "user_birthday", "user_friends", "user_posts", "user_photos", "user_events", "publish_to_groups", "manage_pages", "publish_pages" };
        private string m_AccessToken;

        public LoginResult LoginResult { get; set; }

        public bool IsLoginValid { get; set; }

        public Login()
        {
            doLogin();
        }

        private void doLogin()
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
