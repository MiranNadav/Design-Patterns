using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class SearchForm : ReturnableForm
    {
        private string m_TextToFind;

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
            }
            else
            {
                MessageBox.Show("Please enter phrase to search", "Missing Input");
            }
        }

        private void cleanAllFindings()
        {
            listBoxFriendsPostsFindings.Items.Clear();
            listBoxEventsFindings.Items.Clear();
            listBoxGroupsPostsFindings.Items.Clear();
            listBoxPagesFindings.Items.Clear();
        }

        private void setFriendPostsFindings()
        {
            if (friendsFindingsIncludeCheckBox.Checked)
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
                            }
                        }
                    }
                }
            }
        }

        private void setGroupsFindings()
        {
            if (groupsFindingsIncludeCheckBox.Checked)
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
                            }
                        }
                    }
                }
            }
        }

        private void setPagesFindings()
        {
            if (pageFindingsIncludeCheckBox.Checked)
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
                            }
                        }
                    }
                }
            }
        }

        private void setEventsFindings()
        {
            if (eventsFindingsIncludeCheckBox.Checked)
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
