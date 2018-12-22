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
    public partial class UploadPostForm : ReturnableForm
    {

        public UploadPostForm(Form i_OpenedBy) : base(i_OpenedBy)
        {
            InitializeComponent();
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
                    FacebookAppManager.UploadPost(textBoxPostDetails.Text);
                }
                catch (Exception)
                {
                    MessageBoxHandler.ShowUserErrorMessageBox("Unable to upload post, Exception caught", "Error");
                }
            }
            else
            {
                MessageBoxHandler.ShowUserInformationMessageBox("Please fill in your post status", "Missing Details");
            }
        }
    }
}
