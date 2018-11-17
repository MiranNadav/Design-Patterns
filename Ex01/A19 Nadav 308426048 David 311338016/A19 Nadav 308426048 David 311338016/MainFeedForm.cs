﻿using System;
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
        private FriendsHandler friendsHandler;
        public MainFeedForm(LoginResult i_Result, AppSettings i_AppSettings)
        {
            m_LoggeInResult = i_Result;
            m_CurrentUser = m_LoggeInResult.LoggedInUser;
            m_AppSettings = i_AppSettings;
            InitializeComponent();
            fetchBasicDetails();

        }
        
        //TODO: Add a PopulateDetails method - which puts all details in the main form.
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
                m_AppSettings.LastWindowSize = this.Size;
                m_AppSettings.LastWindowLocation = this.Location;
                m_AppSettings.LastAccessToken = m_LoggeInResult.AccessToken;
                m_AppSettings.SaveAppSettingsToFile();
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
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                } 
            }
        }
        //This function is for the 1st feature
        //It returns only shows your best liked posts (with a given amount of likes)
        private void fetchMostLikedPosts()
        {
            int postLikes;
            if (!string.IsNullOrEmpty(textBoxLikesLimit.Text)
                 && int.TryParse(textBoxLikesLimit.Text, out int likesLimit))
            {
                foreach (Post post in m_CurrentUser.Posts)
                {
                    postLikes = post.LikedBy.Count;
                    if (postLikes >= likesLimit && post.Message != null)
                    {
                        listBoxBestPosts.Items.Add(post.Message.Substring(0,10) + " - " + postLikes);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid amount of likes", "Wrong Input");
            }
        }

        private void fetchSameMonthFriends ()
        {
            listBoxSameMonthFriends.Items.Clear();
            string myBirthDayMonth = m_CurrentUser.Birthday.Substring(0,2);
            string friendBirthdayMonth;
            foreach (User friend in m_CurrentUser.Friends)
            {
                friendBirthdayMonth = friend.Birthday.Substring(0, 2);
                if (friendBirthdayMonth == pickMonthComboBox.Text)
                {
                    listBoxSameMonthFriends.Items.Add(friend.FirstName + " " + friend.LastName + " - " + friend.Birthday);
                }
            }
        }


        private void fetchFriendsButton_Click(object sender, EventArgs e)
        {
            fetchAllFriends();
        }

        private void fetchAllFriends()
        {
            foreach(User friend in m_CurrentUser.Friends)
            {
                listViewFriends.Items.Add(friend.FirstName + " " + friend.LastName);
            }
        }

        private void uploadPostButton_Click(object sender, EventArgs e)
        {
            uploadPost();
        }

        private void uploadPost()
        {
            if (!string.IsNullOrEmpty(textBoxPostDetails.Text))
            {
                m_CurrentUser.PostStatus(textBoxPostDetails.Text);
            }
            else
            {
                MessageBox.Show("Please fill in your post status", "Missing Details");
            }
        }

        private void myLikesButton_Click(object sender, EventArgs e)
        {
            fetchAllLikes();
        }

        private void fetchAllLikes()
        {
            foreach(Page page in m_CurrentUser.LikedPages)
            {
                listBoxLikes.Items.Add(page.Name);
            }
        }

        private void fetchBestPostsButton_Click(object sender, EventArgs e)
        {
            fetchMostLikedPosts();
        }

        private void MainFeedForm_Load(object sender, EventArgs e)
        {

        }

        private void fetchSameMonthFriendsButton_Click(object sender, EventArgs e)
        {
            fetchSameMonthFriends();
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void showAllLikesButton_Click(object sender, EventArgs e)
        {
            showAllLikes();
        }

        private void showAllLikes()
        {
            int totalLikes = 0;
            foreach(Post post in m_CurrentUser.Posts)
            {
                totalLikes += post.LikedBy.Count;
            }
            MessageBox.Show("Total Likes:\n" + totalLikes, "Your Likes");
        }
    }
}