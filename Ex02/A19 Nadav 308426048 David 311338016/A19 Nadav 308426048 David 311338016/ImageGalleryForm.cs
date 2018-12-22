using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class ImageGalleryForm : ReturnableForm
    {
        private Album m_CurrentAlbum;

        public ImageGalleryForm(Form i_OpenedBy) : base(i_OpenedBy)
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchAlbumList();
        }

        private void fetchAlbumList()
        {
            foreach (Album album in FacebookAppManager.Albums)
            {
                albumsListComboBox.Items.Add(album.Name);
            }
        }

        private void albumsListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAlbumIndex = albumsListComboBox.SelectedIndex;
            m_CurrentAlbum = FacebookAppManager.Albums[selectedAlbumIndex];
            cleanAllPictures();
            populateImages();
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
    }
}
