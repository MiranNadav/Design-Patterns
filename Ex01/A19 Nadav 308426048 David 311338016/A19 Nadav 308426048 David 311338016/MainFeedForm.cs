using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    partial class MainFeedForm : Form
    {

        private LoginResult m_LoggeInResult;
        private User m_CurrentUser;
        private enum DayStatus { morning, evening, afternoon }
        private DayStatus m_CurrentDayStatus;
        private AppSettings m_AppSettings;

        public MainFeedForm(LoginResult i_Result, AppSettings i_AppSettings)
        {
            m_LoggeInResult = i_Result;
            m_CurrentUser = m_LoggeInResult.LoggedInUser;
            m_AppSettings = i_AppSettings;
            InitializeComponent();
            fetchBasicDetails();

        }

        private void fetchBasicDetails()
        {
            fetchProfilePicture();
            fetchWelcomeMessage();
        }

        private void fetchWelcomeMessage()
        {
            setDayStatus();

            WelcomeLabel.Text = string.Format("Hello {0} {1}, good {2}", m_CurrentUser.FirstName, m_CurrentUser.LastName, m_CurrentDayStatus);
        }

        private void fetchProfilePicture()
        {
            ProfilePictureBox.LoadAsync(m_CurrentUser.PictureNormalURL);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (m_AppSettings.RememberUser)
            {
                //m_AppSettings.LastWindowSize = this.Size;
                //m_AppSettings.LastWindowLocation = this.Location;
                //m_AppSettings.LastAccessToken = m_LoggeInResult.AccessToken;
                ////m_LoggeInResult.LoggedInUser.i
                m_AppSettings.SaveSettingsToDataBase();
            }
        }

        private void setDayStatus()
        {
            int Hour = DateTime.Now.Hour;
            if (Hour >= 6 && Hour < 12)
            {
                m_CurrentDayStatus = DayStatus.morning;
            }
            else if (Hour >= 12 && Hour < 18)
            {
                m_CurrentDayStatus = DayStatus.afternoon;
            }
            else
            {
                m_CurrentDayStatus = DayStatus.evening;
            }
        }

        private void fetchPosts_Click(object sender, EventArgs e)
        {
            fetchAllPosts();
        }

        private void fetchAllPosts()
        {
            foreach(Post post in m_CurrentUser.Posts)
            {
                listBoxPosts.Items.Add(post.Caption);
            }
        }
    }
}
