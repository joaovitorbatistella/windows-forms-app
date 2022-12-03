using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class dashboradForm : Form
    {
        public User user { get; set; }
        public List<String> todos { get; set; }
        public dashboradForm(User user)
        {
            InitializeComponent();
            this.user = user;
            userNameLabel.Text = user.name;
            uidlabel.Text = "UID: "+user.uid;
        }

        private void addButtonClicked(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBoxDescription.Text))
            {
                //this.todos.Add(textBoxDescription.Text);
                //Console.WriteLine(textBoxDescription.Text.ToString());
                todoChecked.Items.Add(textBoxDescription.Text, CheckState.Unchecked);
                //this.user.toDoList = todoChecked;
                int itemsChecked = todoChecked.CheckedItems.Count;
                progressBarDash.Value = todoChecked.CheckedItems.Count*100 / todoChecked.Items.Count;
            }
        }

        private void onCheck(object sender, EventArgs e)
        {
            progressBarDash.Value = todoChecked.CheckedItems.Count * 100 / todoChecked.Items.Count;
        }

        private void logoutBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
