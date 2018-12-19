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
    public partial class ReturnableForm : Form
    {
        private Form m_OpenedBy;
        public FacebookAppManager FacebookAppManager { get; set; }

        public ReturnableForm()
        {
            //InitializeComponent();
        }
        public ReturnableForm(Form i_OpenedBy)
        {
            FacebookAppManager = FacebookAppManager.GetFacebookManagerInstance();
            m_OpenedBy = i_OpenedBy;
        }

        public virtual void GoBack()
        {
            this.Hide();
            m_OpenedBy.Show();
        }

        public virtual void CloseForm()
        {
            m_OpenedBy.Show();
        }
    }
}
