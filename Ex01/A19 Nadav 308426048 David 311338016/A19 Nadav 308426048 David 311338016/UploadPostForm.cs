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
    public partial class UploadPostForm : Form
    {
        private FacebookAppManager m_FacebookManager;
        private Form m_OpenedBy;

        public UploadPostForm(FacebookAppManager i_FacebookManager, Form i_OpenedBy)
        {
            m_FacebookManager = i_FacebookManager;
            m_OpenedBy = i_OpenedBy;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uploadPostButton_Click(object sender, EventArgs e)
        {
            uploadPost();
        }

        private void uploadPost()
        {
            if (!string.IsNullOrEmpty(textBoxPostDetails.Text))
            {
                try
                {
                    m_FacebookManager.UploadPost(textBoxPostDetails.Text);
                }
                catch (Exception e)
                {
                    Tools.ShowUserErrorMessageBox("Unable to upload post, Exception caught", "Error");
                }
            }
            else
            {
                Tools.ShowUserInformationMessageBox("Please fill in your post status", "Missing Details");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_OpenedBy.Show();
        }
    }
}
