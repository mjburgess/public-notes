using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibraryApp
{

    public partial class LoginControl : UserControl
    {

        public event EventHandler<LoginEventArgs> Login;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Login != null)
            {
                Login.Invoke(this, new LoginEventArgs(txtUsername.Text));
            }
        }

    }

    public class LoginEventArgs : EventArgs
    {
        public readonly string Username;
        public LoginEventArgs(string username)
        {
            this.Username = username;
        }
    }
}
