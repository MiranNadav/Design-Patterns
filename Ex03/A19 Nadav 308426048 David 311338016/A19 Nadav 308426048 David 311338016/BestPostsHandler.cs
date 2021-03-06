﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public class BestPostsHandler
    {
        private static readonly int sr_MinAmountOfLikesAndComments = 5;
        private readonly FacebookObjectCollection<Post> m_AllPosts = FacebookAppManager.GetFacebookManagerInstance().Posts;
        public List<Post> m_LikedPostsList = new List<Post>();
        private IFilterStrategy m_FilterStrategy;

        public void SetFilterStrategy(IFilterStrategy i_FilterStrategy)
        {
            m_FilterStrategy = i_FilterStrategy;
        }

        public void Add(Post i_Post)
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

        public interface IFilterStrategy
        {
            void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts);
        }

        public class FilterByLikes : IFilterStrategy
        {
            public void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts)
            {
                if (i_PostsList != null)
                {
                    foreach (Post post in i_PostsList)
                    {
                        if (post.LikedBy.Count > sr_MinAmountOfLikesAndComments)
                        {
                            i_FilteredPosts.Add(post);
                        }
                    }
                }
            }
        }

        public class FilterByComments : IFilterStrategy
        {
            public void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts)
            {
                if (i_FilteredPosts != null)
                {
                    foreach (Post post in i_PostsList)
                    {
                        if (post.Comments.Count > sr_MinAmountOfLikesAndComments)
                        {
                            i_FilteredPosts.Add(post);
                        }
                    }
                }
            }
        }

        public class FilterByLikesAndComments : IFilterStrategy
        {
            public void Filter(FacebookObjectCollection<Post> i_PostsList, List<Post> i_FilteredPosts)
            {
                if (i_FilteredPosts != null)
                {
                    foreach (Post post in i_PostsList)
                    {
                        if (post.LikedBy.Count > sr_MinAmountOfLikesAndComments && post.Comments.Count > sr_MinAmountOfLikesAndComments)
                        {
                            i_FilteredPosts.Add(post);
                        }
                    }
                }
            }
        }
    }
}
