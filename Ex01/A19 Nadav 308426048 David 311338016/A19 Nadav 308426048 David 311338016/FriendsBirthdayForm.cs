using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class FriendsBirthdayForm : Form
    {

        public User m_CurrentUser { get; set; }
        public User m_GeneratedFriend { get; set; }


        public FriendsBirthdayForm()
        {
            InitializeComponent();
        }

        private void friendRandomGeneratorButton_Click(object sender, EventArgs e)
        {
            fetchAFriendsName();
        }

        private void fetchAFriendsName()
        {
            int amountOfFriends = m_CurrentUser.Friends.Count;
            Random random = new Random();
            int friendIndex = random.Next(0, amountOfFriends);
            m_GeneratedFriend = m_CurrentUser.Friends[friendIndex];
            FriendNameTextBox.Text = m_GeneratedFriend.FirstName + " " + m_GeneratedFriend.LastName;
        }

        private void checkIfBirthdayIsCorrect()
        {
            DateTime myDate = DateTime.ParseExact(m_GeneratedFriend.Birthday, "MM/dd/yyyy", null);
            if (birthDatePickTime.Value.Year == myDate.Year && 
                birthDatePickTime.Value.Month == myDate.Month && 
                birthDatePickTime.Value.Day == myDate.Day)
            {
                MessageBox.Show("You are right, you really know your friends!!", "Success");
            }
            else if (birthDatePickTime.Value.Year == myDate.Year &&
                birthDatePickTime.Value.Month == myDate.Month)
            {
                MessageBox.Show("You were close, you got the year and month correctly..", "Almost");
            }
            else
            {
                MessageBox.Show("You are wrong...", "Wrong answer");
            }
        }

        private void checkIfCorrectBirthdayButton_Click(object sender, EventArgs e)
        {
            checkIfBirthdayIsCorrect();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
   
    }
}
