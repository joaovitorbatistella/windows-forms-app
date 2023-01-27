using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerEntity customer = new CustomerEntity();

                customer.Name = nameTextBox.Text;
                customer.Email  = emailTextBox.Text;
                customer.Password = passwordTextBox.Text;

                customer.save(customer);

                MessageBox.Show("Registered");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
