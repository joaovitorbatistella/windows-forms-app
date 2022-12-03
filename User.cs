using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class User
    {
        public User(
            string name,
            string email,
            string password
        )
        {
            Random random = new Random();
            const string chars = "abcdefgijklmnopqrstuvwxyz0123456789";

            this.name = name;
            this.email = email;
            this.password = password;
            this.uid = new string(Enumerable.Repeat(chars, 9).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string uid { get; set; }

        //public CheckedListBox toDoList { get; set; } 

    }
}
