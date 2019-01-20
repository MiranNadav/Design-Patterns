using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Nadav_308426048_David_311338016
{
    public class MostLikedPostsHandler
    {
        private readonly FacebookObjectCollection<Post> m_AllPosts = FacebookAppManager.GetFacebookManagerInstance().Posts;
        public List<Post> m_LikedPostsList = new List<Post>();
        private FilterStrategy m_FilterStrategy;

        public void SetFilterStrategy(FilterStrategy i_FilterStrategy)
        {
            m_FilterStrategy = i_FilterStrategy;
        }

        public void Add (Post i_Post)
        {
            m_LikedPostsList.Add(i_Post);
        }

        public void Filter()
        {
            m_LikedPostsList.Clear();
            if (m_FilterStrategy != null)
            {
                m_FilterStrategy.Filter(m_AllPosts, m_LikedPostsList);
            }
            else
            {
                Console.WriteLine("Unable to filter without a strategy!");
            }
        }
    }

    public abstract class FilterStrategy
    {
        public abstract void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts);
    }

    public class FilterByLikes : FilterStrategy
    {
        public override void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts)
        {
            if (i_PostsList != null)
            {
                foreach (Post post in i_PostsList)
                {
                    if (post.LikedBy.Count > 5)
                    {
                        i_FilteredPosts.Add(post);
                    }
                }
            }
        }
    }

    public class FilterByComments : FilterStrategy
    {
        public override void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts)
        {
            if (i_FilteredPosts != null)
            {
                foreach (Post post in i_PostsList)
                {
                    if (post.Comments.Count > 5)
                    {
                        i_FilteredPosts.Add(post);
                    }
                }
            }
        }
    }

    public class FilterByLikesAndComments : FilterStrategy
    {
        public override void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts)
        {
            if (i_FilteredPosts != null)
            {
                foreach (Post post in i_PostsList)
                {
                    if (post.LikedBy.Count > 5 && post.Comments.Count > 5)
                    {
                        i_FilteredPosts.Add(post);
                    }
                }
            }
        }
    }
}
