using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesAndLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string userName;
        int repeatCount;

        private void initialiseVariablesButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            repeatCount = int.Parse(repeatCountTextBox.Text);
        }

        private void sayHelloButton_Click(object sender, EventArgs e)
        {
            //SayHello(userName, repeatCount);                  // positional parameters
            //SayHello(rCount:repeatCount, uName:userName);     // named parameters
            SayHello(uName: userName);                          // optional parameters
            SayHello();                                         // Method overloading
        }

        private void SayHello(string uName, int rCount = 3) {
            NewMethod(uName, rCount);
        }

        private static void NewMethod(string uName, int rCount) {
            string message = string.Format("Hello, {0}!", uName);
            for (int i = 0; i < rCount; i++) {
                MessageBox.Show(message, i.ToString());

                if (i >= 5) {
                    MessageBox.Show("You've got to be kidding!");
                    break;
                }
            }
        }

        private void SayHello() {
            string message = string.Format("Hello, {0}!", "Wilma");
            for (int i = 0; i < 4; i++) {
                MessageBox.Show(message, i.ToString());

                if (i >= 5) {
                    MessageBox.Show("You've got to be kidding!");
                    break;
                }
            }
        }
        //private int SayHello() {
        //    string message = string.Format("Hello, {0}!", "Wilma");
        //    for (int i = 0; i < 4; i++) {
        //        MessageBox.Show(message, i.ToString());

        //        if (i >= 5) {
        //            MessageBox.Show("You've got to be kidding!");
        //            break;
        //        }
        //    }
        //    return 0;
        //}
    }
}
