using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1.Forms
{
    public partial class loginForm : Form
    {
        List<User> users { get; set; }
        User user { get; set; }
        public loginForm(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void btnLogin(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    throw new Exception("Email and password can't be empty");
                }

                if (this.users.FindIndex(user => user.email == emailTextBox.Text && user.password == passwordTextBox.Text) == -1)
                {
                    throw new Exception("Email or password incoorects");
                } else
                {
                    this.user = this.users.Find(user => user.email == emailTextBox.Text && user.password == passwordTextBox.Text);
                }

                MessageBox.Show("Logged!");

                dashboradForm dashboard = new dashboradForm(this.user);
                dashboard.ShowDialog();


            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
