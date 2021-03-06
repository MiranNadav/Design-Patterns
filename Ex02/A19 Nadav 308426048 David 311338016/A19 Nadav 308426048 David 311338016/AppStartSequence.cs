﻿using System.Windows.Forms;
using FacebookWrapper;

namespace A19_Nadav_308426048_David_311338016
{
    public static class AppStartSequence
    {
        public static void StartApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppSettings appSettings = AppSettings.GetAppSettingsInstance();
            string savedAccessToken = appSettings.LastAccessToken;

            if (!string.IsNullOrEmpty(savedAccessToken))
            {
                ConnectRememberdUser connection = new ConnectRememberdUser(savedAccessToken);
                connection.ReconnectRememberdUser();

                if (connection.IsSuccessfulReconnection)
                {
                    LoginResult connectionResult = connection.ConnectionResult;

                    Application.Run(new MainFeedForm(connectionResult, appSettings));
                }
                else
                {
                    appSettings.DeleteAppSettingsFile();
                    DialogResult okWasPressed;
                    okWasPressed = MessageBox.Show("There was a problem while connecting you with your saved setting. Please login again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(new LoginForm());
                }
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
