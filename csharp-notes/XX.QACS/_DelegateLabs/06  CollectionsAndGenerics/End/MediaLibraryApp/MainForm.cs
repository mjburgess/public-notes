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

namespace MediaLibraryApp
{
    public partial class MainForm : Form
    {
        private int currentItemIndex = 0;

        private MediaLibrary myMediaLibrary;

        public MainForm()
        {
            InitializeComponent();
            myMediaLibrary = new MediaLibrary();
            myMediaLibrary.Title = "QA's Media Library";
        }

        private void mnuOpenLibrary_Click(object sender, EventArgs e)
        {
            MediaLibraryUtils.PopulateLibrary(myMediaLibrary);
            DisplayCurrentItem();
        }

        private void DisplayCurrentItem()
        {
            MediaItem currentItem = myMediaLibrary[currentItemIndex];
            titleTextBox.Text = currentItem.Title;
            ratingTextBox.Text = currentItem.Rating.ToString();
            coverImagePictureBox.ImageLocation = currentItem.ImageLocation;
            durationDisplayLabel.Text = currentItem.Duration.ToString();

            if (currentItem.MediaType == "Movie")
            {
                artistOrDirectorLabel.Text = "Director:";
            }
            else //currentItem MUST be a song!
            {
                artistOrDirectorLabel.Text = "Artist:";
            }
            artistOrDirectorTextBox.Text = currentItem.Artist;
            mediaStatusLabel.Text = "";
        }

        #region Navigation Controls
        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            currentItemIndex = 0;
            DisplayCurrentItem();
        }

        private void movePreviousButton_Click(object sender, EventArgs e)
        {
            currentItemIndex -= 1;
            if (currentItemIndex < 0)
            {
                currentItemIndex = 0;
            }
            DisplayCurrentItem();
        }

        private void moveNextButton_Click(object sender, EventArgs e)
        {
            currentItemIndex += 1;
            if (currentItemIndex > myMediaLibrary.Items.Count - 1)
            {
                currentItemIndex = myMediaLibrary.Items.Count - 1;
            }
            DisplayCurrentItem();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            currentItemIndex = myMediaLibrary.Items.Count - 1;
            DisplayCurrentItem();
        }
        #endregion

        #region Media Player Controls

        private void playMediaItemButton_Click(object sender, EventArgs e)
        {
            MediaItem mediaItem = myMediaLibrary[currentItemIndex];
            mediaItem.Play();
            mediaStatusLabel.Text = mediaItem.Status;
        }

        private void pauseMediaItemButton_Click(object sender, EventArgs e)
        {
            MediaItem mediaItem = myMediaLibrary[currentItemIndex];
            mediaItem.Pause();
            mediaStatusLabel.Text = mediaItem.Status;
        }

        private void stopMediaItemButton_Click(object sender, EventArgs e)
        {
            MediaItem mediaItem = myMediaLibrary[currentItemIndex];
            mediaItem.Stop();
            mediaStatusLabel.Text = mediaItem.Status;
        }

        #endregion

        private void btnViewByArtist_Click(object sender, EventArgs e)
        {
            ArtistsForm frm = new ArtistsForm(myMediaLibrary);
            frm.ShowDialog();
        }
    }

}