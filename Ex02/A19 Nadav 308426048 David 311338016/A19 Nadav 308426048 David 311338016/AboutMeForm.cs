using System;
using FacebookWrapper.ObjectModel;
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
    public partial class AboutMeForm : ReturnableForm
    {
        private readonly User r_User;

        public AboutMeForm(Form i_OpenedBy) : base(i_OpenedBy)
        {
            r_User = FacebookAppManager.CurrentUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bindDataSourceToUser();
        }

        private void bindDataSourceToUser()
        {
            if (!listBoxMyName.InvokeRequired)
            {
                UserBindingSource.DataSource = r_User;
            }
            else
            {
                UserBindingSource.DataSource = r_User;
            }
        }
    }
}