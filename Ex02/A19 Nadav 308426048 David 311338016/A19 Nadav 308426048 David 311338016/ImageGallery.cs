using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class ImageGallery : Form
    {
        private readonly FacebookAppManager r_FacebookAppMananger;
        private Album m_CurrentAlbum;
        private Form m_OpenedBy;

        public ImageGallery(Form i_OpenedBy)
        {
            r_FacebookAppMananger = FacebookAppManager.GetFacebookManagerInstance();
            m_OpenedBy = i_OpenedBy;
            InitializeComponent();
            fetchAlbumList();
        }

        private void fetchAlbumList()
        {
            foreach (Album album in r_FacebookAppMananger.Albums)
            {
                albumsListComboBox.Items.Add(album.Name);
            }
        }

        private void populateImages()
        {
            List<string> list = new List<string>();

            Point location = new Point(10, 10);

            for (int i = 0; i < m_CurrentAlbum.Photos.Count; i++)
            {
                PictureBox pb = new PictureBox();

                string currentPictureUrl = m_CurrentAlbum.Photos[i].PictureNormalURL;
                pb.LoadAsync(currentPictureUrl);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                if (i % 5 == 0)
                {
                    location.X = 10;
                    location.Y += 100;
                }
                else
                {
                    location.X = location.X + 100;
                }

                pb.Location = location;
                Controls.Add(pb);
            }
        }

        private void albumsListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAlbumIndex = albumsListComboBox.SelectedIndex;
            m_CurrentAlbum = r_FacebookAppMananger.Albums[selectedAlbumIndex];
            cleanAllPictures();
            populateImages();
        }

        private void cleanAllPictures()
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Control control = Controls[i];
                if (control is PictureBox)
                {
                    Controls.RemoveAt(i);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_OpenedBy.Show();
        }
    }
}
