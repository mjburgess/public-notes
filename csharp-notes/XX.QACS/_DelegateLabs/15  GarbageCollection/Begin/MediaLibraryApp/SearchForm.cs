using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaLibraryApp
{
    public partial class SearchForm : Form
    {
        private MediaLibrary myMediaLibrary;
        public SearchForm(MediaLibrary myMediaLibrary)
        {
            InitializeComponent();
            this.myMediaLibrary = myMediaLibrary;

        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            List<MediaItem> searchResults;
            string search = searchStringTextBox.Text.ToLower();

            searchResults = MediaLibraryQueries.SearchByForEach(myMediaLibrary, search);
            allItemsListBox.DataSource = searchResults;
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            List<MediaItem> searchResults;
            string search = searchStringTextBox.Text.ToLower();

            searchResults = MediaLibraryQueries.SearchByDelegate(myMediaLibrary, search);
            allItemsListBox.DataSource = searchResults;
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            List<MediaItem> searchResults;
            string search = searchStringTextBox.Text.ToLower();

            searchResults = MediaLibraryQueries.SearchByLambda(myMediaLibrary, search);
            allItemsListBox.DataSource = searchResults;
        }

        private void btnFindByType_Click(object sender, EventArgs e)
        {
            string search = searchStringTextBox.Text.ToLower();
            allItemsListBox.DataSource = 
                MediaLibraryQueries.FindByType(myMediaLibrary, search, chkUseQueryExpression.Checked);
        }

        private void btnFindByTitle_Click(object sender, EventArgs e)
        {
            string search = searchStringTextBox.Text.ToLower();
            allItemsListBox.DataSource =
                MediaLibraryQueries.FindByTitle(myMediaLibrary, search, chkUseQueryExpression.Checked);
        }

        private void btnFBTOrderByDuration_Click(object sender, EventArgs e)
        {
            string search = searchStringTextBox.Text.ToLower();
            allItemsListBox.DataSource =
                MediaLibraryQueries.FindByTitleAndOrderByDuration(myMediaLibrary, search);
        }

        private void btnFBTOrderByDesc_Click(object sender, EventArgs e)
        {
            string search = searchStringTextBox.Text.ToLower();
            allItemsListBox.DataSource =
                MediaLibraryQueries.FindByTitleAndOrderByDurationDesc(myMediaLibrary, search);
        }

        private void btnFindByDuration_Click(object sender, EventArgs e)
        {
            try
            {
                string search = searchStringTextBox.Text.ToLower();
                allItemsListBox.DataSource =
                    MediaLibraryQueries.FindByDuration(myMediaLibrary, search, chkUseQueryExpression.Checked);
            }
            catch (BenignException ex)
            {
                MessageBox.Show(ex.Message, "Search Error");
            }
        }
    }
}
