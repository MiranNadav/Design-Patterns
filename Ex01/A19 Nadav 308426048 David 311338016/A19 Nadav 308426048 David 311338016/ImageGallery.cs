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
    public partial class ImageGallery : Form
    {
        private readonly FacebookAppManager r_FacebookAppMananger;
        private Album m_CurrentAlbum;

        public ImageGallery(FacebookAppManager i_FacebookAppMananger)
        {
            InitializeComponent();
            r_FacebookAppMananger = i_FacebookAppMananger;
            fetchAlbumList();
        }

        private void fetchAlbumList()
        {
            foreach (Album album in r_FacebookAppMananger.Albums)
            {
                albumsListComboBox.Items.Add(album);
            }
        }

        private void populateImages()
        {
            //FacebookObjectCollection<Photo> currentAlbum = r_FacebookAppMananger.Albums[0].Photos;
            List<string> list = new List<string>();

            Point location = new Point(100, 100);

            for (int i = 0; i < m_CurrentAlbum.Photos.Count; i++)
            {
                PictureBox pb = new PictureBox();
                string currentPictureUrl = m_CurrentAlbum.Photos[i].PictureNormalURL;
                pb.LoadAsync(currentPictureUrl);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                if (i % 5 == 0)
                {
                    location.X = 100;
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
            populateImages();
        }
    }
}
