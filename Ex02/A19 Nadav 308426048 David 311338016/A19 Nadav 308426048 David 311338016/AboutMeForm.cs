using FacebookWrapper.ObjectModel;
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

namespace A19_Nadav_308426048_David_311338016
{
    public partial class AboutMeForm : Form
    {
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly User r_User;
        private Form m_OpenedBy;

        public AboutMeForm(Form i_OpenedBy)
        {
            r_FacebookAppManager = FacebookAppManager.GetFacebookManagerInstance();
            r_User = r_FacebookAppManager.CurrentUser;
            InitializeComponent();
            m_OpenedBy = i_OpenedBy;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(bindDataSourceToUser).Start();
        }

        private void bindDataSourceToUser()
        {
            if (!listBoxMyName.InvokeRequired)
            {
                userBindingSource.DataSource = r_User;
            }
            else
            {
                listBoxMyName.Invoke(new Action(() => userBindingSource.DataSource = r_User));
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_OpenedBy.Show();
        }

        private void AboutMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_OpenedBy.Show();
        }
    }
}