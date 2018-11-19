using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class SearchForm : Form
    {

        private FacebookAppManager m_FacebookManager;
        private Form m_OpenedBy;
        private string m_TextToFind;

        public SearchForm(FacebookAppManager i_FacebookManager, Form i_OpenedBy)
        {
            m_FacebookManager = i_FacebookManager;
            m_OpenedBy = i_OpenedBy;
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
                foreach (User user in m_FacebookManager.Friends)
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
                foreach (Group group in m_FacebookManager.Groups)
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
                foreach (Page page in m_FacebookManager.LikedPages)
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
                foreach (Event myEvent in m_FacebookManager.Events)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_OpenedBy.Show();
        }
    }
}
