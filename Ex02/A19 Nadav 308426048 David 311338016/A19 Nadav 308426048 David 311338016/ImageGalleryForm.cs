﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class ImageGalleryForm : Form
    {
        private readonly FacebookAppManager r_FacebookAppMananger;
        private Album m_CurrentAlbum;
        private Form m_OpenedBy;

        public ImageGalleryForm(Form i_OpenedBy)
        {
            r_FacebookAppMananger = FacebookAppManager.GetFacebookManagerInstance();
            m_OpenedBy = i_OpenedBy;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            new Thread(fetchAlbumList).Start();
        }

        private void fetchAlbumList()
        {
            foreach (Album album in r_FacebookAppMananger.Albums)
            {
                albumsListComboBox.Invoke(new Action(() => albumsListComboBox.Items.Add(album.Name)));
                //albumsListComboBox.Items.Add(album.Name);
            }
        }

        private void albumsListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAlbumIndex = albumsListComboBox.SelectedIndex;
            m_CurrentAlbum = r_FacebookAppMananger.Albums[selectedAlbumIndex];
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_OpenedBy.Show();
        }

        private void ImageGallery_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_OpenedBy.Show();
        }
    }
}