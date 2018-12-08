using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class FriendsBirthdayForm : Form
    {
        public User m_GeneratedFriend { get; set; }

        private readonly FacebookAppManager r_FacebookManager;
        private Form m_OpenedBy;

        public FriendsBirthdayForm(Form i_OpenedMe)
        {
            m_OpenedBy = i_OpenedMe;
            r_FacebookManager = FacebookAppManager.GetFacebookManagerInstance();
            InitializeComponent();
        }

        private void friendRandomGeneratorButton_Click(object sender, EventArgs e)
        {
            fetchAFriendsName();
        }

        private void fetchAFriendsName()
        {
            m_GeneratedFriend = r_FacebookManager.GenerateAFriend();
            FriendNameTextBox.Text = m_GeneratedFriend.FirstName + " " + m_GeneratedFriend.LastName;
        }

        private void checkIfBirthdayIsCorrect()
        {
            if (m_GeneratedFriend != null)
            {
                DateTime myDate = DateTime.ParseExact(m_GeneratedFriend.Birthday, "MM/dd/yyyy", null);
                if (birthDatePickTime.Value.Year == myDate.Year &&
                    birthDatePickTime.Value.Month == myDate.Month &&
                    birthDatePickTime.Value.Day == myDate.Day)
                {
                    MessageBoxHandler.ShowUserInformationMessageBox("You are right, you really know your friends!!", "Success");
                }
                else if (birthDatePickTime.Value.Year == myDate.Year &&
                    birthDatePickTime.Value.Month == myDate.Month)
                {
                    MessageBoxHandler.ShowUserInformationMessageBox("You were close, you got the year and month correctly..", "Almost");
                }
                else
                {
                    MessageBoxHandler.ShowUserInformationMessageBox("You are wrong...", "Wrong answer");
                }
            }
        }

        private void checkIfCorrectBirthdayButton_Click(object sender, EventArgs e)
        {
            checkIfBirthdayIsCorrect();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_OpenedBy.Show();
        }

        private void FriendsBirthdayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_OpenedBy.Show();
        }
    }
}
