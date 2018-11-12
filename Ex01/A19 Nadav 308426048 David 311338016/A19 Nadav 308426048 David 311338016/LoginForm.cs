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

namespace A19_Nadav_308426048_David_311338016
{
    partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.IsLoginValid)
            {
                AppSettings appSettings = new AppSettings
                {
                    RememberUser = rememberMeCheckBox.Checked
                };

                LoginResult loggeInResult= login.LoginResult;
                MainFeedForm mainFeedForm = new MainFeedForm(loggeInResult, appSettings);
                this.Hide();
                mainFeedForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Shit on your face");
            }
        }

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
