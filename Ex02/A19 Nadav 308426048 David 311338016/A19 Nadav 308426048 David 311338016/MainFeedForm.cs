using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    partial class MainFeedForm : Form
    {
        private LoginResult m_LoggedInResult;

        private enum DayStatus
        {
            morning,
            evening,
            afternoon
        }

        private DayStatus m_CurrentDayStatus;
        private AppSettings m_AppSettings;
        private readonly FacebookAppManager r_FacebookManager;
        private bool m_TryingToLogout;

        public MainFeedForm(LoginResult i_Result, AppSettings i_AppSettings)
        {
            m_TryingToLogout = false;
            m_LoggedInResult = i_Result;
            r_FacebookManager = FacebookAppManager.GetFacebookManagerInstance();
            r_FacebookManager.CurrentUser = i_Result.LoggedInUser;
            m_AppSettings = i_AppSettings;
            InitializeComponent();
            loadSettingsFromAppSettingsFile();
        }

        private void loadSettingsFromAppSettingsFile()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = m_AppSettings.LastWindowLocation;
            this.Size = m_AppSettings.LastWindowSize;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(populateDetails).Start();
            // populateDetails();
        }

        private void populateDetails()
        {
            fetchBasicDetails();
            fetchAllFriends();
            fetchAllLikes();
            //fetchAlbumPictures(); TODO: DELETE (?)
            fetchAllPosts();
            fetchAllEvents();
            fetchAllLikes();
            fetchAllGroups();
            fetchAllFriendsPosts();
        }

        private void fetchBasicDetails()
        {
            fetchProfilePicture();
            fetchWelcomeMessage();
        }

        private void fetchProfilePicture()
        {
            ProfilePictureBox.Invoke(new Action(() => ProfilePictureBox.LoadAsync(r_FacebookManager.CurrentUser.PictureNormalURL)));
            //ProfilePictureBox.LoadAsync(r_FacebookManager.CurrentUser.PictureNormalURL);
        }

        private void fetchWelcomeMessage()
        {
            setDayStatus();
            WelcomeLabel.Invoke(new Action(() => WelcomeLabel.Text = string.Format("Hello {0} {1},\ngood {2}!", r_FacebookManager.CurrentUser.FirstName, r_FacebookManager.CurrentUser.LastName, m_CurrentDayStatus)));
            //WelcomeLabel.Text = string.Format("Hello {0} {1},\ngood {2}!", r_FacebookManager.CurrentUser.FirstName, r_FacebookManager.CurrentUser.LastName, m_CurrentDayStatus);
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

        private void fetchFriendsButton_Click(object sender, EventArgs e)
        {
            fetchAllFriends();
        }

        private void fetchAllFriends()
        {
            foreach (User friend in r_FacebookManager.Friends)
            {
                listViewFriends.Invoke(new Action(() => listViewFriends.Items.Add(friend.FirstName + " " + friend.LastName)));
                //listViewFriends.Items.Add(friend.FirstName + " " + friend.LastName);
            }
        }

        //TODO: should this be deleted? I dont think we use it any more.
        //private void fetchAlbumPictures()
        //{
        //    foreach (Album album in r_FacebookManager.Albums)
        //    {
        //        foreach (Photo photo in album.Photos)
        //        {
        //            PictureBox picbox = new PictureBox();
        //            //TODO: check why this throws exception
        //            //picbox.Invoke(new Action(() => picbox.LoadAsync(photo.PictureNormalURL)));
        //            //picbox.LoadAsync(photo.PictureNormalURL);
        //        }
        //    }
        //}

        private void fetchPosts_Click(object sender, EventArgs e)
        {
            fetchAllPosts();
        }

        private void fetchAllPosts()
        {
            foreach (Post post in r_FacebookManager.Posts)
            {
                if (post.Message != null)
                {
                    listBoxBestPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                    //listBoxPosts.Items.Add(post.Message);
                }
            }
        }

        private void fetchAllEvents()
        {
            if (r_FacebookManager.Events != null)
            {
                foreach (Event fbEvent in r_FacebookManager.Events)
                {
                    if (fbEvent.Name != null)
                    {
                        listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent.Name)));
                        //listBoxEvents.Items.Add(fbEvent.Name);
                    }
                }
            }
        }

        private void myLikesButton_Click(object sender, EventArgs e)
        {
            fetchAllLikes();
        }

        private void fetchAllLikes()
        {
            if (r_FacebookManager.LikedPages != null)
            {
                foreach (Page page in r_FacebookManager.LikedPages)
                {
                    listBoxLikes.Invoke(new Action(() => listBoxLikes.Items.Add(page.Name)));
                    //listBoxLikes.Items.Add(page.Name);
                }
            }
        }

        private void fetchAllGroups()
        {
            if (r_FacebookManager.Groups != null)
            {
                foreach (Group group in r_FacebookManager.Groups)
                {
                    if (group.Name != null)
                    {
                        listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group.Name)));
                        //listBoxGroups.Items.Add(group.Name);
                    }
                }
            }
        }

        private void fetchAllFriendsPosts()
        {
            foreach (Post post in r_FacebookManager.FriendsPosts)
            {
                listBoxFriendsPosts.Invoke(new Action(() => listBoxFriendsPosts.Items.Add(post.Message)));
                //listBoxFriendsPosts.Items.Add(post.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!m_TryingToLogout && !e.CloseReason.Equals(CloseReason.ApplicationExitCall))
            {
                DialogResult userWantToExit = MessageBoxHandler.ShowUserMessageBoxWithResponse("Are you sure you want to exit?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (userWantToExit == DialogResult.Yes)
                {
                    if (m_AppSettings.RememberUser)
                    {
                        saveUserSettings();
                    }

                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void saveUserSettings()
        {
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastAccessToken = m_LoggedInResult.AccessToken;
            m_AppSettings.SaveAppSettingsToFile();
        }

        private DialogResult showUserMessageBox(string messageText, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(messageText, title, buttons, icon);

            return DialogResult;
        }

        private void fetchMostLikedPosts()
        {
            if (!string.IsNullOrEmpty(textBoxLikesLimit.Text)
                 && int.TryParse(textBoxLikesLimit.Text, out int likesLimit))
            {
                foreach (Post post in r_FacebookManager.GetMostLikedPosts(likesLimit))
                {
                    listBoxBestPosts.Items.Add(post.Message.Substring(0, 10) + " - " + post.LikedBy.Count);
                }
            }
            else
            {
                MessageBox.Show("Invalid amount of likes", "Wrong Input");
            }
        }

        private void fetchSameMonthFriends()
        {
            listBoxSameMonthFriends.Items.Clear();
            foreach (User friend in r_FacebookManager.GetSameMonthFriends(pickMonthComboBox.Text))
            {
                listBoxSameMonthFriends.Invoke(new Action(() => listBoxSameMonthFriends.Items.Add(friend.FirstName + " " + friend.LastName)));
                //listBoxSameMonthFriends.Items.Add(friend.FirstName + " " + friend.LastName + " - " + friend.Birthday);
            }
        }

        private void uploadPostButton_Click(object sender, EventArgs e)
        {
            initalizePostForm();
        }

        private void initalizePostForm()
        {
            UploadPostForm uploadPostForm = new UploadPostForm(this);
            this.Hide();
            uploadPostForm.Show();
        }


        private void fetchBestPostsButton_Click(object sender, EventArgs e)
        {
            fetchMostLikedPosts();
        }

        private void fetchSameMonthFriendsButton_Click(object sender, EventArgs e)
        {
            fetchSameMonthFriends();
        }

        private void showAllLikesButton_Click(object sender, EventArgs e)
        {
            showAllLikes();
        }

        private void showAllLikes()
        {
            int totalLikes = r_FacebookManager.GetAmountOfLikes();
            MessageBox.Show("Total Likes:\n" + totalLikes, "Your Likes");
        }

        //TODO: DELETE
        //private void fetchAllPhotosButton_Click(object sender, EventArgs e)
        //{
        //    fetchAlbumPictures();
        //}

        private void openBirthdayGameButton_Click(object sender, EventArgs e)
        {
            initializeFriendsBirthdayForm();
        }

        private void initializeFriendsBirthdayForm()
        {
            FriendsBirthdayForm friendsBirthdayForm = new FriendsBirthdayForm(this);
            this.Hide();
            friendsBirthdayForm.ShowDialog();
        }

        private void searchInAllFacebook_Click(object sender, EventArgs e)
        {
            initalizeSearchForm();
        }

        private void initalizeSearchForm()
        {
            SearchForm friendsBirthdayForm = new SearchForm(this);
            this.Hide();
            friendsBirthdayForm.ShowDialog();
        }

        private void openGalleryButton_Click(object sender, EventArgs e)
        {
            ImageGallery imageGallery = new ImageGallery(this);
            this.Hide();
            imageGallery.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult shouldLogout = MessageBoxHandler.ShowUserMessageBoxWithResponse("Are you sure you want to log out?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (shouldLogout == DialogResult.Yes)
            {
                m_AppSettings.DeleteAppSettingsFile();
                m_AppSettings.RememberUser = false;
                m_TryingToLogout = true;
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void openAboutMeButton_Click(object sender, EventArgs e)
        {
            AboutMe aboutMe = new AboutMe(this);
            this.Hide();
            aboutMe.ShowDialog();
        }
    }
}