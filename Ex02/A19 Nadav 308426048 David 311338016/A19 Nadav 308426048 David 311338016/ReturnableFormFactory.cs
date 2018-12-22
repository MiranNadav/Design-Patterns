using System;
using FacebookWrapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Nadav_308426048_David_311338016
{
    public enum FormType
    {
        FriendsBirthday = 0,
        Search = 1,
        ImageGallery = 2,
        UploadPost = 3,
        AboutMe = 4
    }

    public class ReturnableFormFactory
    {
        public static Form GetForm(FormType i_FormType, Form i_OpenedBy)
        {
            Form toReturn = null;
            int formIndex = (int) i_FormType;
            switch (formIndex)
            {
                case 0:
                    toReturn = new FriendsBirthdayForm(i_OpenedBy);
                    break;
                case 1:
                    toReturn = new SearchForm(i_OpenedBy);
                    break;
                case 2:
                    toReturn = new ImageGalleryForm(i_OpenedBy);
                    break;
                case 3:
                    toReturn = new UploadPostForm(i_OpenedBy);
                    break;
                case 4:
                    toReturn = new AboutMeForm(i_OpenedBy);
                    break;
            }

            if (toReturn == null)
            {
                throw new ArgumentException("Invalid FormType given!!!");
            }

            return toReturn;
        }
    }
}