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
            m_AppSettings = AppSettings.GetAppSettingsInstance();
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
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
                initializeMainFeedForm();
            }
            else
            {
                MessageBox.Show("Login was unsuccessful", "Login Failed");
            }
        }

        private void initializeMainFeedForm()
        {
            MainFeedForm mainFeedForm = new MainFeedForm(m_LoggedinUser, m_AppSettings);
            this.Hide();
            mainFeedForm.ShowDialog();
        }
    }
}
