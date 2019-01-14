using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class SearchForm : ReturnableForm
    {
        private string m_TextToFind;
        private FindingsAggregator m_FindingsAggregator = new FindingsAggregator();

        public SearchForm ()
        {

        }
        public SearchForm(Form i_OpenedBy) : base(i_OpenedBy)
        {
            InitializeComponent();
        }

        private void findRelevantSearchesButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(m_TextToFind))
            {
                cleanAllFindings();
                setEventsFindings();
                setPagesFindings();
                setGroupsFindings();
                setFriendPostsFindings();
                setAllFindingsWindow();
            }
            else
            {
                MessageBox.Show("Please enter phrase to search", "Missing Input");
            }
        }

        private void setAllFindingsWindow()
        {
            foreach(string finding in m_FindingsAggregator)
            {
                listBoxAllFindings.Items.Add(finding);
            }
        }

        private void cleanAllFindings()
        {
            m_FindingsAggregator.ClearFindings();
            listBoxAllFindings.Items.Clear();
            listBoxFriendsPostsFindings.Items.Clear();
            listBoxEventsFindings.Items.Clear();
            listBoxGroupsPostsFindings.Items.Clear();
            listBoxPagesFindings.Items.Clear();
        }

        private void setFriendPostsFindings()
        {
            if (friendsFindingsIncludeCheckBox.Checked && FacebookAppManager.Friends != null)
            {
                foreach (User user in FacebookAppManager.Friends)
                {
                    foreach (Post post in user.Posts)
                    {
                        if (!string.IsNullOrEmpty(post.Message))
                        {
                            if (post.Message.Contains(m_TextToFind))
                            {
                                listBoxFriendsPostsFindings.Items.Add(post.Message);
                                m_FindingsAggregator.AddFinding(post.Message, SearchFinding.TypeEnum.Post);

                            }
                        }
                    }
                }
            }
        }

        private void setGroupsFindings()
        {
            if (groupsFindingsIncludeCheckBox.Checked && FacebookAppManager.Groups != null)
            {
                foreach (Group group in FacebookAppManager.Groups)
                {
                    foreach (Post post in group.WallPosts)
                    {
                        if (!string.IsNullOrEmpty(post.Message))
                        {
                            if (post.Message.Contains(m_TextToFind))
                            {
                                listBoxGroupsPostsFindings.Items.Add(post.Message);
                                m_FindingsAggregator.AddFinding(post.Message, SearchFinding.TypeEnum.Group);

                            }
                        }
                    }
                }
            }
        }

        private void setPagesFindings()
        {
            if (pageFindingsIncludeCheckBox.Checked && FacebookAppManager.LikedPages != null)
            {
                foreach (Page page in FacebookAppManager.LikedPages)
                {
                    foreach (Post post in page.WallPosts)
                    {
                        if (!string.IsNullOrEmpty(post.Message))
                        {
                            if (post.Message.Contains(m_TextToFind))
                            {
                                listBoxPagesFindings.Items.Add(post.Message);
                                m_FindingsAggregator.AddFinding(post.Message, SearchFinding.TypeEnum.Page);

                            }
                        }
                    }
                }
            }
        }

        private void setEventsFindings()
        {
            if (eventsFindingsIncludeCheckBox.Checked && FacebookAppManager.Events != null)
            {
                foreach (Event myEvent in FacebookAppManager.Events)
                {
                    foreach (Post post in myEvent.WallPosts)
                    {
                        if (!string.IsNullOrEmpty(post.Message))
                        {
                            if (post.Message.Contains(m_TextToFind))
                            {
                                listBoxEventsFindings.Items.Add(post.Message);
                                m_FindingsAggregator.AddFinding(post.Message, SearchFinding.TypeEnum.Event);
                            }
                        }
                    }
                }
            }
        }

        private void textToFindTextBox_TextChanged(object sender, EventArgs e)
        {
            m_TextToFind = textToFindTextBox.Text;
        }
    }
}
