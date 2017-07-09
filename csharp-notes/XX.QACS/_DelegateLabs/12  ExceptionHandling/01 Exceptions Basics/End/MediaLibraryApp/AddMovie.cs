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

            string title = txtTitle.Text.ToTitleCase(); // TODO : 1 what if .Text is null?
            string director = txtDirector.Text.ToTitleCase();
            string imageLocation = txtImageLocation.Text;

            TimeSpan duration;
            TimeSpan.TryParse(txtDuration.Text, out duration); // TODO : 2 duration text not a timespan?

            Rating rating;
            bool isRated = Enum.TryParse(cboRating.SelectedItem.ToString(), out rating); // TODO : 3 rating text not one of the enums?
            newItem = new Movie(title, director, imageLocation, duration);
            if (isRated) {
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

            // TODO : 4  what if the user cancels out of the OpenFileDialog?
            //ofd.ShowDialog(); 
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fiSelected = new FileInfo(ofd.FileName);
                FileInfo fiTarget = new FileInfo(Path.Combine(ofd.InitialDirectory, fiSelected.Name));
                if (!fiTarget.Exists)
                {
                    fiSelected.CopyTo(fiTarget.FullName); // TODO : 5 what if the user selects a file from the images folder so 'copy to yourself'?
                    txtImageLocation.Text = Path.Combine("images", fiSelected.Name);
                }
            }
        }
    }
}
