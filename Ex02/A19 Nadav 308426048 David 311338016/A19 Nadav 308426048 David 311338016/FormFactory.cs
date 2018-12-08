using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Nadav_308426048_David_311338016
{
    class FormFactory
    {
        public static LoginForm GetLoginForm()
        {
            return new LoginForm();
        }

        public static MainFeedForm GetMAinFeedForm(LoginResult i_LoginResult, AppSettings i_AppSettings)
        {
            return new MainFeedForm(i_LoginResult, i_AppSettings);
        }

        public static FriendsBirthdayForm GetFreindsBirthdayForm(Form i_OpendBy)
        {
            return new FriendsBirthdayForm(i_OpendBy);
        }

        public static SearchForm GetSearchForm(Form i_OpendBy)
        {
            return new SearchForm(i_OpendBy);
        }

        public static ImageGalleryForm GetImageGalleryForm(Form i_OpendBy)
        {
            return new ImageGalleryForm(i_OpendBy);
        }

        public static UploadPostForm GetUploadPostForm(Form i_OpendBy)
        {
            return new UploadPostForm(i_OpendBy);
        }

        public static AboutMeForm GetAboutMeForm(Form i_OpendBy)
        {
            return new AboutMeForm(i_OpendBy);
        }
    }
}
