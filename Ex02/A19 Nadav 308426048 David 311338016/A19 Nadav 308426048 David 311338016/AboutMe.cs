using FacebookWrapper.ObjectModel;
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
    public partial class AboutMe : Form
    {
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly User r_User;
        private Form m_OpenedBy;

        public AboutMe(Form i_OpenedBy)
        {
            r_FacebookAppManager = FacebookAppManager.GetFacebookManagerInstance();
            r_User = r_FacebookAppManager.CurrentUser;
            
           //userBindingSource.DataSource = r_User;

            InitializeComponent();

            listBoxMyName.Invoke(new Action(() => userBindingSource.DataSource = r_User));
            m_OpenedBy = i_OpenedBy;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_OpenedBy.Show();
        }
    }
}
