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
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    throw new Exception("Email and password can't be empty");
                }

                CustomerEntity customer = new CustomerEntity();

                Customer loggedCustomer = customer.login(emailTextBox.Text, passwordTextBox.Text);

                if (loggedCustomer == null)
                {
                    MessageBox.Show("Wrong email or password!");
                    return;
                }

                MessageBox.Show("Logged!");

                dashboradForm dashboard = new dashboradForm(loggedCustomer);
                dashboard.ShowDialog();


            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message + " - " + exception.StackTrace);
            }
        }

        private void dontHaveAccountLabel_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.ShowDialog();
        }
    }
}
