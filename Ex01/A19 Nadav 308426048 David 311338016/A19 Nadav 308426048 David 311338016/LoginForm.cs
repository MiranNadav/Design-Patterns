using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace A19_Nadav_308426048_David_311338016
{
    partial class LoginForm : Form
    {
        private AppSettings m_AppSettings;
        private LoginResult m_LoggedinUser;

        public LoginForm()
        {
            //TODO: should there be a static methode who check if settings where saved inside app setting instead of creating a new object?
            m_AppSettings = new AppSettings();
            bool isUserRememberd = m_AppSettings.SettingsWereSaved;

            if (isUserRememberd)
            {
                reconnectUser();
            }
            else
            {
                InitializeComponent();
            }
        }

        private void reconnectUser()
        {
            m_AppSettings = m_AppSettings.ReadSavedSettingsFromFile();
            string accessToken = m_AppSettings.LastAccessToken;
            //TODO: should this (connect) be static? 
            Connect connect = new Connect(accessToken);
            m_LoggedinUser = connect.ConnectResult;
            initialMainFeedForm();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        private void doLogin()
        {
            Login login = new Login();
            m_LoggedinUser = login.LoginResult;

            if (login.IsLoginValid)
            {
                m_AppSettings.RememberUser = rememberMeCheckBox.Checked;
                initialMainFeedForm();
            }
            else
            {
                MessageBox.Show("Login was unsuccessful", "Login Failed");
            }
        }

        private void initialMainFeedForm()
        {
            MainFeedForm mainFeedForm = new MainFeedForm(m_LoggedinUser, m_AppSettings);
            this.Hide();
            mainFeedForm.ShowDialog();
        }

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
