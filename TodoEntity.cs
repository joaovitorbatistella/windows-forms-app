using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TodoEntity : Todo
    {

        public IQueryable getFromCustomer(int customer_id)
        {
            using (var dbContext = new todoEntitiesEDM())
            {
                return dbContext.Todo.Where(x => x.Customer_Id == customer_id);
            }
            
        }
        public void save(Todo todo)
        {
            using(var dbContext = new todoEntitiesEDM()) 
            {
                var entitTodo = new Todo();
                entitTodo.Name = todo.Name;
                entitTodo.Checked = todo.Checked;
                entitTodo.Customer_Id = todo.Customer_Id;
    
                dbContext.Todo.Add(entitTodo);

                dbContext.SaveChanges();
            }
        }
    }
}
