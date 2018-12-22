using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Nadav_308426048_David_311338016
{
    public static class MessageBoxHandler
    {
        public static DialogResult ShowUserMessageBoxWithResponse(string messageText, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(messageText, title, buttons, icon);

            return dialogResult;
        }

        public static void ShowUserInformationMessageBox(string messageText, string title)
        {
            MessageBox.Show(messageText, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowUserErrorMessageBox(string messageText, string title)
        {
            MessageBox.Show(messageText, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowUnableToFetchMessageBox()
        {
            MessageBox.Show("Unable to fetch data", "Error Fetching", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
