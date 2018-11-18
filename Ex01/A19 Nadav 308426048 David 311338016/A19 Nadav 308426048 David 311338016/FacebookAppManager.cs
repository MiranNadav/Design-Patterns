using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Nadav_308426048_David_311338016
{
    public class FacebookAppManager
    {
        public User CurrentUser { get; set; }
        public FacebookObjectCollection<User> Friends { get; set; }
        public FacebookObjectCollection<Post> Posts { get; set; }
        public FacebookObjectCollection<Event> Events { get; set; }
        public FacebookObjectCollection<Page> LikedPages { get; set; }
        public FacebookObjectCollection<Album> Albums { get; set; }


        public FacebookAppManager(User i_CurrentUser)
        {
            CurrentUser = i_CurrentUser;
            setAll();
        }

        private void setAll()
        {
            setFriends();
            setPosts();
            setEvents();
            setPages();
            setAlbums();

        }

        private void setAlbums()
        {
            try
            {
                Albums = CurrentUser.Albums;
            }
            finally { }
        }

        private void setPages()
        {
            try
            {
                LikedPages = CurrentUser.LikedPages;
            }
            finally{}
        }

        private void setEvents()
        {
            try
            {
                Events = CurrentUser.Events;
            }
            catch (Exception e) { }
            
        }

        private void setPosts()
        {
            try
            {
                Posts = CurrentUser.Posts;
            }
            finally { }
        }

        private void setFriends()
        {
            try
            {
                Friends = CurrentUser.Friends;
            }
            finally { }
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
    }
}
