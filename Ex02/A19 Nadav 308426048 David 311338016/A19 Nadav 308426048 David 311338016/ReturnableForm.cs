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
    public abstract partial class ReturnableForm : DataLoggingForm
    {
        public ReturnableForm() { }

        public ReturnableForm(Form i_OpenedBy)
        {
            Owner = i_OpenedBy;
            InitializeComponent();
        }

        private void goBackToOwner()
        {
            Owner.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            goBackToOwner();
        }

        private void generalReturnButton_Click(object sender, EventArgs e)
        {
            Hide();
            goBackToOwner();
        }
    }
}
