using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibraryApp
{
    public partial class AddMovie : Form
    {
        private MediaLibrary myMediaLibrary;

        public AddMovie(MediaLibrary myMediaLibrary)
        {
            InitializeComponent();
            cboRating.SelectedIndex = 0;
            this.myMediaLibrary = myMediaLibrary;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Movie newItem;

            string title = txtTitle.Text.ToTitleCase(); 
            string director = txtDirector.Text.ToTitleCase();
            string imageLocation = txtImageLocation.Text;

            TimeSpan duration;
            TimeSpan.TryParse(txtDuration.Text, out duration);

            Rating rating;
            bool isRated = Enum.TryParse(cboRating.SelectedItem.ToString(), out rating);
            newItem = new Movie(title, director, imageLocation, duration);
            if (isRated)
            {
                newItem.Rating = rating;
            }

            myMediaLibrary.Items.Add(newItem);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            string currentDir = (new FileInfo(Assembly.GetExecutingAssembly().Location)).DirectoryName;
            ofd.InitialDirectory = Path.Combine(currentDir, "images");
            ofd.Title = "Select a text file";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fiSelected = new FileInfo(ofd.FileName);
                FileInfo fiTarget = new FileInfo(Path.Combine(ofd.InitialDirectory, fiSelected.Name));
                if (!fiTarget.Exists)
                {
                    fiSelected.CopyTo(fiTarget.FullName); 
                    txtImageLocation.Text = Path.Combine("images", fiSelected.Name);
                }
            }
        }
    }
}
