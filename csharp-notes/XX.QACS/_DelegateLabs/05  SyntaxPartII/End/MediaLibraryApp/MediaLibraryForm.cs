using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediaLibraryApp.Rating;

namespace MediaLibraryApp
{
    public partial class MediaLibraryForm : Form
    {

        public MediaLibraryForm()
        {
            InitializeComponent();
        }

        private void btnAddMedia_Click(object sender, EventArgs e)
        {
            //string title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtTitle.Text);
            string title = txtTitle.Text.ToTitleCase();
            string artist = txtArtist.Text.ToTitleCase();
            string mediaType = cboMediaType.Text;

            TimeSpan duration;
            TimeSpan.TryParse(txtDuration.Text, out duration);

            Rating rating = Unrated;

            //bool isRated = Enum.TryParse(cboRating.SelectedItem.ToString(), out rating); //fails if nothing selected
            
            //bool isRated;
            //if (cboRating.SelectedItem != null)
            //{
            //    isRated = Enum.TryParse(cboRating.SelectedItem.ToString(), out rating);
            //}
            //else
            //{
            //    isRated = false;
            //}

            // The above using the ternary operator
            bool isRated = (cboRating.SelectedItem != null) ? Enum.TryParse(cboRating.SelectedItem.ToString(), out rating) : false;

            MediaItem newItem = new MediaItem(title, artist, mediaType, duration);
            if (isRated)
            {
                newItem.Rating = rating;
            }

            AddToLibrary(newItem);
        }

        private MediaItem[] library;    // by convention we would normally group declarations
                                        // together at the top or bottom of the class
        private void AddToLibrary(MediaItem newItem)
        {
            if (library == null)
            {
                library = new MediaItem[1];
                library[0] = newItem;
            }
            else
            {
                int index = library.Length;
                Array.Resize(ref library, index + 1);
                library[index] = newItem;
            }

            string message = string.Format(
                "{0} by {1} - rated {2}", newItem.Title, newItem.Artist, newItem.Rating);

            lstItems.Items.Add(message);
        }
    }
}
