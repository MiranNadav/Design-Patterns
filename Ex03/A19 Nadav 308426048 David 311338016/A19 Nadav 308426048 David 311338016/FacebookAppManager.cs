using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public class FacebookAppManager
    {
        private static readonly object sr_InstanceLockContext = new object();

        private static readonly object sr_InstanceUserLockContext = new object();

        private static FacebookAppManager s_FacebookAppManagerInstance = null;

        private User m_CurrentUser;

        public event Action m_ActivateAfterThreadIsFinished;

        public User CurrentUser
        {
            get
            {
                return m_CurrentUser;
            }

            set
            {
                if (m_CurrentUser == null)
                {
                    lock (sr_InstanceUserLockContext)
                    {
                        if (m_CurrentUser == null)
                        {
                            m_CurrentUser = value;
                            fetchDataFromFacebookUser();
                        }
                    }
                }
                else
                {
                    throw new Exception("user is already connected to facebook in the current seasion");
                }
            }
        }

        private void fetchDataFromFacebookUser()
        {
            ThreadStart fetchDataFromUserThread = setAll;
            fetchDataFromUserThread += () =>
            {
                if (m_ActivateAfterThreadIsFinished != null)
                {
                    m_ActivateAfterThreadIsFinished.Invoke();
                }
            };

            Thread thread = new Thread(fetchDataFromUserThread) { IsBackground = true };
            thread.Start();
        }

        public FacebookObjectCollection<User> Friends { get; set; }

        public FacebookObjectCollection<Post> Posts { get; set; }

        public FacebookObjectCollection<Event> Events { get; set; }

        public FacebookObjectCollection<Page> LikedPages { get; set; }

        public FacebookObjectCollection<Album> Albums { get; set; }

        public FacebookObjectCollection<Group> Groups { get; set; }

        public FacebookObjectCollection<Post> FriendsPosts { get; set; }

        public static FacebookAppManager GetFacebookManagerInstance()
        {
            if (s_FacebookAppManagerInstance == null)
            {
                lock (sr_InstanceLockContext)
                {
                    if (s_FacebookAppManagerInstance == null)
                    {
                        s_FacebookAppManagerInstance = new FacebookAppManager();
                    }
                }
            }

            return s_FacebookAppManagerInstance;
        }

        private FacebookAppManager() // private constructor for singelton
        {
        }

        private void setAll()
        {
            setFriends();
            setPosts();
            setEvents();
            setPages();
            setAlbums();
            setGroups();
            setFriendsPosts();
        }

        private void setGroups()
        {
            try
            {
                Groups = CurrentUser.Groups;
            }
            catch (Exception)
            {
            }
        }

        private void setAlbums()
        {
            try
            {
                Albums = CurrentUser.Albums;
            }
            catch (Exception)
            {
            }
        }

        private void setPages()
        {
            try
            {
                LikedPages = CurrentUser.LikedPages;
            }
            catch (Exception)
            {
            }
        }

        private void setEvents()
        {
            try
            {
                Events = CurrentUser.Events;
            }
            catch (Exception)
            {
            }
        }

        private void setPosts()
        {
            try
            {
                Posts = CurrentUser.Posts;
            }
            catch (Exception)
            {
            }
        }

        private void setFriends()
        {
            try
            {
                Friends = CurrentUser.Friends;
            }
            catch (Exception)
            {
            }
        }

        public void setFriendsPosts()
        {
            FriendsPosts = new FacebookObjectCollection<Post>();
            List<Post> friendsPostsList = new List<Post>();
            if (Friends != null)
            {
                foreach (User user in Friends)
                {
                    foreach (Post post in user.Posts)
                    {
                        if (post.Message != null)
                        {
                            FriendsPosts.Add(post);
                        }
                    }
                }
            }
        }

        public FacebookObjectCollection<Post> GetMostLikedPosts(int i_MaxLikes)
        {
            FacebookObjectCollection<Post> bestPosts = new FacebookObjectCollection<Post>();
            int postLikes;

            foreach (Post post in Posts)
            {
                postLikes = post.LikedBy.Count;
                if (postLikes >= i_MaxLikes && post.Message != null)
                {
                    bestPosts.Add(post);
                }
            }

            return bestPosts;
        }

        public FacebookObjectCollection<User> GetSameMonthFriends(string i_Month)
        {
            FacebookObjectCollection<User> sameMonthFriends = new FacebookObjectCollection<User>();
            string myBirthDayMonth = CurrentUser.Birthday.Substring(0, 2);
            string friendBirthdayMonth;
            foreach (User friend in CurrentUser.Friends)
            {
                friendBirthdayMonth = friend.Birthday.Substring(0, 2);
                if (friendBirthdayMonth == i_Month)
                {
                    sameMonthFriends.Add(friend);
                }
            }

            return sameMonthFriends;
        }

        public void UploadPost(string i_Status)
        {
            CurrentUser.PostStatus(i_Status);
        }

        public int GetAmountOfLikes()
        {
            int totalLikes = 0;
            foreach (Post post in Posts)
            {
                totalLikes += post.LikedBy.Count;
            }

            return totalLikes;
        }

        public User GenerateAFriend()
        {
            int amountOfFriends = Friends.Count;
            Random random = new Random();
            int friendIndex = random.Next(0, amountOfFriends);
            return Friends[friendIndex];
        }

        private void showUnableToFetchMessage()
        {
            MessageBoxHandler.ShowUnableToFetchMessageBox();
        }
    }
}