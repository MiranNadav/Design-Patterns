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
    public partial class FadeReturnForm : Form
    {
        private Form m_OpenedBy;
        public FacebookAppManager FacebookAppManager { get; set; }

        public FadeReturnForm(Form i_OpenedBy)
        {
            FacebookAppManager = FacebookAppManager.GetFacebookManagerInstance();
            m_OpenedBy = i_OpenedBy;
            Owner = i_OpenedBy;
            InitializeComponent();
        }

        private void goBackToOwner()
        {
            this.Hide();
            m_OpenedBy.Show();
            //Owner.Show();
        }

        public virtual void CloseForm()
        {
            Owner.Show();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0.0)
            {
                Opacity -= 0.325; // fade rate
            }
            else
            {
                fadeTimer.Stop();
                goBackToOwner();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            fadeTimer.Start();
        }

        private void generalReturnButton_Click(object sender, EventArgs e)
        {
            fadeTimer.Start();
        }
    }
}
