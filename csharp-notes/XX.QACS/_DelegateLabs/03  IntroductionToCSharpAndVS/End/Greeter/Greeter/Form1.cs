using System;
using System.Globalization;
using System.Windows.Forms;

namespace Greeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there");
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            CultureInfo cultureGB = new CultureInfo("en-GB");

            textboxDate.Text = DateTime.Today.ToString("d", cultureGB); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
         DialogResult result = MessageBox.Show("Are you sure that you want to exit y/n ?", "Exit application", MessageBoxButtons.YesNo);

         if (result == DialogResult.No)
         {
             e.Cancel = true;
         }
        }
              
    }
}
