using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibraryApp {
    public partial class MediaLibraryForm : Form {

        public MediaLibraryForm() {
            InitializeComponent();
        }

        private void btnAddMedia_Click(object sender, EventArgs e) {
            string title = txtTitle.Text;
            string artist = txtArtist.Text;
            string type = cboMediaType.Text;

            MediaItem newItem = new MediaItem();
            newItem.Artist = artist;
            newItem.Title = title;
            newItem.MediaType = type;

            string rating = GenerateRating();
            string format = "Oh, {0} by {1}. That is a {2} {3}!";
            string message = string.Format(format, newItem.Title, newItem.Artist, rating, newItem.MediaType);

            lstItems.Items.Add(message);
        }

        private Random ratingGenerator = new Random();
        const int lowestRating = 1;
        const int highestRating = 6;

        private string GenerateRating() {
            string rating;
            switch (ratingGenerator.Next(lowestRating, highestRating)) {
                case 1:
                    rating = "rubbish";
                    break;
                case 2:
                    rating = "so-so";
                    break;
                case 3:
                    rating = "mediocre";
                    break;
                case 4:
                    rating = "good";
                    break;
                case 5:
                    rating = "fantastic";
                    break;
                default:
                    rating = "unrated";
                    break;
            }
            return rating;
        }
    }
}
