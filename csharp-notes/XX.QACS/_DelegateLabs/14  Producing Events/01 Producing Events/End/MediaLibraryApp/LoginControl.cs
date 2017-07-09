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

        // TODO 2 - declare a public instance of the (generic) event.
        // The name of the event is 'Login'
        // The name of the event args will be 'LoginEventArgs'
        // Have a go at declaring the event handler here
        // ie it will look similar to :
        //public event EventHandler<NameOfEventArgs>  NameOfEvent
        public event EventHandler<LoginEventArgs> Login;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // various checking, assume credentials checkout OK

            // TODO 3 - invoke the event
            // you must check whether the event is null (ie no-one has subscribed)
            // then .Invoke() it
            // sender = 'this'
            // payload = new up a LoginEventArgs giving txtUsername.Text as the constructor parameter
            // ie it will look similar to :
            // if (NameOfEvent != null) {
            //    NameOfEvent.Invoke(this, new LoginEventArgs(txtUsername.Text);
            //}
            //if (Login != null)
            //{
            //    Login.Invoke(this, new LoginEventArgs(txtUsername.Text));
            //}

            // Raise it elvis-style
            Login?.Invoke(this, new LoginEventArgs(txtUsername.Text));
        }

    }

    // TODO 1 - define your LoginEventArgs class
    // It is derived from 'EventArgs'
    // and has this bit of data in it
    // public readonly string Username;
    // it has an overloaded constructor that takes a 'string username' as a parameter
    public class LoginEventArgs : EventArgs
    {
        public readonly string Username;
        public LoginEventArgs(string username)
        {
            this.Username = username;
        }
    }
}
