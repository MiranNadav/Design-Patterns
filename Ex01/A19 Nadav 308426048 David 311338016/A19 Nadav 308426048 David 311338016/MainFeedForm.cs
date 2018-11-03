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
    public partial class MainFeedForm : Form
    {

        private User m_CurrentUser;
        private enum DayStatus { morning, evening, afternoon }
        private DayStatus m_CurrentStatus;
        public MainFeedForm(User i_User)
        {
            m_CurrentUser = i_User;
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

            WelcomeLabel.Text = string.Format("Hello {0} {1}, good {2}", m_CurrentUser.FirstName, m_CurrentUser.LastName, m_CurrentStatus);
        }

        private void setDayStatus()
        {
            int Hour = DateTime.Now.Hour;
            if (Hour >= 6 && Hour < 12)
            {
                m_CurrentStatus = DayStatus.morning;
            }
            else if (Hour >= 12 && Hour < 18)
            {
                m_CurrentStatus = DayStatus.afternoon;
            }
            else
            {
                m_CurrentStatus = DayStatus.evening;
            }
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
    }
}
