using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibraryApp
{
    public partial class ArtistsForm : Form
    {

        Dictionary<string, List<MediaItem>> dictArtists = new Dictionary<string, List<MediaItem>>();

        public ArtistsForm(MediaLibrary myMediaLibrary)
        {
            InitializeComponent();
            CreateDictionary(myMediaLibrary);
            DisplayArtists();
        }


        private void CreateDictionary(MediaLibrary myMediaLibrary)
        {
            foreach (MediaItem mi in myMediaLibrary.Items)
            {
                if (!dictArtists.ContainsKey(mi.Artist))
                {
                    dictArtists.Add(mi.Artist, new List<MediaItem>());
                }
                dictArtists[mi.Artist].Add(mi);
            }
        }

        private void DisplayArtists()
        {
            lstArtists.Items.Clear();
            foreach (KeyValuePair<string, List<MediaItem>> kvp in dictArtists)
            {
                lstArtists.Items.Add(kvp.Key);
            }
        }

        private void lstArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProductions.Items.Clear();
            foreach (MediaItem mi in dictArtists[(string)lstArtists.SelectedItem])
            {
                lstProductions.Items.Add(mi.Title);
            }
        }


    }
}
