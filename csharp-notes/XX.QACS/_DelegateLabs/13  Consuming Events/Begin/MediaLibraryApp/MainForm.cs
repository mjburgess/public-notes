using BusinessLogic;
using Common;
using System;
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

            durationDisplayLabel.Text = currentItem as IPlayable != null ? ((IPlayable)currentItem).Duration.ToString() : "";

            artistOrDirectorTextBox.Text = currentItem.MainPerson;
            artistOrDirectorLabel.Text = currentItem.MainPersonRole;

            mediaStatusLabel.Text = "";
            mediaControlsGroupBox.Visible = currentItem as IPlayable != null ? true : false;
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
            ((IPlayable)mediaItem).Play(UpdateProgressBar);
            mediaStatusLabel.Text = mediaItem.Status;
        }

        private void pauseMediaItemButton_Click(object sender, EventArgs e)
        {
            MediaItem mediaItem = myMediaLibrary[currentItemIndex];
            ((IPlayable)mediaItem).Pause();
            mediaStatusLabel.Text = mediaItem.Status;
        }

        private void stopMediaItemButton_Click(object sender, EventArgs e)
        {
            MediaItem mediaItem = myMediaLibrary[currentItemIndex];
            ((IPlayable)mediaItem).Stop();
            mediaStatusLabel.Text = mediaItem.Status;
        }

        #endregion

        private void btnViewByArtist_Click(object sender, EventArgs e)
        {
            ArtistsForm frm = new ArtistsForm(myMediaLibrary);
            frm.ShowDialog();
        }

        private void UpdateProgressBar(int percent)
        {
            int pc = Math.Max(Math.Min(percent, 100), 0);
            if (this.InvokeRequired)
            {
                MethodInvoker mi = new MethodInvoker(() => playProgress.Value = pc);
                this.Invoke(mi);
            }
            else
            {
                playProgress.Value = pc;
            }
        }

        private void btnStartSound_Click(object sender, EventArgs e)
        {
            try
            {
                Sound.Initialize(delegate(double bassBoost)
                {
                    tbBassBoost.Value = (int)bassBoost;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuSearchLibrary_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(myMediaLibrary);
            sf.ShowDialog();
        }

        const string xmlFile = @".\lib.xml";
        private void mnuXMLWrite_Click(object sender, EventArgs e)
        {
            MediaLibraryUtils.SaveLibraryToXML(myMediaLibrary, xmlFile);
        }

        private void mnuXMLRead_Click(object sender, EventArgs e)
        {
            MediaLibraryUtils.ReadLibraryFromXML(myMediaLibrary, xmlFile);
            DisplayCurrentItem();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie(myMediaLibrary);
            addMovie.ShowDialog();
        }

    }

}
