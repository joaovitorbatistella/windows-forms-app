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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class dashboradForm : Form
    {
        public Customer customer { get; set; }
        public List<String> todos { get; set; }
        public dashboradForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            userNameLabel.Text = customer.Name;
            uidlabel.Text = "UID: "+ customer.Uid;
            this.fillTodoList();

        }

        public void fillTodoList()
        {
            using (var dbContext = new todoEntitiesEDM())
            {
                TodoEntity entity = new TodoEntity();

                // var entTodo = entity.getFromCustomer(this.customer.Id);
                var entTodo =  dbContext.Todo.Where(x => x.Customer_Id == this.customer.Id);

                if (entTodo != null)
                {
                    foreach (var todo in entTodo)
                    {
                        todoChecked.Items.Add(todo.Name, todo.Checked == '\0' ? false : true);
                    }
                }
                if(todoChecked.Items.Count > 0)
                {
                    progressBarDash.Value = todoChecked.CheckedItems.Count * 100 / todoChecked.Items.Count;
                } else
                {
                    progressBarDash.Value = 0;
                }
            }
        }

        private void addButtonClicked(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBoxDescription.Text))
            {
                //this.todos.Add(textBoxDescription.Text);
                //Console.WriteLine(textBoxDescription.Text.ToString());
                todoChecked.Items.Add(textBoxDescription.Text, CheckState.Unchecked);
                //this.user.toDoList = todoChecked;
                try
                {
                    TodoEntity todo = new TodoEntity();

                    todo.Name = textBoxDescription.Text;
                    todo.Checked = '0';
                    todo.Customer_Id = this.customer.Id;

                    todo.save(todo);

                    MessageBox.Show("Todo created in DB");
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
                {
                    MessageBox.Show("ERROR dbEx: " + dbEx.Message + dbEx.InnerException);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }

                if (todoChecked.Items.Count > 0)
                {
                    progressBarDash.Value = todoChecked.CheckedItems.Count * 100 / todoChecked.Items.Count;
                }
                else
                {
                    progressBarDash.Value = 0;
                }
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
