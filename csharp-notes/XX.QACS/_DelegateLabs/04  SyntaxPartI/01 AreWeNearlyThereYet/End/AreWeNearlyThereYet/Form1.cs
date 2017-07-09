using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreWeNearlyThereYet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void annoyDriverButton_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            do
            {
                answer = MessageBox.Show("Are we nearly there yet?", "Hey!", MessageBoxButtons.YesNo);
            } while (answer != DialogResult.Yes);

            MessageBox.Show("We're nearly there!", "YAY!");

        }
    }
}
