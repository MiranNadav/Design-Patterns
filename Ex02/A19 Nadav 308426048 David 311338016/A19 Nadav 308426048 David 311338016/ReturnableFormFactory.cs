using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Nadav_308426048_David_311338016
{

    public enum FormType
    {
        Login = 0,
        MainFeed = 1,
        FriendsBirthday = 1,
        Search = 2,
        ImageGallery = 3,
        UploadPost = 4,
        AboutMe = 5
    }

    class ReturnableFormFactory
    {
        public static Form GetForm (FormType i_FormType, Form i_OpenedBy)
        {
            Form toReturn = null;
            int formIndex = (int) i_FormType;
            switch (formIndex)
            {
                case 0:
                    toReturn = new LoginForm();
                    break;
                case 1:
                    toReturn = new FriendsBirthdayForm(i_OpenedBy);
                    break;
                case 2:
                    toReturn = new SearchForm(i_OpenedBy);
                    break;
                case 3:
                    toReturn = new ImageGalleryForm(i_OpenedBy);
                    break;
                case 4:
                    toReturn = new UploadPostForm(i_OpenedBy);
                    break;
                case 5:
                    toReturn = new AboutMeForm(i_OpenedBy);
                    break;
            }
            if (toReturn == null)
            {
                return null;
            }
            return toReturn;

        }
        public static LoginForm GetLoginForm()
        {
            return new LoginForm();
        }

        public static MainFeedForm GetMainFeedForm(LoginResult i_LoginResult, AppSettings i_AppSettings)
        {
            return new MainFeedForm(i_LoginResult, i_AppSettings);
        }

        public static FriendsBirthdayForm GetFriendsBirthdayForm(Form i_OpendBy)
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
